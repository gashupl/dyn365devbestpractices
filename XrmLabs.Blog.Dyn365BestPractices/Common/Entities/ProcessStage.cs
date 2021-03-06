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
	
	/// <summary>
	/// Stage associated with a process.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("processstage")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ProcessStage : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ClientData = "clientdata";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string PrimaryEntityTypeCode = "primaryentitytypecode";
			public const string ProcessId = "processid";
			public const string ProcessStageId = "processstageid";
			public const string Id = "processstageid";
			public const string StageCategory = "stagecategory";
			public const string StageName = "stagename";
			public const string VersionNumber = "versionnumber";
			public const string process_processstage = "process_processstage";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ProcessStage() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "processstage";
		
		public const string PrimaryIdAttribute = "processstageid";
		
		public const string PrimaryNameAttribute = "stagename";
		
		public const int EntityTypeCode = 4724;
		
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
		/// Step metadata for process stage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clientdata")]
		public string ClientData
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("clientdata");
			}
		}
		
		/// <summary>
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
		
		/// <summary>
		/// Select the business unit that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public System.Nullable<System.Guid> OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Primary entity associated with the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentitytypecode")]
		public string PrimaryEntityTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("primaryentitytypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PrimaryEntityTypeCode");
				this.SetAttributeValue("primaryentitytypecode", value);
				this.OnPropertyChanged("PrimaryEntityTypeCode");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process.
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
		/// Shows the ID of the process stage record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processstageid")]
		public System.Nullable<System.Guid> ProcessStageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processstageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessStageId");
				this.SetAttributeValue("processstageid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ProcessStageId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processstageid")]
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
				this.ProcessStageId = value;
			}
		}
		
		/// <summary>
		/// Select the category of the sales process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stagecategory")]
		public Microsoft.Xrm.Sdk.OptionSetValue StageCategory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("stagecategory");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StageCategory");
				this.SetAttributeValue("stagecategory", value);
				this.OnPropertyChanged("StageCategory");
			}
		}
		
		/// <summary>
		/// Type a name for the process stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stagename")]
		public string StageName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("stagename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StageName");
				this.SetAttributeValue("stagename", value);
				this.OnPropertyChanged("StageName");
			}
		}
		
		/// <summary>
		/// Version number of the process stage.
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
		/// 1:N lk_expiredprocess_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_expiredprocess_activestageid")]
		public System.Collections.Generic.IEnumerable<Common.Entities.ExpiredProcess> lk_expiredprocess_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.ExpiredProcess>("lk_expiredprocess_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_expiredprocess_activestageid");
				this.SetRelatedEntities<Common.Entities.ExpiredProcess>("lk_expiredprocess_activestageid", null, value);
				this.OnPropertyChanged("lk_expiredprocess_activestageid");
			}
		}
		
		/// <summary>
		/// 1:N lk_leadtoopportunitysalesprocess_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadtoopportunitysalesprocess_activestageid")]
		public System.Collections.Generic.IEnumerable<Common.Entities.LeadToOpportunitySalesProcess> lk_leadtoopportunitysalesprocess_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.LeadToOpportunitySalesProcess>("lk_leadtoopportunitysalesprocess_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_leadtoopportunitysalesprocess_activestageid");
				this.SetRelatedEntities<Common.Entities.LeadToOpportunitySalesProcess>("lk_leadtoopportunitysalesprocess_activestageid", null, value);
				this.OnPropertyChanged("lk_leadtoopportunitysalesprocess_activestageid");
			}
		}
		
		/// <summary>
		/// 1:N lk_newprocess_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_newprocess_activestageid")]
		public System.Collections.Generic.IEnumerable<Common.Entities.NewProcess> lk_newprocess_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.NewProcess>("lk_newprocess_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_newprocess_activestageid");
				this.SetRelatedEntities<Common.Entities.NewProcess>("lk_newprocess_activestageid", null, value);
				this.OnPropertyChanged("lk_newprocess_activestageid");
			}
		}
		
		/// <summary>
		/// 1:N lk_opportunitysalesprocess_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitysalesprocess_activestageid")]
		public System.Collections.Generic.IEnumerable<Common.Entities.OpportunitySalesProcess> lk_opportunitysalesprocess_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.OpportunitySalesProcess>("lk_opportunitysalesprocess_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_opportunitysalesprocess_activestageid");
				this.SetRelatedEntities<Common.Entities.OpportunitySalesProcess>("lk_opportunitysalesprocess_activestageid", null, value);
				this.OnPropertyChanged("lk_opportunitysalesprocess_activestageid");
			}
		}
		
		/// <summary>
		/// 1:N lk_phonetocaseprocess_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonetocaseprocess_activestageid")]
		public System.Collections.Generic.IEnumerable<Common.Entities.PhoneToCaseProcess> lk_phonetocaseprocess_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.PhoneToCaseProcess>("lk_phonetocaseprocess_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_phonetocaseprocess_activestageid");
				this.SetRelatedEntities<Common.Entities.PhoneToCaseProcess>("lk_phonetocaseprocess_activestageid", null, value);
				this.OnPropertyChanged("lk_phonetocaseprocess_activestageid");
			}
		}
		
		/// <summary>
		/// 1:N lk_translationprocess_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_translationprocess_activestageid")]
		public System.Collections.Generic.IEnumerable<Common.Entities.TranslationProcess> lk_translationprocess_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.TranslationProcess>("lk_translationprocess_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_translationprocess_activestageid");
				this.SetRelatedEntities<Common.Entities.TranslationProcess>("lk_translationprocess_activestageid", null, value);
				this.OnPropertyChanged("lk_translationprocess_activestageid");
			}
		}
		
		/// <summary>
		/// 1:N processstage_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_account")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Account> processstage_account
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Account>("processstage_account", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_account");
				this.SetRelatedEntities<Common.Entities.Account>("processstage_account", null, value);
				this.OnPropertyChanged("processstage_account");
			}
		}
		
		/// <summary>
		/// 1:N processstage_appointments
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_appointments")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Appointment> processstage_appointments
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Appointment>("processstage_appointments", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_appointments");
				this.SetRelatedEntities<Common.Entities.Appointment>("processstage_appointments", null, value);
				this.OnPropertyChanged("processstage_appointments");
			}
		}
		
		/// <summary>
		/// 1:N processstage_BookableResource
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_BookableResource")]
		public System.Collections.Generic.IEnumerable<Common.Entities.BookableResource> processstage_BookableResource
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.BookableResource>("processstage_BookableResource", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_BookableResource");
				this.SetRelatedEntities<Common.Entities.BookableResource>("processstage_BookableResource", null, value);
				this.OnPropertyChanged("processstage_BookableResource");
			}
		}
		
		/// <summary>
		/// 1:N processstage_BookableResourceBooking
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_BookableResourceBooking")]
		public System.Collections.Generic.IEnumerable<Common.Entities.BookableResourceBooking> processstage_BookableResourceBooking
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.BookableResourceBooking>("processstage_BookableResourceBooking", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_BookableResourceBooking");
				this.SetRelatedEntities<Common.Entities.BookableResourceBooking>("processstage_BookableResourceBooking", null, value);
				this.OnPropertyChanged("processstage_BookableResourceBooking");
			}
		}
		
		/// <summary>
		/// 1:N processstage_BookableResourceBookingHeader
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_BookableResourceBookingHeader")]
		public System.Collections.Generic.IEnumerable<Common.Entities.BookableResourceBookingHeader> processstage_BookableResourceBookingHeader
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.BookableResourceBookingHeader>("processstage_BookableResourceBookingHeader", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_BookableResourceBookingHeader");
				this.SetRelatedEntities<Common.Entities.BookableResourceBookingHeader>("processstage_BookableResourceBookingHeader", null, value);
				this.OnPropertyChanged("processstage_BookableResourceBookingHeader");
			}
		}
		
		/// <summary>
		/// 1:N processstage_BookableResourceCharacteristic
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_BookableResourceCharacteristic")]
		public System.Collections.Generic.IEnumerable<Common.Entities.BookableResourceCharacteristic> processstage_BookableResourceCharacteristic
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.BookableResourceCharacteristic>("processstage_BookableResourceCharacteristic", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_BookableResourceCharacteristic");
				this.SetRelatedEntities<Common.Entities.BookableResourceCharacteristic>("processstage_BookableResourceCharacteristic", null, value);
				this.OnPropertyChanged("processstage_BookableResourceCharacteristic");
			}
		}
		
		/// <summary>
		/// 1:N processstage_campaignactivities
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_campaignactivities")]
		public System.Collections.Generic.IEnumerable<Common.Entities.CampaignActivity> processstage_campaignactivities
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.CampaignActivity>("processstage_campaignactivities", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_campaignactivities");
				this.SetRelatedEntities<Common.Entities.CampaignActivity>("processstage_campaignactivities", null, value);
				this.OnPropertyChanged("processstage_campaignactivities");
			}
		}
		
		/// <summary>
		/// 1:N processstage_campaignresponses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_campaignresponses")]
		public System.Collections.Generic.IEnumerable<Common.Entities.CampaignResponse> processstage_campaignresponses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.CampaignResponse>("processstage_campaignresponses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_campaignresponses");
				this.SetRelatedEntities<Common.Entities.CampaignResponse>("processstage_campaignresponses", null, value);
				this.OnPropertyChanged("processstage_campaignresponses");
			}
		}
		
		/// <summary>
		/// 1:N processstage_campaigns
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_campaigns")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Campaign> processstage_campaigns
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Campaign>("processstage_campaigns", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_campaigns");
				this.SetRelatedEntities<Common.Entities.Campaign>("processstage_campaigns", null, value);
				this.OnPropertyChanged("processstage_campaigns");
			}
		}
		
		/// <summary>
		/// 1:N processstage_competitors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_competitors")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Competitor> processstage_competitors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Competitor>("processstage_competitors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_competitors");
				this.SetRelatedEntities<Common.Entities.Competitor>("processstage_competitors", null, value);
				this.OnPropertyChanged("processstage_competitors");
			}
		}
		
		/// <summary>
		/// 1:N processstage_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_contact")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Contact> processstage_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Contact>("processstage_contact", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_contact");
				this.SetRelatedEntities<Common.Entities.Contact>("processstage_contact", null, value);
				this.OnPropertyChanged("processstage_contact");
			}
		}
		
		/// <summary>
		/// 1:N processstage_emails
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_emails")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Email> processstage_emails
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Email>("processstage_emails", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_emails");
				this.SetRelatedEntities<Common.Entities.Email>("processstage_emails", null, value);
				this.OnPropertyChanged("processstage_emails");
			}
		}
		
		/// <summary>
		/// 1:N processstage_Entitlement
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_Entitlement")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Entitlement> processstage_Entitlement
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Entitlement>("processstage_Entitlement", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_Entitlement");
				this.SetRelatedEntities<Common.Entities.Entitlement>("processstage_Entitlement", null, value);
				this.OnPropertyChanged("processstage_Entitlement");
			}
		}
		
		/// <summary>
		/// 1:N processstage_faxes
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_faxes")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Fax> processstage_faxes
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Fax>("processstage_faxes", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_faxes");
				this.SetRelatedEntities<Common.Entities.Fax>("processstage_faxes", null, value);
				this.OnPropertyChanged("processstage_faxes");
			}
		}
		
		/// <summary>
		/// 1:N processstage_incident
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_incident")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Incident> processstage_incident
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Incident>("processstage_incident", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_incident");
				this.SetRelatedEntities<Common.Entities.Incident>("processstage_incident", null, value);
				this.OnPropertyChanged("processstage_incident");
			}
		}
		
		/// <summary>
		/// 1:N processstage_invoices
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_invoices")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Invoice> processstage_invoices
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Invoice>("processstage_invoices", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_invoices");
				this.SetRelatedEntities<Common.Entities.Invoice>("processstage_invoices", null, value);
				this.OnPropertyChanged("processstage_invoices");
			}
		}
		
		/// <summary>
		/// 1:N processstage_knowledgearticle
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_knowledgearticle")]
		public System.Collections.Generic.IEnumerable<Common.Entities.KnowledgeArticle> processstage_knowledgearticle
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.KnowledgeArticle>("processstage_knowledgearticle", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_knowledgearticle");
				this.SetRelatedEntities<Common.Entities.KnowledgeArticle>("processstage_knowledgearticle", null, value);
				this.OnPropertyChanged("processstage_knowledgearticle");
			}
		}
		
		/// <summary>
		/// 1:N processstage_lead
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_lead")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Lead> processstage_lead
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Lead>("processstage_lead", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_lead");
				this.SetRelatedEntities<Common.Entities.Lead>("processstage_lead", null, value);
				this.OnPropertyChanged("processstage_lead");
			}
		}
		
		/// <summary>
		/// 1:N processstage_letters
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_letters")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Letter> processstage_letters
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Letter>("processstage_letters", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_letters");
				this.SetRelatedEntities<Common.Entities.Letter>("processstage_letters", null, value);
				this.OnPropertyChanged("processstage_letters");
			}
		}
		
		/// <summary>
		/// 1:N processstage_lists
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_lists")]
		public System.Collections.Generic.IEnumerable<Common.Entities.List> processstage_lists
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.List>("processstage_lists", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_lists");
				this.SetRelatedEntities<Common.Entities.List>("processstage_lists", null, value);
				this.OnPropertyChanged("processstage_lists");
			}
		}
		
		/// <summary>
		/// 1:N processstage_opportunity
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_opportunity")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Opportunity> processstage_opportunity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Opportunity>("processstage_opportunity", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_opportunity");
				this.SetRelatedEntities<Common.Entities.Opportunity>("processstage_opportunity", null, value);
				this.OnPropertyChanged("processstage_opportunity");
			}
		}
		
		/// <summary>
		/// 1:N processstage_phonecalls
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_phonecalls")]
		public System.Collections.Generic.IEnumerable<Common.Entities.PhoneCall> processstage_phonecalls
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.PhoneCall>("processstage_phonecalls", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_phonecalls");
				this.SetRelatedEntities<Common.Entities.PhoneCall>("processstage_phonecalls", null, value);
				this.OnPropertyChanged("processstage_phonecalls");
			}
		}
		
		/// <summary>
		/// 1:N processstage_productpricelevels
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_productpricelevels")]
		public System.Collections.Generic.IEnumerable<Common.Entities.ProductPriceLevel> processstage_productpricelevels
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.ProductPriceLevel>("processstage_productpricelevels", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_productpricelevels");
				this.SetRelatedEntities<Common.Entities.ProductPriceLevel>("processstage_productpricelevels", null, value);
				this.OnPropertyChanged("processstage_productpricelevels");
			}
		}
		
		/// <summary>
		/// 1:N processstage_products
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_products")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Product> processstage_products
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Product>("processstage_products", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_products");
				this.SetRelatedEntities<Common.Entities.Product>("processstage_products", null, value);
				this.OnPropertyChanged("processstage_products");
			}
		}
		
		/// <summary>
		/// 1:N processstage_quotes
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_quotes")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Quote> processstage_quotes
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Quote>("processstage_quotes", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_quotes");
				this.SetRelatedEntities<Common.Entities.Quote>("processstage_quotes", null, value);
				this.OnPropertyChanged("processstage_quotes");
			}
		}
		
		/// <summary>
		/// 1:N processstage_recurringappointmentmasters
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_recurringappointmentmasters")]
		public System.Collections.Generic.IEnumerable<Common.Entities.RecurringAppointmentMaster> processstage_recurringappointmentmasters
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.RecurringAppointmentMaster>("processstage_recurringappointmentmasters", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_recurringappointmentmasters");
				this.SetRelatedEntities<Common.Entities.RecurringAppointmentMaster>("processstage_recurringappointmentmasters", null, value);
				this.OnPropertyChanged("processstage_recurringappointmentmasters");
			}
		}
		
		/// <summary>
		/// 1:N processstage_salesliteratures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_salesliteratures")]
		public System.Collections.Generic.IEnumerable<Common.Entities.SalesLiterature> processstage_salesliteratures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.SalesLiterature>("processstage_salesliteratures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_salesliteratures");
				this.SetRelatedEntities<Common.Entities.SalesLiterature>("processstage_salesliteratures", null, value);
				this.OnPropertyChanged("processstage_salesliteratures");
			}
		}
		
		/// <summary>
		/// 1:N processstage_salesorders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_salesorders")]
		public System.Collections.Generic.IEnumerable<Common.Entities.SalesOrder> processstage_salesorders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.SalesOrder>("processstage_salesorders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_salesorders");
				this.SetRelatedEntities<Common.Entities.SalesOrder>("processstage_salesorders", null, value);
				this.OnPropertyChanged("processstage_salesorders");
			}
		}
		
		/// <summary>
		/// 1:N ProcessStage_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProcessStage_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Common.Entities.SyncError> ProcessStage_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.SyncError>("ProcessStage_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessStage_SyncErrors");
				this.SetRelatedEntities<Common.Entities.SyncError>("ProcessStage_SyncErrors", null, value);
				this.OnPropertyChanged("ProcessStage_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N processstage_systemusers
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_systemusers")]
		public System.Collections.Generic.IEnumerable<Common.Entities.SystemUser> processstage_systemusers
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.SystemUser>("processstage_systemusers", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_systemusers");
				this.SetRelatedEntities<Common.Entities.SystemUser>("processstage_systemusers", null, value);
				this.OnPropertyChanged("processstage_systemusers");
			}
		}
		
		/// <summary>
		/// 1:N processstage_tasks
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_tasks")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Task> processstage_tasks
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Task>("processstage_tasks", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_tasks");
				this.SetRelatedEntities<Common.Entities.Task>("processstage_tasks", null, value);
				this.OnPropertyChanged("processstage_tasks");
			}
		}
		
		/// <summary>
		/// 1:N processstage_teams
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_teams")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Team> processstage_teams
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Team>("processstage_teams", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_teams");
				this.SetRelatedEntities<Common.Entities.Team>("processstage_teams", null, value);
				this.OnPropertyChanged("processstage_teams");
			}
		}
		
		/// <summary>
		/// N:1 process_processstage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("process_processstage")]
		public Common.Entities.Workflow process_processstage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Workflow>("process_processstage", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("process_processstage");
				this.SetRelatedEntity<Common.Entities.Workflow>("process_processstage", null, value);
				this.OnPropertyChanged("process_processstage");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ProcessStage(object anonymousType) : 
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
                        Attributes["processstageid"] = base.Id;
                        break;
                    case "processstageid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stagecategory")]
		public virtual Processstage_Category? StageCategoryEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Processstage_Category?)(EntityOptionSetEnum.GetEnum(this, "stagecategory")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StageCategory = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}