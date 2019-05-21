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
	/// Category for a Knowledge Article.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("knowledgearticlescategories")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class KnowledgeArticlesCategories : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CategoryId = "categoryid";
			public const string KnowledgeArticleCategoryId = "knowledgearticlecategoryid";
			public const string Id = "knowledgearticlecategoryid";
			public const string KnowledgeArticleId = "knowledgearticleid";
			public const string VersionNumber = "versionnumber";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public KnowledgeArticlesCategories() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "knowledgearticlescategories";
		
		public const string PrimaryIdAttribute = "knowledgearticlecategoryid";
		
		public const int EntityTypeCode = 9960;
		
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
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("categoryid")]
		public System.Nullable<System.Guid> CategoryId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("categoryid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the Category for the knowledge article.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticlecategoryid")]
		public System.Nullable<System.Guid> KnowledgeArticleCategoryId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("knowledgearticlecategoryid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KnowledgeArticleCategoryId");
				this.SetAttributeValue("knowledgearticlecategoryid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("KnowledgeArticleCategoryId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticlecategoryid")]
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
				this.KnowledgeArticleCategoryId = value;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleid")]
		public System.Nullable<System.Guid> KnowledgeArticleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("knowledgearticleid");
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
		/// N:N knowledgearticle_category
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("knowledgearticle_category")]
		public System.Collections.Generic.IEnumerable<Common.Entities.KnowledgeArticle> knowledgearticle_category
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.KnowledgeArticle>("knowledgearticle_category", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("knowledgearticle_category");
				this.SetRelatedEntities<Common.Entities.KnowledgeArticle>("knowledgearticle_category", null, value);
				this.OnPropertyChanged("knowledgearticle_category");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public KnowledgeArticlesCategories(object anonymousType) : 
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
                        Attributes["knowledgearticlecategoryid"] = base.Id;
                        break;
                    case "knowledgearticlecategoryid":
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