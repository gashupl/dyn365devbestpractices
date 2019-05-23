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
	/// Localized name of the time zone.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("timezonelocalizedname")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class TimeZoneLocalizedName : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CultureId = "cultureid";
			public const string DaylightName = "daylightname";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string StandardName = "standardname";
			public const string TimeZoneDefinitionId = "timezonedefinitionid";
			public const string TimeZoneLocalizedNameId = "timezonelocalizednameid";
			public const string Id = "timezonelocalizednameid";
			public const string UserInterfaceName = "userinterfacename";
			public const string VersionNumber = "versionnumber";
			public const string lk_timezonelocalizedname_createdby = "lk_timezonelocalizedname_createdby";
			public const string lk_timezonelocalizedname_createdonbehalfby = "lk_timezonelocalizedname_createdonbehalfby";
			public const string lk_timezonelocalizedname_modifiedby = "lk_timezonelocalizedname_modifiedby";
			public const string lk_timezonelocalizedname_modifiedonbehalfby = "lk_timezonelocalizedname_modifiedonbehalfby";
			public const string lk_timezonelocalizedname_timezonedefinitionid = "lk_timezonelocalizedname_timezonedefinitionid";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TimeZoneLocalizedName() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "timezonelocalizedname";
		
		public const string PrimaryIdAttribute = "timezonelocalizednameid";
		
		public const string PrimaryNameAttribute = "userinterfacename";
		
		public const int EntityTypeCode = 4812;
		
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
		/// Unique identifier of the delegate user who created the timezonelocalizedname.
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
		/// Unique identifier of the culture that the UI names are encoded in.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cultureid")]
		public System.Nullable<int> CultureId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("cultureid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CultureId");
				this.SetAttributeValue("cultureid", value);
				this.OnPropertyChanged("CultureId");
			}
		}
		
		/// <summary>
		/// Name of the time zone for the daylight time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daylightname")]
		public string DaylightName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("daylightname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DaylightName");
				this.SetAttributeValue("daylightname", value);
				this.OnPropertyChanged("DaylightName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the time zone localized name.
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
		/// Unique identifier of the delegate user who last modified the timezonelocalizedname.
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
		/// Unique identifier of the organization associated with the time zone localized name.
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
		/// Name of the time zone for the standard time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardname")]
		public string StandardName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("standardname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StandardName");
				this.SetAttributeValue("standardname", value);
				this.OnPropertyChanged("StandardName");
			}
		}
		
		/// <summary>
		/// Unique identifier of time zone definition entity instances.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedefinitionid")]
		public Microsoft.Xrm.Sdk.EntityReference TimeZoneDefinitionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("timezonedefinitionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneDefinitionId");
				this.SetAttributeValue("timezonedefinitionid", value);
				this.OnPropertyChanged("TimeZoneDefinitionId");
			}
		}
		
		/// <summary>
		/// Unique identifier of entity instances.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonelocalizednameid")]
		public System.Nullable<System.Guid> TimeZoneLocalizedNameId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("timezonelocalizednameid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneLocalizedNameId");
				this.SetAttributeValue("timezonelocalizednameid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("TimeZoneLocalizedNameId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonelocalizednameid")]
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
				this.TimeZoneLocalizedNameId = value;
			}
		}
		
		/// <summary>
		/// Unique display name for the time zone in the Microsoft Windows registry.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userinterfacename")]
		public string UserInterfaceName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("userinterfacename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UserInterfaceName");
				this.SetAttributeValue("userinterfacename", value);
				this.OnPropertyChanged("UserInterfaceName");
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
		/// 1:N userentityinstancedata_timezonelocalizedname
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_timezonelocalizedname")]
		public System.Collections.Generic.IEnumerable<Common.Entities.UserEntityInstanceData> userentityinstancedata_timezonelocalizedname
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.UserEntityInstanceData>("userentityinstancedata_timezonelocalizedname", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_timezonelocalizedname");
				this.SetRelatedEntities<Common.Entities.UserEntityInstanceData>("userentityinstancedata_timezonelocalizedname", null, value);
				this.OnPropertyChanged("userentityinstancedata_timezonelocalizedname");
			}
		}
		
		/// <summary>
		/// N:1 lk_timezonelocalizedname_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_createdby")]
		public Common.Entities.SystemUser lk_timezonelocalizedname_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_timezonelocalizedname_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_timezonelocalizedname_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_createdonbehalfby")]
		public Common.Entities.SystemUser lk_timezonelocalizedname_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_timezonelocalizedname_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_timezonelocalizedname_createdonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_timezonelocalizedname_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_timezonelocalizedname_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_timezonelocalizedname_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_modifiedby")]
		public Common.Entities.SystemUser lk_timezonelocalizedname_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_timezonelocalizedname_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_timezonelocalizedname_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_modifiedonbehalfby")]
		public Common.Entities.SystemUser lk_timezonelocalizedname_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_timezonelocalizedname_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_timezonelocalizedname_modifiedonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_timezonelocalizedname_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_timezonelocalizedname_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_timezonelocalizedname_timezonedefinitionid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedefinitionid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_timezonedefinitionid")]
		public Common.Entities.TimeZoneDefinition lk_timezonelocalizedname_timezonedefinitionid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.TimeZoneDefinition>("lk_timezonelocalizedname_timezonedefinitionid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_timezonelocalizedname_timezonedefinitionid");
				this.SetRelatedEntity<Common.Entities.TimeZoneDefinition>("lk_timezonelocalizedname_timezonedefinitionid", null, value);
				this.OnPropertyChanged("lk_timezonelocalizedname_timezonedefinitionid");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TimeZoneLocalizedName(object anonymousType) : 
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
                        Attributes["timezonelocalizednameid"] = base.Id;
                        break;
                    case "timezonelocalizednameid":
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