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
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("opportunitycompetitors")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class OpportunityCompetitors : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CompetitorId = "competitorid";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string Name = "name";
			public const string OpportunityCompetitorId = "opportunitycompetitorid";
			public const string Id = "opportunitycompetitorid";
			public const string OpportunityId = "opportunityid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public OpportunityCompetitors() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "opportunitycompetitors";
		
		public const string PrimaryIdAttribute = "opportunitycompetitorid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 25;
		
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
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("competitorid")]
		public System.Nullable<System.Guid> CompetitorId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("competitorid");
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
		/// Unique identifier of the opportunity competitor.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunitycompetitorid")]
		public System.Nullable<System.Guid> OpportunityCompetitorId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("opportunitycompetitorid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OpportunityCompetitorId");
				this.SetAttributeValue("opportunitycompetitorid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("OpportunityCompetitorId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunitycompetitorid")]
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
				this.OpportunityCompetitorId = value;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
		public System.Nullable<System.Guid> OpportunityId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("opportunityid");
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
		/// 1:N opportunitycompetitors_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitycompetitors_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Common.Entities.AsyncOperation> opportunitycompetitors_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.AsyncOperation>("opportunitycompetitors_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunitycompetitors_AsyncOperations");
				this.SetRelatedEntities<Common.Entities.AsyncOperation>("opportunitycompetitors_AsyncOperations", null, value);
				this.OnPropertyChanged("opportunitycompetitors_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N opportunitycompetitors_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitycompetitors_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Common.Entities.BulkDeleteFailure> opportunitycompetitors_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.BulkDeleteFailure>("opportunitycompetitors_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunitycompetitors_BulkDeleteFailures");
				this.SetRelatedEntities<Common.Entities.BulkDeleteFailure>("opportunitycompetitors_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("opportunitycompetitors_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N opportunitycompetitors_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitycompetitors_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<Common.Entities.MailboxTrackingFolder> opportunitycompetitors_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.MailboxTrackingFolder>("opportunitycompetitors_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunitycompetitors_MailboxTrackingFolders");
				this.SetRelatedEntities<Common.Entities.MailboxTrackingFolder>("opportunitycompetitors_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("opportunitycompetitors_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N opportunitycompetitors_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitycompetitors_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<Common.Entities.PrincipalObjectAttributeAccess> opportunitycompetitors_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.PrincipalObjectAttributeAccess>("opportunitycompetitors_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunitycompetitors_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<Common.Entities.PrincipalObjectAttributeAccess>("opportunitycompetitors_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("opportunitycompetitors_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N opportunitycompetitors_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitycompetitors_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<Common.Entities.UserEntityInstanceData> opportunitycompetitors_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.UserEntityInstanceData>("opportunitycompetitors_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunitycompetitors_UserEntityInstanceDatas");
				this.SetRelatedEntities<Common.Entities.UserEntityInstanceData>("opportunitycompetitors_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("opportunitycompetitors_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:N opportunitycompetitors_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitycompetitors_association")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Opportunity> opportunitycompetitors_association
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Opportunity>("opportunitycompetitors_association", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunitycompetitors_association");
				this.SetRelatedEntities<Common.Entities.Opportunity>("opportunitycompetitors_association", null, value);
				this.OnPropertyChanged("opportunitycompetitors_association");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public OpportunityCompetitors(object anonymousType) : 
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
                        Attributes["opportunitycompetitorid"] = base.Id;
                        break;
                    case "opportunitycompetitorid":
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
	}
}