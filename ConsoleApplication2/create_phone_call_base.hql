SET hbase.zookeeper.quorum=zookeepernode0,zookeepernode1,zookeepernode2;  
CREATE EXTERNAL TABLE PhoneCallBase(ActivityId string ,
mbs_phonestatus int ,
mbs_gsxactivityid string ,
mcs_dialstarttime string ,
mcs_Duration string ,
mcs_HoldTime string)
STORED BY 'org.apache.hadoop.hive.hbase.HBaseStorageHandler'
WITH SERDEPROPERTIES ('hbase.columns.mapping' = ':key, cf:mbs_phonestatus,cf:mbs_gsxactivityid,cf:mcs_dialstarttime,cf:mcs_Duration,cf:mcs_HoldTime') 
TBLPROPERTIES ('hbase.table.name' = 'PhoneCallBase');
