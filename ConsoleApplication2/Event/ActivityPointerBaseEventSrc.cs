﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ActivityPointerBaseEventSrc : SourceEvent
    {
        	public Guid? OwningBusinessUnit {get; set;}
	        public DateTime? ActualEnd  {get; set;}
	        public Byte[] VersionNumber {get; set;}

	        public Guid? ActivityId  {get; set;}

            public bool? IsBilled { get; set; }
            public Guid? CreatedBy { get; set; }

            //public string Description { get; set; }

            public DateTime? ModifiedOn { get; set; }
            public Guid? ServiceId { get; set; }

            public int? ActivityTypeCode { get; set; }
            public int? StateCode { get; set; }
            public DateTime? ScheduledEnd { get; set; }
            public int? ScheduledDurationMinutes { get; set; }
            public int? ActualDurationMinutes { get; set; }
            public int? StatusCode { get; set; }
            public DateTime? ActualStart { get; set; }
            public DateTime? CreatedOn { get; set; }
            public int? PriorityCode { get; set; }
            public Guid? RegardingObjectId { get; set; }
            public string Subject { get; set; }
            public bool? IsWorkflowCreated { get; set; }
            public DateTime? ScheduledStart { get; set; }
            public Guid? ModifiedBy { get; set; }
            public int? RegardingObjectTypeCode { get; set; }
            public string RegardingObjectIdName { get; set; }
            public int? TimeZoneRuleVersionNumber { get; set; }
            public int? UTCConversionTimeZoneCode { get; set; }
            public string RegardingObjectIdYomiName { get; set; }
            public DateTime? RecApptMstrOverriddenCreatedOn { get; set; }
            public string RecApptMstrGlobalObjectId { get; set; }
            public bool? SeriesStatus { get; set; }
            public int? RecApptMstrOutlookOwnerApptId { get; set; }
            public string DeletedExceptionsList { get; set; }
            public DateTime? NextExpansionInstanceDate { get; set; }
            public string RecApptMstrLocation { get; set; }
            public Guid? GroupId { get; set; }
            public DateTime? LastExpandedInstanceDate { get; set; }
            public int? ExpansionStateCode { get; set; }
            public string RecApptMstrCategory { get; set; }
            public bool? RecApptMstrIsAllDayEvent { get; set; }
            public string RecApptMstrSubcategory { get; set; }
            public Guid? RecApptMstrSubscriptionId { get; set; }
            public int? RecApptMstrImportSequenceNumber { get; set; }
            public string ModifiedFieldsMask { get; set; }
            public Guid? CreatedOnBehalfBy { get; set; }
            public Guid? OwnerId { get; set; }
            public int? InstanceTypeCode { get; set; }
            public Guid? SeriesId { get; set; }
            public Guid? TransactionCurrencyId { get; set; }
            public decimal? ExchangeRate { get; set; }
            public bool? IsRegularActivity { get; set; }
            public DateTime? OriginalStartDate { get; set; }
            public Guid? ModifiedOnBehalfBy { get; set; }
            public int? OwnerIdType { get; set; }
            public DateTime? QteCloseOverriddenCreatedOn { get; set; }
            public string QuoteNumber { get; set; }
            public int? QteCloseImportSequenceNumber { get; set; }
            public string QteCloseCategory { get; set; }
            public int? QteCloseRevision { get; set; }
            public string QteCloseSubcategory { get; set; }
            public string ApptCategory { get; set; }
            public string ApptGlobalObjectId { get; set; }
            public bool? ApptIsAllDayEvent { get; set; }
            public int? ApptImportSequenceNumber { get; set; }
            public int? ApptOutlookOwnerApptId { get; set; }
            public DateTime? ApptOverriddenCreatedOn { get; set; }
            public string ApptSubcategory { get; set; }
            public Guid? ApptSubscriptionId { get; set; }
            public string ApptLocation { get; set; }
            public decimal? ActualCost_Base { get; set; }
            public int? CampActImportSequenceNumber { get; set; }
            public decimal? BudgetedCost_Base { get; set; }
            public decimal? ActualCost { get; set; }
            public bool? IgnoreInactiveListMembers { get; set; }
            public bool? DoNotSendOnOptOut { get; set; }
            public int? TypeCode { get; set; }
            public string CampActSubcategory { get; set; }
            public DateTime? CampActOverriddenCreatedOn { get; set; }
            public int? ExcludeIfContactedInXDays { get; set; }
            public string CampActCategory { get; set; }
            public decimal? BudgetedCost { get; set; }
            public int? CampActChannelTypeCode { get; set; }
            public string FirstName { get; set; }
            public DateTime? ReceivedOn { get; set; }
            public int? ResponseCode { get; set; }
            public string YomiLastName { get; set; }
            public DateTime? CampResOverriddenCreatedOn { get; set; }
            public string YomiFirstName { get; set; }
            public string CompanyName { get; set; }
            public string CampResCategory { get; set; }
            public string Telephone { get; set; }
            public Guid? OriginatingActivityId { get; set; }
            public string Fax { get; set; }
            public string LastName { get; set; }
            public int? CampResImportSequenceNumber { get; set; }
            public int? OriginatingActivityIdTypeCode { get; set; }
            public string EMailAddress { get; set; }
            public int? CampResChannelTypeCode { get; set; }
            public string YomiCompanyName { get; set; }
            public string PromotionCodeName { get; set; }
            public string CampResSubcategory { get; set; }
            public int? SuccessCount { get; set; }
            public int? OperationTypeCode { get; set; }
            public string BulkOperationNumber { get; set; }
            public int? TargetMembersCount { get; set; }
            public int? CreatedRecordTypeCode { get; set; }
            public string Parameters { get; set; }
            public int? ErrorNumber { get; set; }
            public int? TargetedRecordTypeCode { get; set; }
            public int? FailureCount { get; set; }
            public bool? Compressed { get; set; }
            public bool? ReadReceiptRequested { get; set; }
            public bool? DeliveryReceiptRequested { get; set; }
            public string EmailSubcategory { get; set; }
            public int? Notifications { get; set; }
            public string MessageId { get; set; }
            public string Sender { get; set; }
            public string ToRecipients { get; set; }
            public DateTime? EmailOverriddenCreatedOn { get; set; }
            public string SubmittedBy { get; set; }
            public int? EmailImportSequenceNumber { get; set; }
            public bool? EmailDirectionCode { get; set; }
            public string MimeType { get; set; }
            public Guid? MessageIdDupCheck { get; set; }
            public int? DeliveryAttempts { get; set; }
            public string TrackingToken { get; set; }
            public string EmailCategory { get; set; }
            public int? SvcApptImportSequenceNumber { get; set; }
            public string SvcApptLocation { get; set; }
            public bool? SvcApptIsAllDayEvent { get; set; }
            public string SvcApptSubcategory { get; set; }
            public Guid? SiteId { get; set; }
            public DateTime? SvcApptOverriddenCreatedOn { get; set; }
            public string SvcApptCategory { get; set; }
            public Guid? SvcApptSubscriptionId { get; set; }
            public string TaskCategory { get; set; }
            public int? PercentComplete { get; set; }
            public DateTime? TaskOverriddenCreatedOn { get; set; }
            public Guid? TaskSubscriptionId { get; set; }
            public string TaskSubcategory { get; set; }
            public int? TaskImportSequenceNumber { get; set; }
            public string Address { get; set; }
            public int? LetterImportSequenceNumber { get; set; }
            public Guid? LetterSubscriptionId { get; set; }
            public string LetterCategory { get; set; }
            public string LetterSubcategory { get; set; }
            public bool? LetterDirectionCode { get; set; }
            public DateTime? LetterOverriddenCreatedOn { get; set; }
            public DateTime? PhoneOverriddenCreatedOn { get; set; }
            public int? PhoneImportSequenceNumber { get; set; }
            public string PhoneNumber { get; set; }
            public string PhoneSubcategory { get; set; }
            public bool? PhoneDirectionCode { get; set; }
            public Guid? PhoneSubscriptionId { get; set; }
            public string PhoneCategory { get; set; }
            public string OrdCloseSubcategory { get; set; }
            public int? OrdCloseImportSequenceNumber { get; set; }
            public int? OrdCloseRevision { get; set; }
            public string OrderNumber { get; set; }
            public string OrdCloseCategory { get; set; }
            public DateTime? OrdCloseOverriddenCreatedOn { get; set; }
            public string FaxNumber { get; set; }
            public string CoverPageName { get; set; }
            public int? NumberOfPages { get; set; }
            public Guid? FaxSubscriptionId { get; set; }
            public int? FaxImportSequenceNumber { get; set; }
            public string BillingCode { get; set; }
            public string Tsid { get; set; }
            public bool? FaxDirectionCode { get; set; }
            public DateTime? FaxOverriddenCreatedOn { get; set; }
            public string FaxSubcategory { get; set; }
            public string FaxCategory { get; set; }
            public string IncResSubcategory { get; set; }
            public string IncResCategory { get; set; }
            public int? IncResImportSequenceNumber { get; set; }
            public DateTime? IncResOverriddenCreatedOn { get; set; }
            public int? TimeSpent { get; set; }
            public Guid? CompetitorId { get; set; }
            public DateTime? OppCloseOverriddenCreatedOn { get; set; }
            public int? OppCloseImportSequenceNumber { get; set; }
            public decimal? ActualRevenue_Base { get; set; }
            public decimal? ActualRevenue { get; set; }
            public string OppCloseSubcategory { get; set; }
            public string OppCloseCategory { get; set; }
            public bool? IsMapiPrivate { get; set; }
            public bool? LeftVoiceMail { get; set; }
            public int? EmailAttachmentCount { get; set; }
            public string ConversationIndex { get; set; }
            public string InReplyTo { get; set; }
            public int? CorrelationMethod { get; set; }
            public int? BaseConversationIndexHash { get; set; }
            public Guid? ParentActivityId { get; set; }
            public Guid? SenderMailboxId { get; set; }
            public DateTime? DeliveryLastAttemptedOn { get; set; }
            public Guid? StageId { get; set; }
            public DateTime? SentOn { get; set; }
            public int? DeliveryPriorityCode { get; set; }
            public DateTime? PostponeActivityProcessingUntil { get; set; }
            public Guid? ProcessId { get; set; }
            public int? PostMessageType { get; set; }
            public int? ImportSequenceNumber { get; set; }
            public string InResponseTo { get; set; }
            public Guid? PostAuthor { get; set; }
            public DateTime? PostedOn { get; set; }
            public DateTime? OverriddenCreatedOn { get; set; }
            public string ThreadId { get; set; }
            public string SocialAdditionalParams { get; set; }
            public string PostURL { get; set; }
            public Guid? PostFromProfileId { get; set; }
            public bool? SocialActivityDirectionCode { get; set; }
            public string PostId { get; set; }
            public float? SentimentValue { get; set; }
            public Guid? PostAuthorAccount { get; set; }
            public string PostToProfileId { get; set; }
            public string PostAuthorAccountName { get; set; }
            public int? PostAuthorAccountType { get; set; }
            public int? PostAuthorType { get; set; }
            public string PostAuthorName { get; set; }
            public string PostAuthorYomiName { get; set; }
            public string PostAuthorAccountYomiName { get; set; }
            public int? Community { get; set; }
            public Guid? EmailSender { get; set; }
            public Guid? SendersAccount { get; set; }
            public int? EmailSenderObjectTypeCode { get; set; }
            public string EmailSenderName { get; set; }
            public string SendersAccountName { get; set; }
            public int? SendersAccountObjectTypeCode { get; set; }
            public string EmailSenderYomiName { get; set; }
            public string SendersAccountYomiName { get; set; }
    }
}
