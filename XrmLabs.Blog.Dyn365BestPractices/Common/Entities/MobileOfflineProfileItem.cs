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
	/// Information on entity availability to mobile devices in offline mode for a mobile offline profile item.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("mobileofflineprofileitem")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class MobileOfflineProfileItem : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CanBeFollowed = "canbefollowed";
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string EntityObjectTypeCode = "entityobjecttypecode";
			public const string GetRelatedEntityRecords = "getrelatedentityrecords";
			public const string IntroducedVersion = "introducedversion";
			public const string IsManaged = "ismanaged";
			public const string IsValidated = "isvalidated";
			public const string IsVisibleInGrid = "isvisibleingrid";
			public const string MobileOfflineProfileItemId = "mobileofflineprofileitemid";
			public const string Id = "mobileofflineprofileitemid";
			public const string MobileOfflineProfileItemIdUnique = "mobileofflineprofileitemidunique";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string ProcessId = "processid";
			public const string ProfileItemEntityFilter = "profileitementityfilter";
			public const string ProfileItemRule = "profileitemrule";
			public const string PublishedOn = "publishedon";
			public const string RecordDistributionCriteria = "recorddistributioncriteria";
			public const string RecordsOwnedByMe = "recordsownedbyme";
			public const string RecordsOwnedByMyBusinessUnit = "recordsownedbymybusinessunit";
			public const string RecordsOwnedByMyTeam = "recordsownedbymyteam";
			public const string RegardingObjectId = "regardingobjectid";
			public const string RelationshipData = "relationshipdata";
			public const string SelectedEntityMetadata = "selectedentitymetadata";
			public const string SelectedEntityTypeCode = "selectedentitytypecode";
			public const string SolutionId = "solutionid";
			public const string StageId = "stageid";
			public const string TraversedPath = "traversedpath";
			public const string VersionNumber = "versionnumber";
			public const string ViewQuery = "viewquery";
			public const string lk_MobileOfflineProfileItem_createdby = "lk_MobileOfflineProfileItem_createdby";
			public const string lk_mobileofflineprofileitem_createdonbehalfby = "lk_mobileofflineprofileitem_createdonbehalfby";
			public const string lk_mobileofflineprofileitem_modifiedby = "lk_mobileofflineprofileitem_modifiedby";
			public const string lk_mobileofflineprofileitem_modifiedonbehalfby = "lk_mobileofflineprofileitem_modifiedonbehalfby";
			public const string lk_mobileofflineprofileitem_savedquery = "lk_mobileofflineprofileitem_savedquery";
			public const string MobileOfflineProfile_MobileOfflineProfileItem = "MobileOfflineProfile_MobileOfflineProfileItem";
			public const string MobileOfflineProfileItem_organization = "MobileOfflineProfileItem_organization";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public MobileOfflineProfileItem() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "mobileofflineprofileitem";
		
		public const string PrimaryIdAttribute = "mobileofflineprofileitemid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 9867;
		
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
		/// Specifies whether records of this entity can be followed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canbefollowed")]
		[System.ObsoleteAttribute()]
		public System.Nullable<bool> CanBeFollowed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("canbefollowed");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CanBeFollowed");
				this.SetAttributeValue("canbefollowed", value);
				this.OnPropertyChanged("CanBeFollowed");
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
		/// Shows who created the record.
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
		/// Shows who created the record on behalf of another user.
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
		/// Internal Use Only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityobjecttypecode")]
		public System.Nullable<int> EntityObjectTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("entityobjecttypecode");
			}
		}
		
		/// <summary>
		/// Specify whether records related to this entity will be made available for offline access.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("getrelatedentityrecords")]
		[System.ObsoleteAttribute()]
		public System.Nullable<bool> GetRelatedEntityRecords
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("getrelatedentityrecords");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GetRelatedEntityRecords");
				this.SetAttributeValue("getrelatedentityrecords", value);
				this.OnPropertyChanged("GetRelatedEntityRecords");
			}
		}
		
		/// <summary>
		/// Version in which the Mobile offline Profile Item is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IntroducedVersion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// For internal use only.
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
		/// Information about whether profile item is validated or not
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvalidated")]
		public System.Nullable<bool> IsValidated
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isvalidated");
			}
		}
		
		/// <summary>
		/// Information about whether the mobile offline profile item is visible in the Profile Item subgrid.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvisibleingrid")]
		public System.Nullable<bool> IsVisibleInGrid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isvisibleingrid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsVisibleInGrid");
				this.SetAttributeValue("isvisibleingrid", value);
				this.OnPropertyChanged("IsVisibleInGrid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the mobile offline profile item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileofflineprofileitemid")]
		public System.Nullable<System.Guid> MobileOfflineProfileItemId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("mobileofflineprofileitemid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MobileOfflineProfileItemId");
				this.SetAttributeValue("mobileofflineprofileitemid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("MobileOfflineProfileItemId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileofflineprofileitemid")]
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
				this.MobileOfflineProfileItemId = value;
			}
		}
		
		/// <summary>
		/// For Internal Use Only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileofflineprofileitemidunique")]
		public System.Nullable<System.Guid> MobileOfflineProfileItemIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("mobileofflineprofileitemidunique");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
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
		/// Shows who updated the record on behalf of another user.
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
		/// Enter the name of the mobile offline profile item.
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
		/// Unique identifier of the organization associated with the Mobile Offline Profile Item.
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
		/// For internal use only.
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
		/// Shows the ID of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
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
		/// Profile item entity filter criteria
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("profileitementityfilter")]
		public string ProfileItemEntityFilter
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("profileitementityfilter");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProfileItemEntityFilter");
				this.SetAttributeValue("profileitementityfilter", value);
				this.OnPropertyChanged("ProfileItemEntityFilter");
			}
		}
		
		/// <summary>
		/// Saved Query associated with the Mobile offline profile item rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("profileitemrule")]
		[System.ObsoleteAttribute()]
		public Microsoft.Xrm.Sdk.EntityReference ProfileItemRule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("profileitemrule");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProfileItemRule");
				this.SetAttributeValue("profileitemrule", value);
				this.OnPropertyChanged("ProfileItemRule");
			}
		}
		
		/// <summary>
		/// Displays the last published date time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publishedon")]
		public System.Nullable<System.DateTime> PublishedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("publishedon");
			}
		}
		
		/// <summary>
		/// Specify data download filter for selected entity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recorddistributioncriteria")]
		public Microsoft.Xrm.Sdk.OptionSetValue RecordDistributionCriteria
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("recorddistributioncriteria");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RecordDistributionCriteria");
				this.SetAttributeValue("recorddistributioncriteria", value);
				this.OnPropertyChanged("RecordDistributionCriteria");
			}
		}
		
		/// <summary>
		/// Download my records
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recordsownedbyme")]
		public System.Nullable<bool> RecordsOwnedByMe
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("recordsownedbyme");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RecordsOwnedByMe");
				this.SetAttributeValue("recordsownedbyme", value);
				this.OnPropertyChanged("RecordsOwnedByMe");
			}
		}
		
		/// <summary>
		/// Download my business unit's records
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recordsownedbymybusinessunit")]
		public System.Nullable<bool> RecordsOwnedByMyBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("recordsownedbymybusinessunit");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RecordsOwnedByMyBusinessUnit");
				this.SetAttributeValue("recordsownedbymybusinessunit", value);
				this.OnPropertyChanged("RecordsOwnedByMyBusinessUnit");
			}
		}
		
		/// <summary>
		/// Download my team's records
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recordsownedbymyteam")]
		public System.Nullable<bool> RecordsOwnedByMyTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("recordsownedbymyteam");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RecordsOwnedByMyTeam");
				this.SetAttributeValue("recordsownedbymyteam", value);
				this.OnPropertyChanged("RecordsOwnedByMyTeam");
			}
		}
		
		/// <summary>
		/// Items contained with a particular Profile.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RegardingObjectId");
				this.SetAttributeValue("regardingobjectid", value);
				this.OnPropertyChanged("RegardingObjectId");
			}
		}
		
		/// <summary>
		/// Internal Use Only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshipdata")]
		public string RelationshipData
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("relationshipdata");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RelationshipData");
				this.SetAttributeValue("relationshipdata", value);
				this.OnPropertyChanged("RelationshipData");
			}
		}
		
		/// <summary>
		/// Internal Use Only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("selectedentitymetadata")]
		public string SelectedEntityMetadata
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("selectedentitymetadata");
			}
		}
		
		/// <summary>
		/// Mobile offline enabled entity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("selectedentitytypecode")]
		public string SelectedEntityTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("selectedentitytypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SelectedEntityTypeCode");
				this.SetAttributeValue("selectedentitytypecode", value);
				this.OnPropertyChanged("SelectedEntityTypeCode");
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
		/// Shows the ID of the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
		
		/// <summary>
		/// For internal use only.
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
		/// Version number of the Mobile Offline Profile Item.
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
		/// Contains converted sql of the referenced view.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("viewquery")]
		[System.ObsoleteAttribute()]
		public string ViewQuery
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("viewquery");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ViewQuery");
				this.SetAttributeValue("viewquery", value);
				this.OnPropertyChanged("ViewQuery");
			}
		}
		
		/// <summary>
		/// 1:N MobileOfflineProfileItem_MobileOfflineProfileItemAssociation
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation")]
		public System.Collections.Generic.IEnumerable<Common.Entities.MobileOfflineProfileItemAssociation> MobileOfflineProfileItem_MobileOfflineProfileItemAssociation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.MobileOfflineProfileItemAssociation>("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation");
				this.SetRelatedEntities<Common.Entities.MobileOfflineProfileItemAssociation>("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation", null, value);
				this.OnPropertyChanged("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation");
			}
		}
		
		/// <summary>
		/// N:1 lk_MobileOfflineProfileItem_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_MobileOfflineProfileItem_createdby")]
		public Common.Entities.SystemUser lk_MobileOfflineProfileItem_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_MobileOfflineProfileItem_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_mobileofflineprofileitem_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mobileofflineprofileitem_createdonbehalfby")]
		public Common.Entities.SystemUser lk_mobileofflineprofileitem_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_mobileofflineprofileitem_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_mobileofflineprofileitem_createdonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_mobileofflineprofileitem_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_mobileofflineprofileitem_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_mobileofflineprofileitem_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mobileofflineprofileitem_modifiedby")]
		public Common.Entities.SystemUser lk_mobileofflineprofileitem_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_mobileofflineprofileitem_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_mobileofflineprofileitem_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mobileofflineprofileitem_modifiedonbehalfby")]
		public Common.Entities.SystemUser lk_mobileofflineprofileitem_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_mobileofflineprofileitem_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_mobileofflineprofileitem_modifiedonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_mobileofflineprofileitem_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_mobileofflineprofileitem_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_mobileofflineprofileitem_savedquery
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("profileitemrule")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mobileofflineprofileitem_savedquery")]
		public Common.Entities.SavedQuery lk_mobileofflineprofileitem_savedquery
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SavedQuery>("lk_mobileofflineprofileitem_savedquery", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_mobileofflineprofileitem_savedquery");
				this.SetRelatedEntity<Common.Entities.SavedQuery>("lk_mobileofflineprofileitem_savedquery", null, value);
				this.OnPropertyChanged("lk_mobileofflineprofileitem_savedquery");
			}
		}
		
		/// <summary>
		/// N:1 MobileOfflineProfile_MobileOfflineProfileItem
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MobileOfflineProfile_MobileOfflineProfileItem")]
		public Common.Entities.MobileOfflineProfile MobileOfflineProfile_MobileOfflineProfileItem
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.MobileOfflineProfile>("MobileOfflineProfile_MobileOfflineProfileItem", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MobileOfflineProfile_MobileOfflineProfileItem");
				this.SetRelatedEntity<Common.Entities.MobileOfflineProfile>("MobileOfflineProfile_MobileOfflineProfileItem", null, value);
				this.OnPropertyChanged("MobileOfflineProfile_MobileOfflineProfileItem");
			}
		}
		
		/// <summary>
		/// N:1 MobileOfflineProfileItem_organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MobileOfflineProfileItem_organization")]
		public Common.Entities.Organization MobileOfflineProfileItem_organization
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Organization>("MobileOfflineProfileItem_organization", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public MobileOfflineProfileItem(object anonymousType) : 
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
                        Attributes["mobileofflineprofileitemid"] = base.Id;
                        break;
                    case "mobileofflineprofileitemid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recorddistributioncriteria")]
		public virtual MobileOfflineProfileItem_RecordDistributionCriteria? RecordDistributionCriteriaEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((MobileOfflineProfileItem_RecordDistributionCriteria?)(EntityOptionSetEnum.GetEnum(this, "recorddistributioncriteria")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				RecordDistributionCriteria = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}