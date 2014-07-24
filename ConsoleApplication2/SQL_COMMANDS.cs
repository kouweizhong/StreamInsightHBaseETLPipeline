﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SQL_COMMANDS
    {
        public static string SALES_HISTORY = "select SaleID, Product, SaleDate, CAST( StatusID AS int) as StatusID, SalePrice from [CaptureChanges].[dbo].[SalesHistory]";
        public static string CAPTURE_CHANGES_CONN = "Data Source=BRSMBVSQLDEV1;Initial Catalog=CaptureChanges;Persist Security Info=True;User ID=t-ankigu;Password=password1";
        public static string TIGER_REPL_CONN = "Data Source=BRSMBVSQLDEV1;Initial Catalog=TigerRepl;Persist Security Info=True;User ID=t-ankigu;Password=password1";
        public static string OPPORTUNITY_BASE = "SELECT * FROM [dbo].[OpportunityBase]";
        public static string ACTIVITY_BASE = @"SELECT [OwningBusinessUnit]
                                                  ,[ActualEnd]
                                                  ,[VersionNumber]
                                                  ,[ActivityId] 
                                                  ,[IsBilled] 
                                                  ,[CreatedBy] 
                                                  ,[ModifiedOn]
                                                  ,[ServiceId] 
                                                  ,[ActivityTypeCode] 
                                                  ,[StateCode]
                                                  ,[ScheduledEnd]
                                                  ,[ScheduledDurationMinutes]
                                                  ,[ActualDurationMinutes]
                                                  ,[StatusCode]
                                                  ,[ActualStart]
                                                  ,[CreatedOn]
                                                  ,[PriorityCode]
                                                  ,[RegardingObjectId]
                                                  ,[Subject]
                                                  ,[IsWorkflowCreated]
                                                  ,[ScheduledStart]
                                                  ,[ModifiedBy]  
                                                  ,[RegardingObjectTypeCode]
                                                  ,[RegardingObjectIdName]
                                                  ,[TimeZoneRuleVersionNumber]
                                                  ,[UTCConversionTimeZoneCode]
                                                  ,[RegardingObjectIdYomiName]
                                                  ,[RecApptMstrOverriddenCreatedOn]
                                                  ,[RecApptMstrGlobalObjectId]
                                                  ,[SeriesStatus]
                                                  ,[RecApptMstrOutlookOwnerApptId]
                                                  ,[DeletedExceptionsList]
                                                  ,[NextExpansionInstanceDate]
                                                  ,[RecApptMstrLocation]
                                                  ,[GroupId]
                                                  ,[LastExpandedInstanceDate]
                                                  ,[ExpansionStateCode]
                                                  ,[RecApptMstrCategory]
                                                  ,[RecApptMstrIsAllDayEvent]
                                                  ,[RecApptMstrSubcategory]
                                                  ,[RecApptMstrSubscriptionId]
                                                  ,[RecApptMstrImportSequenceNumber]
                                                  ,[ModifiedFieldsMask]
                                                  ,[CreatedOnBehalfBy]
                                                  ,[OwnerId] 
                                                  ,[InstanceTypeCode]
                                                  ,[SeriesId]
                                                  ,[TransactionCurrencyId]
                                                  ,[ExchangeRate]
                                                  ,[IsRegularActivity] 
                                                  ,[OriginalStartDate]
                                                  ,[ModifiedOnBehalfBy]
                                                  ,[OwnerIdType]
                                                  ,[QteCloseOverriddenCreatedOn]
                                                  ,[QuoteNumber]
                                                  ,[QteCloseImportSequenceNumber]
                                                  ,[QteCloseCategory]
                                                  ,[QteCloseRevision]
                                                  ,[QteCloseSubcategory]
                                                  ,[ApptCategory]
                                                  ,[ApptGlobalObjectId]
                                                  ,[ApptIsAllDayEvent]
                                                  ,[ApptImportSequenceNumber]
                                                  ,[ApptOutlookOwnerApptId]
                                                  ,[ApptOverriddenCreatedOn]
                                                  ,[ApptSubcategory]
                                                  ,[ApptSubscriptionId]
                                                  ,[ApptLocation]
                                                  ,[ActualCost_Base]
                                                  ,[CampActImportSequenceNumber]
                                                  ,[BudgetedCost_Base]
                                                  ,[ActualCost] 
                                                  ,[IgnoreInactiveListMembers]
                                                  ,[DoNotSendOnOptOut]
                                                  ,[TypeCode] 
                                                  ,[CampActSubcategory]
                                                  ,[CampActOverriddenCreatedOn]
                                                  ,[ExcludeIfContactedInXDays]
                                                  ,[CampActCategory]
                                                  ,[BudgetedCost]
                                                  ,[CampActChannelTypeCode]
                                                  ,[FirstName]
                                                  ,[ReceivedOn]
                                                  ,[ResponseCode]
                                                  ,[YomiLastName]
                                                  ,[CampResOverriddenCreatedOn]
                                                  ,[YomiFirstName]
                                                  ,[CompanyName]
                                                  ,[CampResCategory]
                                                  ,[Telephone]
                                                  ,[OriginatingActivityId]
                                                  ,[Fax]
                                                  ,[LastName]
                                                  ,[CampResImportSequenceNumber]
                                                  ,[OriginatingActivityIdTypeCode]
                                                  ,[EMailAddress]
                                                  ,[CampResChannelTypeCode]
                                                  ,[YomiCompanyName]
                                                  ,[PromotionCodeName]
                                                  ,[CampResSubcategory]
                                                  ,[SuccessCount]
                                                  ,[OperationTypeCode]
                                                  ,[BulkOperationNumber]
                                                  ,[TargetMembersCount]
                                                  ,[CreatedRecordTypeCode]
                                                  ,[Parameters]
                                                  ,[ErrorNumber]
                                                  ,[TargetedRecordTypeCode]
                                                  ,[FailureCount] 
                                                  ,[Compressed]
                                                  ,[ReadReceiptRequested]
                                                  ,[DeliveryReceiptRequested]
                                                  ,[EmailSubcategory]
                                                  ,[Notifications]
                                                  ,[MessageId]
                                                  ,[Sender]
                                                  ,[ToRecipients] 
                                                  ,[EmailOverriddenCreatedOn]
                                                  ,[SubmittedBy]
                                                  ,[EmailImportSequenceNumber]
                                                  ,[EmailDirectionCode]
                                                  ,[MimeType]
                                                  ,[MessageIdDupCheck]
                                                  ,[DeliveryAttempts]
                                                  ,[TrackingToken]
                                                  ,[EmailCategory]
                                                  ,[SvcApptImportSequenceNumber]
                                                  ,[SvcApptLocation]
                                                  ,[SvcApptIsAllDayEvent]
                                                  ,[SvcApptSubcategory]
                                                  ,[SiteId]
                                                  ,[SvcApptOverriddenCreatedOn]
                                                  ,[SvcApptCategory]
                                                  ,[SvcApptSubscriptionId]
                                                  ,[TaskCategory]
                                                  ,[PercentComplete]
                                                  ,[TaskOverriddenCreatedOn]
                                                  ,[TaskSubscriptionId]
                                                  ,[TaskSubcategory]
                                                  ,[TaskImportSequenceNumber]
                                                  ,[Address]
                                                  ,[LetterImportSequenceNumber]
                                                  ,[LetterSubscriptionId]
                                                  ,[LetterCategory]
                                                  ,[LetterSubcategory]
                                                  ,[LetterDirectionCode]
                                                  ,[LetterOverriddenCreatedOn]
                                                  ,[PhoneOverriddenCreatedOn]
                                                  ,[PhoneImportSequenceNumber]
                                                  ,[PhoneNumber]
                                                  ,[PhoneSubcategory]
                                                  ,[PhoneDirectionCode]
                                                  ,[PhoneSubscriptionId]
                                                  ,[PhoneCategory]
                                                  ,[OrdCloseSubcategory]
                                                  ,[OrdCloseImportSequenceNumber]
                                                  ,[OrdCloseRevision]
                                                  ,[OrderNumber]
                                                  ,[OrdCloseCategory]
                                                  ,[OrdCloseOverriddenCreatedOn]
                                                  ,[FaxNumber]
                                                  ,[CoverPageName]
                                                  ,[NumberOfPages]
                                                  ,[FaxSubscriptionId]
                                                  ,[FaxImportSequenceNumber]
                                                  ,[BillingCode]
                                                  ,[Tsid] 
                                                  ,[FaxDirectionCode]
                                                  ,[FaxOverriddenCreatedOn]
                                                  ,[FaxSubcategory]
                                                  ,[FaxCategory]
                                                  ,[IncResSubcategory]
                                                  ,[IncResCategory]
                                                  ,[IncResImportSequenceNumber]
                                                  ,[IncResOverriddenCreatedOn]
                                                  ,[TimeSpent]
                                                  ,[CompetitorId]
                                                  ,[OppCloseOverriddenCreatedOn]
                                                  ,[OppCloseImportSequenceNumber]
                                                  ,[ActualRevenue_Base]
                                                  ,[ActualRevenue]
                                                  ,[OppCloseSubcategory]
                                                  ,[OppCloseCategory]
                                                  ,[IsMapiPrivate]
                                                  ,[LeftVoiceMail]
                                                  ,[EmailAttachmentCount]
                                                  ,[ConversationIndex]
                                                  ,[InReplyTo]
                                                  ,[CorrelationMethod]
                                                  ,[BaseConversationIndexHash]
                                                  ,[ParentActivityId]
                                                  ,[SenderMailboxId]
                                                  ,[DeliveryLastAttemptedOn]
                                                  ,[StageId]
                                                  ,[SentOn]
                                                  ,[DeliveryPriorityCode]
                                                  ,[PostponeActivityProcessingUntil]
                                                  ,[ProcessId]
                                                  ,[PostMessageType]
                                                  ,[ImportSequenceNumber]
                                                  ,[InResponseTo]
                                                  ,[PostAuthor]
                                                  ,[PostedOn]
                                                  ,[OverriddenCreatedOn]
                                                  ,[ThreadId]
                                                  ,[SocialAdditionalParams]
                                                  ,[PostURL]
                                                  ,[PostFromProfileId]
                                                  ,[SocialActivityDirectionCode]
                                                  ,[PostId] 
                                                  ,[SentimentValue]
                                                  ,[PostAuthorAccount]
                                                  ,[PostToProfileId]
                                                  ,[PostAuthorAccountName]
                                                  ,[PostAuthorAccountType]
                                                  ,[PostAuthorType]
                                                  ,[PostAuthorName]
                                                  ,[PostAuthorYomiName]
                                                  ,[PostAuthorAccountYomiName]
                                                  ,[Community]
                                                  ,[EmailSender]
                                                  ,[SendersAccount]
                                                  ,[EmailSenderObjectTypeCode]
                                                  ,[EmailSenderName]
                                                  ,[SendersAccountName]
                                                  ,[SendersAccountObjectTypeCode]
                                                  ,[EmailSenderYomiName]
                                                  ,[SendersAccountYomiName]
                                              FROM [dbo].[ActivityPointerBase]
                                              where [ActivityId] not in (select top 1262000 ActivityId from dbo.ActivityPointerBase)";
        //                                                  ,[Description] 

        public static string PHONE_CALL_BASE = "SELECT * FROM [dbo].[PhoneCallBase]";
        public static string ACCOUNT_BASE = @"SELECT [AccountId] 
                                      ,[AccountCategoryCode] 
                                      ,[TerritoryId] 
                                      ,[DefaultPriceLevelId]
                                      ,[CustomerSizeCode]
                                      ,[PreferredContactMethodCode]
                                      ,[CustomerTypeCode]
                                      ,[AccountRatingCode]
                                      ,[IndustryCode]
                                      ,[TerritoryCode]
                                      ,[AccountClassificationCode]
                                      ,[BusinessTypeCode]
                                      ,[OwningBusinessUnit]
                                      ,[OriginatingLeadId]
                                      ,[PaymentTermsCode]
                                      ,[ShippingMethodCode]
                                      ,[PrimaryContactId]
                                      ,[ParticipatesInWorkflow]
                                      ,[Name] 
                                      ,[AccountNumber]
                                      ,[Revenue]
                                      ,[NumberOfEmployees]
                                      ,[Description]
                                      ,[SIC]
                                      ,[OwnershipCode]
                                      ,[MarketCap]
                                      ,[SharesOutstanding]
                                      ,[TickerSymbol]
                                      ,[StockExchange]
                                      ,[WebSiteURL]
                                      ,[FtpSiteURL]
                                      ,[EMailAddress1]
                                      ,[EMailAddress2]
                                      ,[EMailAddress3]
                                      ,[DoNotPhone]
                                      ,[DoNotFax]
                                      ,[Telephone1]
                                      ,[DoNotEMail]
                                      ,[Telephone2]
                                      ,[Fax]
                                      ,[Telephone3]
                                      ,[DoNotPostalMail]
                                      ,[DoNotBulkEMail]
                                      ,[DoNotBulkPostalMail]
                                      ,[CreditLimit]
                                      ,[CreditOnHold]
                                      ,[IsPrivate]
                                      ,[CreatedOn] 
                                      ,[CreatedBy]
                                      ,[ModifiedOn]
                                      ,[ModifiedBy]
                                      ,[VersionNumber] 
                                      ,[ParentAccountId]
                                      ,[Aging30]
                                      ,[StateCode]
                                      ,[Aging60]
                                      ,[StatusCode]
                                      ,[Aging90]
                                      ,[PreferredAppointmentDayCode]
                                      ,[PreferredSystemUserId]
                                      ,[PreferredAppointmentTimeCode]
                                      ,[Merged]
                                      ,[DoNotSendMM]
                                      ,[MasterId]
                                      ,[LastUsedInCampaign]
                                      ,[PreferredServiceId]
                                      ,[PreferredEquipmentId]
                                      ,[ExchangeRate]
                                      ,[UTCConversionTimeZoneCode]
                                      ,[OverriddenCreatedOn]
                                      ,[TimeZoneRuleVersionNumber]
                                      ,[ImportSequenceNumber]
                                      ,[TransactionCurrencyId]
                                      ,[CreditLimit_Base]
                                      ,[Aging30_Base]
                                      ,[Revenue_Base]
                                      ,[Aging90_Base]
                                      ,[MarketCap_Base]
                                      ,[Aging60_Base]
                                      ,[YomiName]
                                      ,[OwnerId]
                                      ,[ModifiedOnBehalfBy]
                                      ,[CreatedOnBehalfBy]
                                      ,[OwnerIdType]
                                      ,[EntityImageId]
                                      ,[ProcessId]
                                      ,[StageId]
                                      ,[new_ManagedTerritory]
                                      ,[new_AccountTS]
                                      ,[mbs_SalesDistrictId]
                                      ,[mbs_stateid]
                                      ,[mbs_serverstotal]
                                      ,[new_ATUName]
                                      ,[new_Industry]
                                      ,[mbs_tenantid]
                                      ,[mbs_crmrecorduniqueid]
                                      ,[new_CRMServerLicenses]
                                      ,[mbs_Segment]
                                      ,[mbs_SalesSubDistrictId]
                                      ,[mbs_LeadCountry]
                                      ,[new_ATUGroupName]
                                      ,[mbs_hierarchylevelid]
                                      ,[mbs_pcdevicestotal]
                                      ,[new_Vertical]
                                      ,[new_VerticalCategory]
                                      ,[mbs_StateProvidence]
                                      ,[new_SubSegment]
                                      ,[new_Segment]
                                      ,[mbs_itbudget_Base]
                                      ,[mbs_msorgid]
                                      ,[mbs_SubSegment]
                                      ,[new_AccountManager]
                                      ,[mbs_countryid]
                                      ,[new_ManagedVertical]
                                      ,[mbs_industryid]
                                      ,[mbs_itbudget]
                                      ,[mbs_mioid]
                                      ,[new_MSSalesTPID]
                                      ,[new_CRMUserLicences]
                                      ,[mbs_fiscalcalendarstart]
                                      ,[new_GSXAccountID]
                                      ,[mbs_dunsnumber]
                                      ,[mbs_pccounttotalorg]
                                      ,[new_ATUManager]
                                      ,[mbs_TaxID]
                                  FROM [dbo].[AccountBase]";
    }
}