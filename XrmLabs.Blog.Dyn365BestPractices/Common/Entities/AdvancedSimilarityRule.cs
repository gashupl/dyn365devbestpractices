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
	public enum AdvancedSimilarityRuleState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// A text match rule identifies similar records using keywords and key phrases determined with text analytics
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("advancedsimilarityrule")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class AdvancedSimilarityRule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AdvancedSimilarityRuleId = "advancedsimilarityruleid";
			public const string Id = "advancedsimilarityruleid";
			public const string AdvancedSimilarityRuleIdUnique = "advancedsimilarityruleidunique";
			public const string AzureServiceConnectionId = "azureserviceconnectionid";
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string Entity = "entity";
			public const string ExactMatchList = "exactmatchlist";
			public const string FetchXmlList = "fetchxmllist";
			public const string FilterResultByStatus = "filterresultbystatus";
			public const string FilterResultByStatusDisplayName = "filterresultbystatusdisplayname";
			public const string IsAzureMLRequired = "isazuremlrequired";
			public const string IsManaged = "ismanaged";
			public const string MaxNumberKeyphrases = "maxnumberkeyphrases";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string name = "name";
			public const string NgramSize = "ngramsize";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string SolutionId = "solutionid";
			public const string SourceEntity = "sourceentity";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string azureserviceconnection_advancedsimilarityrule = "azureserviceconnection_advancedsimilarityrule";
			public const string lk_advancedsimilarityrule_createdby = "lk_advancedsimilarityrule_createdby";
			public const string lk_advancedsimilarityrule_createdonbehalfby = "lk_advancedsimilarityrule_createdonbehalfby";
			public const string lk_advancedsimilarityrule_modifiedby = "lk_advancedsimilarityrule_modifiedby";
			public const string lk_advancedsimilarityrule_modifiedonbehalfby = "lk_advancedsimilarityrule_modifiedonbehalfby";
			public const string organization_advancedsimilarityrule = "organization_advancedsimilarityrule";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public AdvancedSimilarityRule() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "advancedsimilarityrule";
		
		public const string PrimaryIdAttribute = "advancedsimilarityruleid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 9949;
		
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
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("advancedsimilarityruleid")]
		public System.Nullable<System.Guid> AdvancedSimilarityRuleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("advancedsimilarityruleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AdvancedSimilarityRuleId");
				this.SetAttributeValue("advancedsimilarityruleid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("AdvancedSimilarityRuleId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("advancedsimilarityruleid")]
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
				this.AdvancedSimilarityRuleId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the Advanced Similarity Rule used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("advancedsimilarityruleidunique")]
		public System.Nullable<System.Guid> AdvancedSimilarityRuleIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("advancedsimilarityruleidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier for AzureServiceConnection associated with AdvancedSimilarityRule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureserviceconnectionid")]
		public Microsoft.Xrm.Sdk.EntityReference AzureServiceConnectionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("azureserviceconnectionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AzureServiceConnectionId");
				this.SetAttributeValue("azureserviceconnectionid", value);
				this.OnPropertyChanged("AzureServiceConnectionId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the Advanced Similarity Rules.
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
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Enter a description for the Advanced Similarity Rule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// entity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entity")]
		public string Entity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entity");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Entity");
				this.SetAttributeValue("entity", value);
				this.OnPropertyChanged("Entity");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exactmatchlist")]
		public string ExactMatchList
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("exactmatchlist");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ExactMatchList");
				this.SetAttributeValue("exactmatchlist", value);
				this.OnPropertyChanged("ExactMatchList");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fetchxmllist")]
		public string FetchXmlList
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("fetchxmllist");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FetchXmlList");
				this.SetAttributeValue("fetchxmllist", value);
				this.OnPropertyChanged("FetchXmlList");
			}
		}
		
		/// <summary>
		/// Filter Result By Status
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filterresultbystatus")]
		public string FilterResultByStatus
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("filterresultbystatus");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FilterResultByStatus");
				this.SetAttributeValue("filterresultbystatus", value);
				this.OnPropertyChanged("FilterResultByStatus");
			}
		}
		
		/// <summary>
		/// Filter Result By Status
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filterresultbystatusdisplayname")]
		public string FilterResultByStatusDisplayName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("filterresultbystatusdisplayname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FilterResultByStatusDisplayName");
				this.SetAttributeValue("filterresultbystatusdisplayname", value);
				this.OnPropertyChanged("FilterResultByStatusDisplayName");
			}
		}
		
		/// <summary>
		/// Use Text Analytics for Target Match
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isazuremlrequired")]
		public System.Nullable<bool> IsAzureMLRequired
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isazuremlrequired");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsAzureMLRequired");
				this.SetAttributeValue("isazuremlrequired", value);
				this.OnPropertyChanged("IsAzureMLRequired");
			}
		}
		
		/// <summary>
		/// Is Manageed
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Enter the maximum number of keywords and key phrases to use with text analytics.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxnumberkeyphrases")]
		public System.Nullable<int> MaxNumberKeyphrases
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("maxnumberkeyphrases");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MaxNumberKeyphrases");
				this.SetAttributeValue("maxnumberkeyphrases", value);
				this.OnPropertyChanged("MaxNumberKeyphrases");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the Advanced Similarity Rules.
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
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Unique identifier of the delegate user who last modified the advanced similarity rules.
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
		/// Type a logical name for the similarity configuration
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
		/// Enter the maximum number of words in a key phrase to use with text analytics.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ngramsize")]
		public System.Nullable<int> NgramSize
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("ngramsize");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("NgramSize");
				this.SetAttributeValue("ngramsize", value);
				this.OnPropertyChanged("NgramSize");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the advanced similarity rules
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
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Enter an entity that similar records will be suggested for
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourceentity")]
		public string SourceEntity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("sourceentity");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SourceEntity");
				this.SetAttributeValue("sourceentity", value);
				this.OnPropertyChanged("SourceEntity");
			}
		}
		
		/// <summary>
		/// Status of the advanced similarity rules
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Common.Entities.AdvancedSimilarityRuleState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Common.Entities.AdvancedSimilarityRuleState)(System.Enum.ToObject(typeof(Common.Entities.AdvancedSimilarityRuleState), optionSet.Value)));
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
		/// Reason for the status of the advanced similarity rules
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
		/// 1:N advancedsimilarityrule_textanalyticsentitymapping
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("advancedsimilarityrule_textanalyticsentitymapping")]
		public System.Collections.Generic.IEnumerable<Common.Entities.TextAnalyticsEntityMapping> advancedsimilarityrule_textanalyticsentitymapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.TextAnalyticsEntityMapping>("advancedsimilarityrule_textanalyticsentitymapping", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("advancedsimilarityrule_textanalyticsentitymapping");
				this.SetRelatedEntities<Common.Entities.TextAnalyticsEntityMapping>("advancedsimilarityrule_textanalyticsentitymapping", null, value);
				this.OnPropertyChanged("advancedsimilarityrule_textanalyticsentitymapping");
			}
		}
		
		/// <summary>
		/// N:1 azureserviceconnection_advancedsimilarityrule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureserviceconnectionid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("azureserviceconnection_advancedsimilarityrule")]
		public Common.Entities.AzureServiceConnection azureserviceconnection_advancedsimilarityrule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.AzureServiceConnection>("azureserviceconnection_advancedsimilarityrule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("azureserviceconnection_advancedsimilarityrule");
				this.SetRelatedEntity<Common.Entities.AzureServiceConnection>("azureserviceconnection_advancedsimilarityrule", null, value);
				this.OnPropertyChanged("azureserviceconnection_advancedsimilarityrule");
			}
		}
		
		/// <summary>
		/// N:1 lk_advancedsimilarityrule_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_advancedsimilarityrule_createdby")]
		public Common.Entities.SystemUser lk_advancedsimilarityrule_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_advancedsimilarityrule_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_advancedsimilarityrule_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_advancedsimilarityrule_createdonbehalfby")]
		public Common.Entities.SystemUser lk_advancedsimilarityrule_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_advancedsimilarityrule_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_advancedsimilarityrule_createdonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_advancedsimilarityrule_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_advancedsimilarityrule_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_advancedsimilarityrule_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_advancedsimilarityrule_modifiedby")]
		public Common.Entities.SystemUser lk_advancedsimilarityrule_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_advancedsimilarityrule_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_advancedsimilarityrule_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_advancedsimilarityrule_modifiedonbehalfby")]
		public Common.Entities.SystemUser lk_advancedsimilarityrule_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_advancedsimilarityrule_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_advancedsimilarityrule_modifiedonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_advancedsimilarityrule_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_advancedsimilarityrule_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_advancedsimilarityrule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_advancedsimilarityrule")]
		public Common.Entities.Organization organization_advancedsimilarityrule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Organization>("organization_advancedsimilarityrule", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public AdvancedSimilarityRule(object anonymousType) : 
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
                        Attributes["advancedsimilarityruleid"] = base.Id;
                        break;
                    case "advancedsimilarityruleid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public virtual ComponentState? ComponentStateEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ComponentState?)(EntityOptionSetEnum.GetEnum(this, "componentstate")));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual AdvancedSimilarityRule_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((AdvancedSimilarityRule_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}