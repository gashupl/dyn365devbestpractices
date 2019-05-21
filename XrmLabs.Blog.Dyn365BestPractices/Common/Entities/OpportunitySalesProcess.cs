//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.Entities
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public enum OpportunitySalesProcessState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Opportunity Sales Process Business Process Flow
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("opportunitysalesprocess")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class OpportunitySalesProcess : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ActiveStageId = "activestageid";
			public const string ActiveStageStartedOn = "activestagestartedon";
			public const string BusinessProcessFlowInstanceId = "businessprocessflowinstanceid";
			public const string Id = "businessprocessflowinstanceid";
			public const string CompletedOn = "completedon";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Duration = "duration";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OpportunityId = "opportunityid";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string ProcessId = "processid";
			public const string QuoteId = "quoteid";
			public const string SalesOrderId = "salesorderid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TraversedPath = "traversedpath";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string lk_opportunitysalesprocess_activestageid = "lk_opportunitysalesprocess_activestageid";
			public const string lk_opportunitysalesprocess_createdby = "lk_opportunitysalesprocess_createdby";
			public const string lk_opportunitysalesprocess_createdonbehalfby = "lk_opportunitysalesprocess_createdonbehalfby";
			public const string lk_opportunitysalesprocess_modifiedby = "lk_opportunitysalesprocess_modifiedby";
			public const string lk_opportunitysalesprocess_modifiedonbehalfby = "lk_opportunitysalesprocess_modifiedonbehalfby";
			public const string lk_opportunitysalesprocess_opportunityid = "lk_opportunitysalesprocess_opportunityid";
			public const string lk_opportunitysalesprocess_processid = "lk_opportunitysalesprocess_processid";
			public const string lk_opportunitysalesprocess_quoteid = "lk_opportunitysalesprocess_quoteid";
			public const string lk_opportunitysalesprocess_salesorderid = "lk_opportunitysalesprocess_salesorderid";
			public const string organization_opportunitysalesprocess = "organization_opportunitysalesprocess";
			public const string transactioncurrency_opportunitysalesprocess = "transactioncurrency_opportunitysalesprocess";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public OpportunitySalesProcess() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "opportunitysalesprocess";
		
		public const string PrimaryIdAttribute = "businessprocessflowinstanceid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 953;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the active stage for the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activestageid")]
		public Microsoft.Xrm.Sdk.EntityReference ActiveStageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activestageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActiveStageId");
				this.SetAttributeValue("activestageid", value);
				this.OnPropertyChanged("ActiveStageId");
			}
		}
		
		/// <summary>
		/// Date and time when current active stage is started.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activestagestartedon")]
		public System.Nullable<System.DateTime> ActiveStageStartedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("activestagestartedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActiveStageStartedOn");
				this.SetAttributeValue("activestagestartedon", value);
				this.OnPropertyChanged("ActiveStageStartedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier for Opportunity Sales Process bpf entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessprocessflowinstanceid")]
		public System.Nullable<System.Guid> BusinessProcessFlowInstanceId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("businessprocessflowinstanceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BusinessProcessFlowInstanceId");
				this.SetAttributeValue("businessprocessflowinstanceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("BusinessProcessFlowInstanceId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessprocessflowinstanceid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.BusinessProcessFlowInstanceId = value;
			}
		}
		
		/// <summary>
		/// Date and time when Business Process Flow instance is completed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedon")]
		public System.Nullable<System.DateTime> CompletedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("completedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CompletedOn");
				this.SetAttributeValue("completedon", value);
				this.OnPropertyChanged("CompletedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Duration the business process flow was active.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duration")]
		public System.Nullable<int> Duration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("duration");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Process Name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the workflow associated to the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
		public Microsoft.Xrm.Sdk.EntityReference OpportunityId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("opportunityid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OpportunityId");
				this.SetAttributeValue("opportunityid", value);
				this.OnPropertyChanged("OpportunityId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the workflow associated to the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public Microsoft.Xrm.Sdk.EntityReference ProcessId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("processid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the workflow associated to the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteid")]
		public Microsoft.Xrm.Sdk.EntityReference QuoteId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("quoteid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("QuoteId");
				this.SetAttributeValue("quoteid", value);
				this.OnPropertyChanged("QuoteId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the workflow associated to the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesorderid")]
		public Microsoft.Xrm.Sdk.EntityReference SalesOrderId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("salesorderid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SalesOrderId");
				this.SetAttributeValue("salesorderid", value);
				this.OnPropertyChanged("SalesOrderId");
			}
		}
		
		/// <summary>
		/// Shows whether the Delve action record is pending, completed, or tracking.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Common.Entities.OpportunitySalesProcessState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Common.Entities.OpportunitySalesProcessState)(System.Enum.ToObject(typeof(Common.Entities.OpportunitySalesProcessState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Select the delve action record status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Comma delimited string of process stage ids that represent visited stages of the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N lk_opportunitysalesprocess_workflowlogs
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitysalesprocess_workflowlogs")]
		public System.Collections.Generic.IEnumerable<Common.Entities.WorkflowLog> lk_opportunitysalesprocess_workflowlogs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.WorkflowLog>("lk_opportunitysalesprocess_workflowlogs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_opportunitysalesprocess_workflowlogs");
				this.SetRelatedEntities<Common.Entities.WorkflowLog>("lk_opportunitysalesprocess_workflowlogs", null, value);
				this.OnPropertyChanged("lk_opportunitysalesprocess_workflowlogs");
			}
		}
		
		/// <summary>
		/// 1:N opportunitysalesprocess_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitysalesprocess_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Common.Entities.AsyncOperation> opportunitysalesprocess_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.AsyncOperation>("opportunitysalesprocess_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunitysalesprocess_AsyncOperations");
				this.SetRelatedEntities<Common.Entities.AsyncOperation>("opportunitysalesprocess_AsyncOperations", null, value);
				this.OnPropertyChanged("opportunitysalesprocess_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N opportunitysalesprocess_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitysalesprocess_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Common.Entities.BulkDeleteFailure> opportunitysalesprocess_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.BulkDeleteFailure>("opportunitysalesprocess_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunitysalesprocess_BulkDeleteFailures");
				this.SetRelatedEntities<Common.Entities.BulkDeleteFailure>("opportunitysalesprocess_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("opportunitysalesprocess_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N opportunitysalesprocess_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitysalesprocess_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<Common.Entities.MailboxTrackingFolder> opportunitysalesprocess_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.MailboxTrackingFolder>("opportunitysalesprocess_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunitysalesprocess_MailboxTrackingFolders");
				this.SetRelatedEntities<Common.Entities.MailboxTrackingFolder>("opportunitysalesprocess_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("opportunitysalesprocess_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N opportunitysalesprocess_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitysalesprocess_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<Common.Entities.PrincipalObjectAttributeAccess> opportunitysalesprocess_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.PrincipalObjectAttributeAccess>("opportunitysalesprocess_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunitysalesprocess_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<Common.Entities.PrincipalObjectAttributeAccess>("opportunitysalesprocess_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("opportunitysalesprocess_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N opportunitysalesprocess_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitysalesprocess_ProcessSession")]
		public System.Collections.Generic.IEnumerable<Common.Entities.ProcessSession> opportunitysalesprocess_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.ProcessSession>("opportunitysalesprocess_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunitysalesprocess_ProcessSession");
				this.SetRelatedEntities<Common.Entities.ProcessSession>("opportunitysalesprocess_ProcessSession", null, value);
				this.OnPropertyChanged("opportunitysalesprocess_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N OpportunitySalesProcess_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunitySalesProcess_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Common.Entities.SyncError> OpportunitySalesProcess_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.SyncError>("OpportunitySalesProcess_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OpportunitySalesProcess_SyncErrors");
				this.SetRelatedEntities<Common.Entities.SyncError>("OpportunitySalesProcess_SyncErrors", null, value);
				this.OnPropertyChanged("OpportunitySalesProcess_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N opportunitysalesprocess_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitysalesprocess_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<Common.Entities.UserEntityInstanceData> opportunitysalesprocess_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.UserEntityInstanceData>("opportunitysalesprocess_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunitysalesprocess_UserEntityInstanceDatas");
				this.SetRelatedEntities<Common.Entities.UserEntityInstanceData>("opportunitysalesprocess_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("opportunitysalesprocess_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunitysalesprocess_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activestageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitysalesprocess_activestageid")]
		public Common.Entities.ProcessStage lk_opportunitysalesprocess_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.ProcessStage>("lk_opportunitysalesprocess_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_opportunitysalesprocess_activestageid");
				this.SetRelatedEntity<Common.Entities.ProcessStage>("lk_opportunitysalesprocess_activestageid", null, value);
				this.OnPropertyChanged("lk_opportunitysalesprocess_activestageid");
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunitysalesprocess_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitysalesprocess_createdby")]
		public Common.Entities.SystemUser lk_opportunitysalesprocess_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_opportunitysalesprocess_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunitysalesprocess_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitysalesprocess_createdonbehalfby")]
		public Common.Entities.SystemUser lk_opportunitysalesprocess_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_opportunitysalesprocess_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_opportunitysalesprocess_createdonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_opportunitysalesprocess_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_opportunitysalesprocess_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunitysalesprocess_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitysalesprocess_modifiedby")]
		public Common.Entities.SystemUser lk_opportunitysalesprocess_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_opportunitysalesprocess_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunitysalesprocess_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitysalesprocess_modifiedonbehalfby")]
		public Common.Entities.SystemUser lk_opportunitysalesprocess_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_opportunitysalesprocess_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_opportunitysalesprocess_modifiedonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_opportunitysalesprocess_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_opportunitysalesprocess_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunitysalesprocess_opportunityid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitysalesprocess_opportunityid")]
		public Common.Entities.Opportunity lk_opportunitysalesprocess_opportunityid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Opportunity>("lk_opportunitysalesprocess_opportunityid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_opportunitysalesprocess_opportunityid");
				this.SetRelatedEntity<Common.Entities.Opportunity>("lk_opportunitysalesprocess_opportunityid", null, value);
				this.OnPropertyChanged("lk_opportunitysalesprocess_opportunityid");
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunitysalesprocess_processid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitysalesprocess_processid")]
		public Common.Entities.Workflow lk_opportunitysalesprocess_processid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Workflow>("lk_opportunitysalesprocess_processid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_opportunitysalesprocess_processid");
				this.SetRelatedEntity<Common.Entities.Workflow>("lk_opportunitysalesprocess_processid", null, value);
				this.OnPropertyChanged("lk_opportunitysalesprocess_processid");
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunitysalesprocess_quoteid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitysalesprocess_quoteid")]
		public Common.Entities.Quote lk_opportunitysalesprocess_quoteid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Quote>("lk_opportunitysalesprocess_quoteid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_opportunitysalesprocess_quoteid");
				this.SetRelatedEntity<Common.Entities.Quote>("lk_opportunitysalesprocess_quoteid", null, value);
				this.OnPropertyChanged("lk_opportunitysalesprocess_quoteid");
			}
		}
		
		/// <summary>
		/// N:1 lk_opportunitysalesprocess_salesorderid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesorderid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitysalesprocess_salesorderid")]
		public Common.Entities.SalesOrder lk_opportunitysalesprocess_salesorderid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SalesOrder>("lk_opportunitysalesprocess_salesorderid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_opportunitysalesprocess_salesorderid");
				this.SetRelatedEntity<Common.Entities.SalesOrder>("lk_opportunitysalesprocess_salesorderid", null, value);
				this.OnPropertyChanged("lk_opportunitysalesprocess_salesorderid");
			}
		}
		
		/// <summary>
		/// N:1 organization_opportunitysalesprocess
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_opportunitysalesprocess")]
		public Common.Entities.Organization organization_opportunitysalesprocess
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Organization>("organization_opportunitysalesprocess", null);
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_opportunitysalesprocess
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_opportunitysalesprocess")]
		public Common.Entities.TransactionCurrency transactioncurrency_opportunitysalesprocess
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.TransactionCurrency>("transactioncurrency_opportunitysalesprocess", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("transactioncurrency_opportunitysalesprocess");
				this.SetRelatedEntity<Common.Entities.TransactionCurrency>("transactioncurrency_opportunitysalesprocess", null, value);
				this.OnPropertyChanged("transactioncurrency_opportunitysalesprocess");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public OpportunitySalesProcess(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["businessprocessflowinstanceid"] = base.Id;
                        break;
                    case "businessprocessflowinstanceid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual OpportunitySalesProcess_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((OpportunitySalesProcess_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}