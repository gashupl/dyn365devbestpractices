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
	/// The mapping used to keep track of the IDs for items synced between CRM BookableResourceBooking and Exchange.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("bookableresourcebookingexchangesyncidmapping")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class BookableResourceBookingExchangeSyncIdMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string BookableResourceBookingExchangeSyncIdMappingId = "bookableresourcebookingexchangesyncidmappingid";
			public const string Id = "bookableresourcebookingexchangesyncidmappingid";
			public const string BookableResourceBookingId = "bookableresourcebookingid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ExchangeEntryId = "exchangeentryid";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsDeletedInExchange = "isdeletedinexchange";
			public const string LastSyncError = "lastsyncerror";
			public const string LastSyncErrorCode = "lastsyncerrorcode";
			public const string LastSyncErrorOccurredOn = "lastsyncerroroccurredon";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string Retries = "retries";
			public const string SyncStatus = "syncstatus";
			public const string SyncVersionNumber = "syncversionnumber";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UserId = "userid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_bookableresourcebookingexchangesyncidmapping = "business_unit_bookableresourcebookingexchangesyncidmapping";
			public const string lk_bookableresourcebookingexchangesyncidmapping_createdby = "lk_bookableresourcebookingexchangesyncidmapping_createdby";
			public const string lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby = "lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby";
			public const string lk_bookableresourcebookingexchangesyncidmapping_modifiedby = "lk_bookableresourcebookingexchangesyncidmapping_modifiedby";
			public const string lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby = "lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby";
			public const string team_bookableresourcebookingexchangesyncidmapping = "team_bookableresourcebookingexchangesyncidmapping";
			public const string user_bookableresourcebookingexchangesyncidmapping = "user_bookableresourcebookingexchangesyncidmapping";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public BookableResourceBookingExchangeSyncIdMapping() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "bookableresourcebookingexchangesyncidmapping";
		
		public const string PrimaryIdAttribute = "bookableresourcebookingexchangesyncidmappingid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 4421;
		
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bookableresourcebookingexchangesyncidmappingid")]
		public System.Nullable<System.Guid> BookableResourceBookingExchangeSyncIdMappingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("bookableresourcebookingexchangesyncidmappingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BookableResourceBookingExchangeSyncIdMappingId");
				this.SetAttributeValue("bookableresourcebookingexchangesyncidmappingid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("BookableResourceBookingExchangeSyncIdMappingId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bookableresourcebookingexchangesyncidmappingid")]
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
				this.BookableResourceBookingExchangeSyncIdMappingId = value;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bookableresourcebookingid")]
		public System.Nullable<System.Guid> BookableResourceBookingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("bookableresourcebookingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BookableResourceBookingId");
				this.SetAttributeValue("bookableresourcebookingid", value);
				this.OnPropertyChanged("BookableResourceBookingId");
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangeentryid")]
		public string ExchangeEntryId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("exchangeentryid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ExchangeEntryId");
				this.SetAttributeValue("exchangeentryid", value);
				this.OnPropertyChanged("ExchangeEntryId");
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdeletedinexchange")]
		public System.Nullable<bool> IsDeletedInExchange
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdeletedinexchange");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsDeletedInExchange");
				this.SetAttributeValue("isdeletedinexchange", value);
				this.OnPropertyChanged("IsDeletedInExchange");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncerror")]
		public string LastSyncError
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lastsyncerror");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastSyncError");
				this.SetAttributeValue("lastsyncerror", value);
				this.OnPropertyChanged("LastSyncError");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncerrorcode")]
		public System.Nullable<int> LastSyncErrorCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("lastsyncerrorcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastSyncErrorCode");
				this.SetAttributeValue("lastsyncerrorcode", value);
				this.OnPropertyChanged("LastSyncErrorCode");
			}
		}
		
		/// <summary>
		/// Last Sync Error Time
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncerroroccurredon")]
		public System.Nullable<System.DateTime> LastSyncErrorOccurredOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastsyncerroroccurredon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastSyncErrorOccurredOn");
				this.SetAttributeValue("lastsyncerroroccurredon", value);
				this.OnPropertyChanged("LastSyncErrorOccurredOn");
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
		/// name
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
		/// Owner Id
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("retries")]
		public System.Nullable<int> Retries
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("retries");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Retries");
				this.SetAttributeValue("retries", value);
				this.OnPropertyChanged("Retries");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncstatus")]
		public Microsoft.Xrm.Sdk.OptionSetValue SyncStatus
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("syncstatus");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SyncStatus");
				this.SetAttributeValue("syncstatus", value);
				this.OnPropertyChanged("SyncStatus");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncversionnumber")]
		public System.Nullable<long> SyncVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("syncversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SyncVersionNumber");
				this.SetAttributeValue("syncversionnumber", value);
				this.OnPropertyChanged("SyncVersionNumber");
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userid")]
		public Microsoft.Xrm.Sdk.EntityReference UserId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("userid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UserId");
				this.SetAttributeValue("userid", value);
				this.OnPropertyChanged("UserId");
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
		/// 1:N bookableresourcebookingexchangesyncidmapping_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("bookableresourcebookingexchangesyncidmapping_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Common.Entities.AsyncOperation> bookableresourcebookingexchangesyncidmapping_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.AsyncOperation>("bookableresourcebookingexchangesyncidmapping_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bookableresourcebookingexchangesyncidmapping_AsyncOperations");
				this.SetRelatedEntities<Common.Entities.AsyncOperation>("bookableresourcebookingexchangesyncidmapping_AsyncOperations", null, value);
				this.OnPropertyChanged("bookableresourcebookingexchangesyncidmapping_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Common.Entities.BulkDeleteFailure> bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.BulkDeleteFailure>("bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures");
				this.SetRelatedEntities<Common.Entities.BulkDeleteFailure>("bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<Common.Entities.MailboxTrackingFolder> bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.MailboxTrackingFolder>("bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders");
				this.SetRelatedEntities<Common.Entities.MailboxTrackingFolder>("bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<Common.Entities.PrincipalObjectAttributeAccess> bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.PrincipalObjectAttributeAccess>("bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<Common.Entities.PrincipalObjectAttributeAccess>("bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N bookableresourcebookingexchangesyncidmapping_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("bookableresourcebookingexchangesyncidmapping_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Common.Entities.SyncError> bookableresourcebookingexchangesyncidmapping_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.SyncError>("bookableresourcebookingexchangesyncidmapping_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bookableresourcebookingexchangesyncidmapping_SyncErrors");
				this.SetRelatedEntities<Common.Entities.SyncError>("bookableresourcebookingexchangesyncidmapping_SyncErrors", null, value);
				this.OnPropertyChanged("bookableresourcebookingexchangesyncidmapping_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<Common.Entities.UserEntityInstanceData> bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.UserEntityInstanceData>("bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas");
				this.SetRelatedEntities<Common.Entities.UserEntityInstanceData>("bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_bookableresourcebookingexchangesyncidmapping
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_bookableresourcebookingexchangesyncidmapping")]
		public Common.Entities.BusinessUnit business_unit_bookableresourcebookingexchangesyncidmapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.BusinessUnit>("business_unit_bookableresourcebookingexchangesyncidmapping", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_bookableresourcebookingexchangesyncidmapping_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bookableresourcebookingexchangesyncidmapping_createdby")]
		public Common.Entities.SystemUser lk_bookableresourcebookingexchangesyncidmapping_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_bookableresourcebookingexchangesyncidmapping_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby")]
		public Common.Entities.SystemUser lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_bookableresourcebookingexchangesyncidmapping_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bookableresourcebookingexchangesyncidmapping_modifiedby")]
		public Common.Entities.SystemUser lk_bookableresourcebookingexchangesyncidmapping_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_bookableresourcebookingexchangesyncidmapping_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby")]
		public Common.Entities.SystemUser lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 team_bookableresourcebookingexchangesyncidmapping
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_bookableresourcebookingexchangesyncidmapping")]
		public Common.Entities.Team team_bookableresourcebookingexchangesyncidmapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Team>("team_bookableresourcebookingexchangesyncidmapping", null);
			}
		}
		
		/// <summary>
		/// N:1 user_bookableresourcebookingexchangesyncidmapping
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_bookableresourcebookingexchangesyncidmapping")]
		public Common.Entities.SystemUser user_bookableresourcebookingexchangesyncidmapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("user_bookableresourcebookingexchangesyncidmapping", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public BookableResourceBookingExchangeSyncIdMapping(object anonymousType) : 
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
                        Attributes["bookableresourcebookingexchangesyncidmappingid"] = base.Id;
                        break;
                    case "bookableresourcebookingexchangesyncidmappingid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncstatus")]
		public virtual BookableResourceBookingExchangeSyncIdMapping_SyncStatus? SyncStatusEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((BookableResourceBookingExchangeSyncIdMapping_SyncStatus?)(EntityOptionSetEnum.GetEnum(this, "syncstatus")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				SyncStatus = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}