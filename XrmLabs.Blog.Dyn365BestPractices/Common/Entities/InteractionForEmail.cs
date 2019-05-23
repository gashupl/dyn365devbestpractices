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
	public enum InteractionForEmailState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("interactionforemail")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class InteractionForEmail : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string EmailActivityId = "emailactivityid";
			public const string EmailAddress = "emailaddress";
			public const string EmailInteractionReplyId = "emailinteractionreplyid";
			public const string EmailInteractionTime = "emailinteractiontime";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string InteractedComponentText = "interactedcomponenttext";
			public const string InteractionForEmailId = "interactionforemailid";
			public const string Id = "interactionforemailid";
			public const string InteractionLocation = "interactionlocation";
			public const string InteractionPartyId = "interactionpartyid";
			public const string InteractionRepliedBy = "interactionrepliedby";
			public const string InteractionReplyId = "interactionreplyid";
			public const string InteractionType = "interactiontype";
			public const string InteractionUserAgent = "interactionuseragent";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string name = "name";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_interactionforemail = "business_unit_interactionforemail";
			public const string lk_interactionforemail_createdby = "lk_interactionforemail_createdby";
			public const string lk_interactionforemail_createdonbehalfby = "lk_interactionforemail_createdonbehalfby";
			public const string lk_interactionforemail_modifiedby = "lk_interactionforemail_modifiedby";
			public const string lk_interactionforemail_modifiedonbehalfby = "lk_interactionforemail_modifiedonbehalfby";
			public const string team_interactionforemail = "team_interactionforemail";
			public const string TransactionCurrency_InteractionForEmail = "TransactionCurrency_InteractionForEmail";
			public const string user_interactionforemail = "user_interactionforemail";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public InteractionForEmail() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "interactionforemail";
		
		public const string PrimaryIdAttribute = "interactionforemailid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 9986;
		
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
		/// Email Activity Id.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailactivityid")]
		public System.Nullable<System.Guid> EmailActivityId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("emailactivityid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
		public string EmailAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("emailaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EmailAddress");
				this.SetAttributeValue("emailaddress", value);
				this.OnPropertyChanged("EmailAddress");
			}
		}
		
		/// <summary>
		/// Email Activity Id.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailinteractionreplyid")]
		public System.Nullable<System.Guid> EmailInteractionReplyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("emailinteractionreplyid");
			}
		}
		
		/// <summary>
		/// Shows the Interaction date and time of the an email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailinteractiontime")]
		public System.Nullable<System.DateTime> EmailInteractionTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("emailinteractiontime");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the InteractionForEmail with respect to the base currency.
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
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interactedcomponenttext")]
		public string InteractedComponentText
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("interactedcomponenttext");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InteractedComponentText");
				this.SetAttributeValue("interactedcomponenttext", value);
				this.OnPropertyChanged("InteractedComponentText");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interactionforemailid")]
		public System.Nullable<System.Guid> InteractionForEmailId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("interactionforemailid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InteractionForEmailId");
				this.SetAttributeValue("interactionforemailid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("InteractionForEmailId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interactionforemailid")]
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
				this.InteractionForEmailId = value;
			}
		}
		
		/// <summary>
		/// Shows the location for an Interaction
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interactionlocation")]
		public string InteractionLocation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("interactionlocation");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InteractionLocation");
				this.SetAttributeValue("interactionlocation", value);
				this.OnPropertyChanged("InteractionLocation");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interactionpartyid")]
		public System.Nullable<System.Guid> InteractionPartyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("interactionpartyid");
			}
		}
		
		/// <summary>
		/// Shows the Name who replied to email if interaction is reply
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interactionrepliedby")]
		public string InteractionRepliedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("interactionrepliedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InteractionRepliedBy");
				this.SetAttributeValue("interactionrepliedby", value);
				this.OnPropertyChanged("InteractionRepliedBy");
			}
		}
		
		/// <summary>
		/// InteractionReplyId
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interactionreplyid")]
		public string InteractionReplyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("interactionreplyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InteractionReplyId");
				this.SetAttributeValue("interactionreplyid", value);
				this.OnPropertyChanged("InteractionReplyId");
			}
		}
		
		/// <summary>
		/// Shows the type of Interaction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interactiontype")]
		public Microsoft.Xrm.Sdk.OptionSetValue InteractionType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("interactiontype");
			}
		}
		
		/// <summary>
		/// Shows the User Agent for an Interaction if available
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interactionuseragent")]
		public string InteractionUserAgent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("interactionuseragent");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InteractionUserAgent");
				this.SetAttributeValue("interactionuseragent", value);
				this.OnPropertyChanged("InteractionUserAgent");
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
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("name");
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
		/// Unique identifier of the user or team who owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Interaction for Email
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Common.Entities.InteractionForEmailState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Common.Entities.InteractionForEmailState)(System.Enum.ToObject(typeof(Common.Entities.InteractionForEmailState), optionSet.Value)));
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
		/// Reason for the status of the Interaction for Email
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
		/// Exchange rate for the currency associated with the InteractionForEmail with respect to the base currency.
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
		/// 
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
		/// 1:N interactionforemail_ActivityPointers
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("interactionforemail_ActivityPointers")]
		public System.Collections.Generic.IEnumerable<Common.Entities.ActivityPointer> interactionforemail_ActivityPointers
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.ActivityPointer>("interactionforemail_ActivityPointers", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("interactionforemail_ActivityPointers");
				this.SetRelatedEntities<Common.Entities.ActivityPointer>("interactionforemail_ActivityPointers", null, value);
				this.OnPropertyChanged("interactionforemail_ActivityPointers");
			}
		}
		
		/// <summary>
		/// 1:N interactionforemail_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("interactionforemail_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Common.Entities.AsyncOperation> interactionforemail_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.AsyncOperation>("interactionforemail_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("interactionforemail_AsyncOperations");
				this.SetRelatedEntities<Common.Entities.AsyncOperation>("interactionforemail_AsyncOperations", null, value);
				this.OnPropertyChanged("interactionforemail_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N interactionforemail_BulkOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("interactionforemail_BulkOperations")]
		public System.Collections.Generic.IEnumerable<Common.Entities.BulkOperation> interactionforemail_BulkOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.BulkOperation>("interactionforemail_BulkOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("interactionforemail_BulkOperations");
				this.SetRelatedEntities<Common.Entities.BulkOperation>("interactionforemail_BulkOperations", null, value);
				this.OnPropertyChanged("interactionforemail_BulkOperations");
			}
		}
		
		/// <summary>
		/// 1:N interactionforemail_CampaignResponses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("interactionforemail_CampaignResponses")]
		public System.Collections.Generic.IEnumerable<Common.Entities.CampaignResponse> interactionforemail_CampaignResponses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.CampaignResponse>("interactionforemail_CampaignResponses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("interactionforemail_CampaignResponses");
				this.SetRelatedEntities<Common.Entities.CampaignResponse>("interactionforemail_CampaignResponses", null, value);
				this.OnPropertyChanged("interactionforemail_CampaignResponses");
			}
		}
		
		/// <summary>
		/// 1:N interactionforemail_IncidentResolutions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("interactionforemail_IncidentResolutions")]
		public System.Collections.Generic.IEnumerable<Common.Entities.IncidentResolution> interactionforemail_IncidentResolutions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.IncidentResolution>("interactionforemail_IncidentResolutions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("interactionforemail_IncidentResolutions");
				this.SetRelatedEntities<Common.Entities.IncidentResolution>("interactionforemail_IncidentResolutions", null, value);
				this.OnPropertyChanged("interactionforemail_IncidentResolutions");
			}
		}
		
		/// <summary>
		/// 1:N interactionforemail_OpportunityCloses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("interactionforemail_OpportunityCloses")]
		public System.Collections.Generic.IEnumerable<Common.Entities.OpportunityClose> interactionforemail_OpportunityCloses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.OpportunityClose>("interactionforemail_OpportunityCloses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("interactionforemail_OpportunityCloses");
				this.SetRelatedEntities<Common.Entities.OpportunityClose>("interactionforemail_OpportunityCloses", null, value);
				this.OnPropertyChanged("interactionforemail_OpportunityCloses");
			}
		}
		
		/// <summary>
		/// 1:N interactionforemail_OrderCloses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("interactionforemail_OrderCloses")]
		public System.Collections.Generic.IEnumerable<Common.Entities.OrderClose> interactionforemail_OrderCloses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.OrderClose>("interactionforemail_OrderCloses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("interactionforemail_OrderCloses");
				this.SetRelatedEntities<Common.Entities.OrderClose>("interactionforemail_OrderCloses", null, value);
				this.OnPropertyChanged("interactionforemail_OrderCloses");
			}
		}
		
		/// <summary>
		/// 1:N interactionforemail_QuoteCloses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("interactionforemail_QuoteCloses")]
		public System.Collections.Generic.IEnumerable<Common.Entities.QuoteClose> interactionforemail_QuoteCloses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.QuoteClose>("interactionforemail_QuoteCloses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("interactionforemail_QuoteCloses");
				this.SetRelatedEntities<Common.Entities.QuoteClose>("interactionforemail_QuoteCloses", null, value);
				this.OnPropertyChanged("interactionforemail_QuoteCloses");
			}
		}
		
		/// <summary>
		/// 1:N interactionforemail_ServiceAppointments
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("interactionforemail_ServiceAppointments")]
		public System.Collections.Generic.IEnumerable<Common.Entities.ServiceAppointment> interactionforemail_ServiceAppointments
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.ServiceAppointment>("interactionforemail_ServiceAppointments", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("interactionforemail_ServiceAppointments");
				this.SetRelatedEntities<Common.Entities.ServiceAppointment>("interactionforemail_ServiceAppointments", null, value);
				this.OnPropertyChanged("interactionforemail_ServiceAppointments");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_interactionforemail
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_interactionforemail")]
		public Common.Entities.BusinessUnit business_unit_interactionforemail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.BusinessUnit>("business_unit_interactionforemail", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_interactionforemail_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_interactionforemail_createdby")]
		public Common.Entities.SystemUser lk_interactionforemail_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_interactionforemail_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_interactionforemail_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_interactionforemail_createdonbehalfby")]
		public Common.Entities.SystemUser lk_interactionforemail_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_interactionforemail_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_interactionforemail_createdonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_interactionforemail_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_interactionforemail_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_interactionforemail_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_interactionforemail_modifiedby")]
		public Common.Entities.SystemUser lk_interactionforemail_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_interactionforemail_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_interactionforemail_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_interactionforemail_modifiedonbehalfby")]
		public Common.Entities.SystemUser lk_interactionforemail_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_interactionforemail_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_interactionforemail_modifiedonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_interactionforemail_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_interactionforemail_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 team_interactionforemail
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_interactionforemail")]
		public Common.Entities.Team team_interactionforemail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Team>("team_interactionforemail", null);
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_InteractionForEmail
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_InteractionForEmail")]
		public Common.Entities.TransactionCurrency TransactionCurrency_InteractionForEmail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.TransactionCurrency>("TransactionCurrency_InteractionForEmail", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrency_InteractionForEmail");
				this.SetRelatedEntity<Common.Entities.TransactionCurrency>("TransactionCurrency_InteractionForEmail", null, value);
				this.OnPropertyChanged("TransactionCurrency_InteractionForEmail");
			}
		}
		
		/// <summary>
		/// N:1 user_interactionforemail
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_interactionforemail")]
		public Common.Entities.SystemUser user_interactionforemail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("user_interactionforemail", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public InteractionForEmail(object anonymousType) : 
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
                        Attributes["interactionforemailid"] = base.Id;
                        break;
                    case "interactionforemailid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interactiontype")]
		public virtual InteractionForEmail_InteractionType? InteractionTypeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((InteractionForEmail_InteractionType?)(EntityOptionSetEnum.GetEnum(this, "interactiontype")));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual InteractionForEmail_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((InteractionForEmail_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}