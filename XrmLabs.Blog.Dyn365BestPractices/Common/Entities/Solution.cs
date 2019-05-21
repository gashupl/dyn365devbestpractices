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
	/// A solution which contains CRM customizations.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("solution")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class Solution : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ConfigurationPageId = "configurationpageid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string FriendlyName = "friendlyname";
			public const string InstalledOn = "installedon";
			public const string IsManaged = "ismanaged";
			public const string IsVisible = "isvisible";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string ParentSolutionId = "parentsolutionid";
			public const string PinpointAssetId = "pinpointassetid";
			public const string PinpointPublisherId = "pinpointpublisherid";
			public const string PinpointSolutionDefaultLocale = "pinpointsolutiondefaultlocale";
			public const string PinpointSolutionId = "pinpointsolutionid";
			public const string PublisherId = "publisherid";
			public const string SolutionId = "solutionid";
			public const string Id = "solutionid";
			public const string SolutionPackageVersion = "solutionpackageversion";
			public const string SolutionType = "solutiontype";
			public const string UniqueName = "uniquename";
			public const string UpdatedOn = "updatedon";
			public const string Version = "version";
			public const string VersionNumber = "versionnumber";
			public const string lk_solution_createdby = "lk_solution_createdby";
			public const string lk_solution_modifiedby = "lk_solution_modifiedby";
			public const string lk_solutionbase_createdonbehalfby = "lk_solutionbase_createdonbehalfby";
			public const string lk_solutionbase_modifiedonbehalfby = "lk_solutionbase_modifiedonbehalfby";
			public const string organization_solution = "organization_solution";
			public const string publisher_solution = "publisher_solution";
			public const string solution_configuration_webresource = "solution_configuration_webresource";
			public const string Referencingsolution_parent_solution = "solution_parent_solution";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Solution() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "solution";
		
		public const string PrimaryIdAttribute = "solutionid";
		
		public const string PrimaryNameAttribute = "friendlyname";
		
		public const int EntityTypeCode = 7100;
		
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
		/// A link to an optional configuration page for this solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configurationpageid")]
		public Microsoft.Xrm.Sdk.EntityReference ConfigurationPageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("configurationpageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConfigurationPageId");
				this.SetAttributeValue("configurationpageid", value);
				this.OnPropertyChanged("ConfigurationPageId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the solution.
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
		/// Date and time when the solution was created.
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
		/// Unique identifier of the delegate user who created the solution.
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
		/// Description of the solution.
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
		/// User display name for the solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("friendlyname")]
		public string FriendlyName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("friendlyname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FriendlyName");
				this.SetAttributeValue("friendlyname", value);
				this.OnPropertyChanged("FriendlyName");
			}
		}
		
		/// <summary>
		/// Date and time when the solution was installed/upgraded.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("installedon")]
		public System.Nullable<System.DateTime> InstalledOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("installedon");
			}
		}
		
		/// <summary>
		/// Indicates whether the solution is managed or unmanaged.
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
		/// Indicates whether the solution is visible outside of the platform.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvisible")]
		public System.Nullable<bool> IsVisible
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isvisible");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the solution.
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
		/// Date and time when the solution was last modified.
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
		/// Unique identifier of the delegate user who modified the solution.
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
		/// Unique identifier of the organization associated with the solution.
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
		/// Unique identifier of the parent solution. Should only be non-null if this solution is a patch.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsolutionid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentSolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsolutionid");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointassetid")]
		public string PinpointAssetId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("pinpointassetid");
			}
		}
		
		/// <summary>
		/// Identifier of the publisher of this solution in Microsoft Pinpoint.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointpublisherid")]
		public System.Nullable<long> PinpointPublisherId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("pinpointpublisherid");
			}
		}
		
		/// <summary>
		/// Default locale of the solution in Microsoft Pinpoint.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointsolutiondefaultlocale")]
		public string PinpointSolutionDefaultLocale
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("pinpointsolutiondefaultlocale");
			}
		}
		
		/// <summary>
		/// Identifier of the solution in Microsoft Pinpoint.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointsolutionid")]
		public System.Nullable<long> PinpointSolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("pinpointsolutionid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisherid")]
		public Microsoft.Xrm.Sdk.EntityReference PublisherId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("publisherid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PublisherId");
				this.SetAttributeValue("publisherid", value);
				this.OnPropertyChanged("PublisherId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SolutionId");
				this.SetAttributeValue("solutionid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SolutionId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
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
				this.SolutionId = value;
			}
		}
		
		/// <summary>
		/// Solution package source organization version
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionpackageversion")]
		public string SolutionPackageVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("solutionpackageversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SolutionPackageVersion");
				this.SetAttributeValue("solutionpackageversion", value);
				this.OnPropertyChanged("SolutionPackageVersion");
			}
		}
		
		/// <summary>
		/// Solution Type
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutiontype")]
		public Microsoft.Xrm.Sdk.OptionSetValue SolutionType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("solutiontype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SolutionType");
				this.SetAttributeValue("solutiontype", value);
				this.OnPropertyChanged("SolutionType");
			}
		}
		
		/// <summary>
		/// The unique name of this solution
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquename")]
		public string UniqueName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("uniquename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UniqueName");
				this.SetAttributeValue("uniquename", value);
				this.OnPropertyChanged("UniqueName");
			}
		}
		
		/// <summary>
		/// Date and time when the solution was updated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("updatedon")]
		public System.Nullable<System.DateTime> UpdatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("updatedon");
			}
		}
		
		/// <summary>
		/// Solution version, used to identify a solution for upgrades and hotfixes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
		public string Version
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("version");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Version");
				this.SetAttributeValue("version", value);
				this.OnPropertyChanged("Version");
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
		/// 1:N solution_parent_solution
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solution_parent_solution", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Common.Entities.Solution> Referencedsolution_parent_solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Solution>("solution_parent_solution", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedsolution_parent_solution");
				this.SetRelatedEntities<Common.Entities.Solution>("solution_parent_solution", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedsolution_parent_solution");
			}
		}
		
		/// <summary>
		/// 1:N solution_solutioncomponent
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solution_solutioncomponent")]
		public System.Collections.Generic.IEnumerable<Common.Entities.SolutionComponent> solution_solutioncomponent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.SolutionComponent>("solution_solutioncomponent", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solution_solutioncomponent");
				this.SetRelatedEntities<Common.Entities.SolutionComponent>("solution_solutioncomponent", null, value);
				this.OnPropertyChanged("solution_solutioncomponent");
			}
		}
		
		/// <summary>
		/// 1:N Solution_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Solution_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Common.Entities.SyncError> Solution_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.SyncError>("Solution_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Solution_SyncErrors");
				this.SetRelatedEntities<Common.Entities.SyncError>("Solution_SyncErrors", null, value);
				this.OnPropertyChanged("Solution_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_solution
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_solution")]
		public System.Collections.Generic.IEnumerable<Common.Entities.UserEntityInstanceData> userentityinstancedata_solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.UserEntityInstanceData>("userentityinstancedata_solution", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_solution");
				this.SetRelatedEntities<Common.Entities.UserEntityInstanceData>("userentityinstancedata_solution", null, value);
				this.OnPropertyChanged("userentityinstancedata_solution");
			}
		}
		
		/// <summary>
		/// N:1 lk_solution_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solution_createdby")]
		public Common.Entities.SystemUser lk_solution_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_solution_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_solution_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solution_modifiedby")]
		public Common.Entities.SystemUser lk_solution_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_solution_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_solutionbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutionbase_createdonbehalfby")]
		public Common.Entities.SystemUser lk_solutionbase_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_solutionbase_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_solutionbase_createdonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_solutionbase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_solutionbase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_solutionbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutionbase_modifiedonbehalfby")]
		public Common.Entities.SystemUser lk_solutionbase_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_solutionbase_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_solutionbase_modifiedonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_solutionbase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_solutionbase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_solution
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_solution")]
		public Common.Entities.Organization organization_solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Organization>("organization_solution", null);
			}
		}
		
		/// <summary>
		/// N:1 publisher_solution
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisherid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("publisher_solution")]
		public Common.Entities.Publisher publisher_solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Publisher>("publisher_solution", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("publisher_solution");
				this.SetRelatedEntity<Common.Entities.Publisher>("publisher_solution", null, value);
				this.OnPropertyChanged("publisher_solution");
			}
		}
		
		/// <summary>
		/// N:1 solution_configuration_webresource
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configurationpageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solution_configuration_webresource")]
		public Common.Entities.WebResource solution_configuration_webresource
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.WebResource>("solution_configuration_webresource", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solution_configuration_webresource");
				this.SetRelatedEntity<Common.Entities.WebResource>("solution_configuration_webresource", null, value);
				this.OnPropertyChanged("solution_configuration_webresource");
			}
		}
		
		/// <summary>
		/// N:1 solution_parent_solution
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsolutionid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solution_parent_solution", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Common.Entities.Solution Referencingsolution_parent_solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Solution>("solution_parent_solution", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Solution(object anonymousType) : 
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
                        Attributes["solutionid"] = base.Id;
                        break;
                    case "solutionid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutiontype")]
		public virtual Solution_SolutionType? SolutionTypeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Solution_SolutionType?)(EntityOptionSetEnum.GetEnum(this, "solutiontype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				SolutionType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}