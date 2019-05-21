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
	/// Stores user settings for action cards
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("actioncardusersettings")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class ActionCardUserSettings : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ActionCardUserSettingsId = "actioncardusersettingsid";
			public const string Id = "actioncardusersettingsid";
			public const string BoolCardOption = "boolcardoption";
			public const string CardType = "cardtype";
			public const string CardTypeId = "cardtypeid";
			public const string IntCardOption = "intcardoption";
			public const string IsEnabled = "isenabled";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string StringCardOption = "stringcardoption";
			public const string VersionNumber = "versionnumber";
			public const string actioncardusersettings_businessunit = "actioncardusersettings_businessunit";
			public const string actioncardusersettings_owning_user = "actioncardusersettings_owning_user";
			public const string cardtype_actioncardusersettings = "cardtype_actioncardusersettings";
			public const string team_actioncardusersettings = "team_actioncardusersettings";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ActionCardUserSettings() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "actioncardusersettings";
		
		public const string PrimaryIdAttribute = "actioncardusersettingsid";
		
		public const int EntityTypeCode = 9973;
		
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
		/// Unique identifier user entity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actioncardusersettingsid")]
		public System.Nullable<System.Guid> ActionCardUserSettingsId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("actioncardusersettingsid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActionCardUserSettingsId");
				this.SetAttributeValue("actioncardusersettingsid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ActionCardUserSettingsId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actioncardusersettingsid")]
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
				this.ActionCardUserSettingsId = value;
			}
		}
		
		/// <summary>
		/// Bolean option for a cardtype.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("boolcardoption")]
		public System.Nullable<bool> BoolCardOption
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("boolcardoption");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BoolCardOption");
				this.SetAttributeValue("boolcardoption", value);
				this.OnPropertyChanged("BoolCardOption");
			}
		}
		
		/// <summary>
		/// The CardType ENUM value.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cardtype")]
		public System.Nullable<int> CardType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("cardtype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CardType");
				this.SetAttributeValue("cardtype", value);
				this.OnPropertyChanged("CardType");
			}
		}
		
		/// <summary>
		/// card type attribute
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cardtypeid")]
		public Microsoft.Xrm.Sdk.EntityReference CardTypeId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("cardtypeid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CardTypeId");
				this.SetAttributeValue("cardtypeid", value);
				this.OnPropertyChanged("CardTypeId");
			}
		}
		
		/// <summary>
		/// Any int option for a cardtype.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("intcardoption")]
		public System.Nullable<int> IntCardOption
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("intcardoption");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IntCardOption");
				this.SetAttributeValue("intcardoption", value);
				this.OnPropertyChanged("IntCardOption");
			}
		}
		
		/// <summary>
		/// Select whether the card is enabled for user or not.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isenabled")]
		public System.Nullable<bool> IsEnabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isenabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsEnabled");
				this.SetAttributeValue("isenabled", value);
				this.OnPropertyChanged("IsEnabled");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the settings.
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
		/// Unique identifier of the business unit that owns this.
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
		/// Unique identifier of the team who owns this saved view.
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
		/// Unique identifier of the user who owns this saved view.
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
		/// Any string option for a cardtype.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stringcardoption")]
		public string StringCardOption
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("stringcardoption");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StringCardOption");
				this.SetAttributeValue("stringcardoption", value);
				this.OnPropertyChanged("StringCardOption");
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
		/// N:1 actioncardusersettings_businessunit
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("actioncardusersettings_businessunit")]
		public Common.Entities.BusinessUnit actioncardusersettings_businessunit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.BusinessUnit>("actioncardusersettings_businessunit", null);
			}
		}
		
		/// <summary>
		/// N:1 actioncardusersettings_owning_user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("actioncardusersettings_owning_user")]
		public Common.Entities.SystemUser actioncardusersettings_owning_user
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("actioncardusersettings_owning_user", null);
			}
		}
		
		/// <summary>
		/// N:1 cardtype_actioncardusersettings
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cardtypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("cardtype_actioncardusersettings")]
		public Common.Entities.CardType cardtype_actioncardusersettings
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.CardType>("cardtype_actioncardusersettings", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("cardtype_actioncardusersettings");
				this.SetRelatedEntity<Common.Entities.CardType>("cardtype_actioncardusersettings", null, value);
				this.OnPropertyChanged("cardtype_actioncardusersettings");
			}
		}
		
		/// <summary>
		/// N:1 team_actioncardusersettings
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_actioncardusersettings")]
		public Common.Entities.Team team_actioncardusersettings
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Team>("team_actioncardusersettings", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ActionCardUserSettings(object anonymousType) : 
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
                        Attributes["actioncardusersettingsid"] = base.Id;
                        break;
                    case "actioncardusersettingsid":
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