﻿using System;
using System.ServiceModel;
using Microsoft.ComplexEventProcessing;
using Microsoft.ComplexEventProcessing.Linq;
using Microsoft.ComplexEventProcessing.ManagementService;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;


namespace ConsoleApplication2
{
    class ChangeDatabase<T> where T : ConsoleApplication2.ChangeEvent
    {
        //public class ChangeDatabaseEvent
        //{
        //    //public string Start_Lsn { get; set; }
        //    //public string End_Lsn { get; set; }
        //    //public string Seqval { get; set; }
        //    //public int Operation { get; set; }
        //    //public string Update_Mask {get; set; }
        //    public int SaleID { get; set; }
        //    public string Product { get; set; }
        //    public DateTime SaleDate { get; set; }
        //    public DateTime TransactionTime { get; set; }
        //    public int Operation { get; set; }
        //    public int StatusID { get; set; }
        //    public decimal SalePrice { get; set; }

        //}

        private string TABLENAME = "";
        private string CONNECTION_STRING = "";
        private string SQL_QUERY = "";
        private string HBASE_ROW_KEY = "";
        private static Scripts.RequestHolder requestHolder;

        public ChangeDatabase(string tableName, string key, string connectionString, string sqlQuery){
            this.TABLENAME = tableName;
            this.HBASE_ROW_KEY = key;
            this.CONNECTION_STRING = connectionString;
            this.SQL_QUERY = sqlQuery;
        }

     
        public void begin(Application myApp, string processName)
        {

                string conn_string = this.CONNECTION_STRING;
                string sql_query = this.SQL_QUERY;
                System.Reactive.Linq.IQbservable<T> qSource2 = myApp.DefineObservable<T>(() => new ObservablePoller<T>(conn_string, sql_query, 5000));

                var streamable = qSource2.ToPointStreamable(x => PointEvent.CreateInsert(DateTime.Now, x), AdvanceTimeSettings.IncreasingStartTime);

                requestHolder = new Scripts.RequestHolder(this.TABLENAME, 500);
                requestHolder.rowBody = new Scripts.RowBody();
                requestHolder.rowBody.Row = new List<Scripts.RowElement>();

                // DEFINE a simple observer SINK (writes the value to the server console)
                //var mySink = myApp.DefineObserver(() => Observer.Create<ChangeDatabaseEvent>(x => Console.WriteLine("sinkserver: " + x.Product + " SaleDate:" + x.SaleDate + " TransTime:" + x.TransactionTime)));
                string hbase_row_key = this.HBASE_ROW_KEY.Clone().ToString();
                var mySink2 = myApp.DefineObserver(() => Observer.Create<T>(x => Sink<T>(x, hbase_row_key)));


                // Compose a QUERY over the source (return every even-numbered event)
            
                var myQuery2 = from e in streamable
                               select e;
                 
                // BIND the query to the sink and RUN it
                using (IDisposable proc = myQuery2.Bind<T>(mySink2).Run("fdfdf"))
                {
                    // Wait for the user stops the server
                    //IDisposable proc2 = myQuery2.ToObservable().Subscribe(Console.WriteLine);
                    //myQuery2.Bind(mySink2).Run("Server2");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("MyStreamInsightServer is running, press Enter to stop the server");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.ReadLine();
                }
                Console.ReadLine();
        }

        //private static PointEvent<ChangeDatabaseEvent> CreatePoint(ChangeDatabaseEvent e)
        //{
        //    //Console.WriteLine("source " + e.Product + " " + e.SaleDate);
        //    //Console.WriteLine(e.SaleID);
        //    return PointEvent.CreateInsert<ChangeDatabaseEvent>(DateTime.Now, e);
        //}

        
        private static int hitCount = 0;
        private static void Sink<T> (T x, string hbase_row_key)
        {
            Console.WriteLine("Sink hit count: " + hitCount++);
            ChangeEvent rowevent = (ChangeEvent)(object)x;
            PropertyInfo[] props = rowevent.GetType().GetProperties();

            List<Scripts.CellElement> cells = new List<Scripts.CellElement>();
            string key = "";

            foreach (PropertyInfo pi in props)
            {
                //skip the PrimaryKey which acts as key in HBase
                if (pi.Name == hbase_row_key)
                {
                    Console.WriteLine("key: " + pi.GetValue(rowevent, null).ToString());
                    key = Scripts.ToBase64(pi.GetValue(rowevent, null).ToString());
                    continue;
                }

                // if have Byte[], need to convert to string
                if (pi.PropertyType == typeof(Byte[]))
                {
                    string byteCol = Scripts.ToBase64("cf:" + pi.Name);
                    string byteVal = Scripts.ToBase64(pi.GetValue(rowevent, null) == null ? "NULL" : BitConverter.ToString((Byte[])pi.GetValue(rowevent, null)));
                    Scripts.CellElement byteCell = new Scripts.CellElement { column = byteCol, value = byteVal };
                    cells.Add(byteCell);
                    continue;
                }

                //set up cellelement with column and value
                

                string col = Scripts.ToBase64("cf:" + pi.Name);
                string val = pi.GetValue(rowevent, null) == null ? "NULL" : pi.GetValue(rowevent, null).ToString();

                Console.WriteLine("col: " + pi.Name);
                Console.WriteLine("val: " + val);

                val = Scripts.ToBase64(val);
                
                Scripts.CellElement cell = new Scripts.CellElement { column = col, value = val };
                cells.Add(cell);
            };

            Scripts.RowElement row = new Scripts.RowElement() { key = key, Cell = cells };

            requestHolder.addRow(row);
          
        }


    }
}
