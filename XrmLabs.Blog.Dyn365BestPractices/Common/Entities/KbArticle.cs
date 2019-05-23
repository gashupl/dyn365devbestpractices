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
	public enum KbArticleState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Draft = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Unapproved = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Published = 3,
	}
	
	/// <summary>
	/// Structured content that is part of the knowledge base.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("kbarticle")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class KbArticle : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ArticleXml = "articlexml";
			public const string Comments = "comments";
			public const string Content = "content";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string EntityImage = "entityimage";
			public const string EntityImage_Timestamp = "entityimage_timestamp";
			public const string EntityImage_URL = "entityimage_url";
			public const string EntityImageId = "entityimageid";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string KbArticleId = "kbarticleid";
			public const string Id = "kbarticleid";
			public const string KbArticleTemplateId = "kbarticletemplateid";
			public const string KeyWords = "keywords";
			public const string LanguageCode = "languagecode";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Number = "number";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string SubjectId = "subjectid";
			public const string Title = "title";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string VersionNumber = "versionnumber";
			public const string kb_article_template_kb_articles = "kb_article_template_kb_articles";
			public const string lk_kbarticle_createdonbehalfby = "lk_kbarticle_createdonbehalfby";
			public const string lk_kbarticle_modifiedonbehalfby = "lk_kbarticle_modifiedonbehalfby";
			public const string lk_kbarticlebase_createdby = "lk_kbarticlebase_createdby";
			public const string lk_kbarticlebase_modifiedby = "lk_kbarticlebase_modifiedby";
			public const string organization_kb_articles = "organization_kb_articles";
			public const string subject_kb_articles = "subject_kb_articles";
			public const string TransactionCurrency_KbArticle = "TransactionCurrency_KbArticle";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public KbArticle() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "kbarticle";
		
		public const string PrimaryIdAttribute = "kbarticleid";
		
		public const string PrimaryNameAttribute = "title";
		
		public const int EntityTypeCode = 127;
		
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
		/// Shows the article content and formatting, stored as XML.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("articlexml")]
		public string ArticleXml
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("articlexml");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ArticleXml");
				this.SetAttributeValue("articlexml", value);
				this.OnPropertyChanged("ArticleXml");
			}
		}
		
		/// <summary>
		/// Comments regarding the knowledge base article.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("comments")]
		public string Comments
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("comments");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Comments");
				this.SetAttributeValue("comments", value);
				this.OnPropertyChanged("Comments");
			}
		}
		
		/// <summary>
		/// Description of the content of the knowledge base article.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("content")]
		public string Content
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("content");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the knowledge base article.
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
		/// Date and time when the knowledge base article was created.
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
		/// Unique identifier of the delegate user who created the article.
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
		/// Type additional information that describes the knowledge base article.
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
		/// The default image for the entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
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
		/// Unique identifier of the data import or data migration that created this record.
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
		/// Shows the ID of the article.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticleid")]
		public System.Nullable<System.Guid> KbArticleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("kbarticleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KbArticleId");
				this.SetAttributeValue("kbarticleid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("KbArticleId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticleid")]
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
				this.KbArticleId = value;
			}
		}
		
		/// <summary>
		/// Choose the template that you want to use as a base for creating the new article.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticletemplateid")]
		public Microsoft.Xrm.Sdk.EntityReference KbArticleTemplateId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("kbarticletemplateid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KbArticleTemplateId");
				this.SetAttributeValue("kbarticletemplateid", value);
				this.OnPropertyChanged("KbArticleTemplateId");
			}
		}
		
		/// <summary>
		/// Keywords to be used for searches in knowledge base articles.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("keywords")]
		public string KeyWords
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("keywords");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KeyWords");
				this.SetAttributeValue("keywords", value);
				this.OnPropertyChanged("KeyWords");
			}
		}
		
		/// <summary>
		/// Select which language the article must be available in. This list is based on the list of language packs that are installed in your Microsoft Dynamics 365 environment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("languagecode")]
		public System.Nullable<int> LanguageCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("languagecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LanguageCode");
				this.SetAttributeValue("languagecode", value);
				this.OnPropertyChanged("LanguageCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the knowledge base article.
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
		/// Date and time when the knowledge base article was last modified.
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
		/// Unique identifier of the delegate user who last modified the kbarticle.
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
		/// Knowledge base article number.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("number")]
		public string Number
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("number");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the article.
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
		/// Shows whether the knowledge base article is in draft, unapproved, or published status. Published articles are read-only and can't be edited unless they are unpublished.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Common.Entities.KbArticleState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Common.Entities.KbArticleState)(System.Enum.ToObject(typeof(Common.Entities.KbArticleState), optionSet.Value)));
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
		/// Select the article's status.
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
		/// Choose the subject of the article to assist with article searches. You can configure subjects under Business Management in the Settings area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
		public Microsoft.Xrm.Sdk.EntityReference SubjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("subjectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SubjectId");
				this.SetAttributeValue("subjectid", value);
				this.OnPropertyChanged("SubjectId");
			}
		}
		
		/// <summary>
		/// Type a subject or descriptive name for the article to assist with article searches.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
		public string Title
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("title");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Title");
				this.SetAttributeValue("title", value);
				this.OnPropertyChanged("Title");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
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
		/// Title of the knowledge base article.
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
		/// 1:N KbArticle_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_Annotation")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Annotation> KbArticle_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Annotation>("KbArticle_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KbArticle_Annotation");
				this.SetRelatedEntities<Common.Entities.Annotation>("KbArticle_Annotation", null, value);
				this.OnPropertyChanged("KbArticle_Annotation");
			}
		}
		
		/// <summary>
		/// 1:N KbArticle_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Common.Entities.AsyncOperation> KbArticle_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.AsyncOperation>("KbArticle_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KbArticle_AsyncOperations");
				this.SetRelatedEntities<Common.Entities.AsyncOperation>("KbArticle_AsyncOperations", null, value);
				this.OnPropertyChanged("KbArticle_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N KbArticle_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Common.Entities.BulkDeleteFailure> KbArticle_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.BulkDeleteFailure>("KbArticle_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KbArticle_BulkDeleteFailures");
				this.SetRelatedEntities<Common.Entities.BulkDeleteFailure>("KbArticle_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("KbArticle_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N kbarticle_comments
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("kbarticle_comments")]
		public System.Collections.Generic.IEnumerable<Common.Entities.KbArticleComment> kbarticle_comments
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.KbArticleComment>("kbarticle_comments", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("kbarticle_comments");
				this.SetRelatedEntities<Common.Entities.KbArticleComment>("kbarticle_comments", null, value);
				this.OnPropertyChanged("kbarticle_comments");
			}
		}
		
		/// <summary>
		/// 1:N KbArticle_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<Common.Entities.DuplicateRecord> KbArticle_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.DuplicateRecord>("KbArticle_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KbArticle_DuplicateBaseRecord");
				this.SetRelatedEntities<Common.Entities.DuplicateRecord>("KbArticle_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("KbArticle_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N KbArticle_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<Common.Entities.DuplicateRecord> KbArticle_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.DuplicateRecord>("KbArticle_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KbArticle_DuplicateMatchingRecord");
				this.SetRelatedEntities<Common.Entities.DuplicateRecord>("KbArticle_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("KbArticle_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N kbarticle_incidents
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("kbarticle_incidents")]
		public System.Collections.Generic.IEnumerable<Common.Entities.Incident> kbarticle_incidents
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.Incident>("kbarticle_incidents", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("kbarticle_incidents");
				this.SetRelatedEntities<Common.Entities.Incident>("kbarticle_incidents", null, value);
				this.OnPropertyChanged("kbarticle_incidents");
			}
		}
		
		/// <summary>
		/// 1:N kbarticle_principalobjectattributeaccess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("kbarticle_principalobjectattributeaccess")]
		public System.Collections.Generic.IEnumerable<Common.Entities.PrincipalObjectAttributeAccess> kbarticle_principalobjectattributeaccess
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.PrincipalObjectAttributeAccess>("kbarticle_principalobjectattributeaccess", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("kbarticle_principalobjectattributeaccess");
				this.SetRelatedEntities<Common.Entities.PrincipalObjectAttributeAccess>("kbarticle_principalobjectattributeaccess", null, value);
				this.OnPropertyChanged("kbarticle_principalobjectattributeaccess");
			}
		}
		
		/// <summary>
		/// 1:N KbArticle_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<Common.Entities.ProcessSession> KbArticle_ProcessSessions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.ProcessSession>("KbArticle_ProcessSessions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KbArticle_ProcessSessions");
				this.SetRelatedEntities<Common.Entities.ProcessSession>("KbArticle_ProcessSessions", null, value);
				this.OnPropertyChanged("KbArticle_ProcessSessions");
			}
		}
		
		/// <summary>
		/// 1:N KbArticle_SharepointDocument
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_SharepointDocument")]
		public System.Collections.Generic.IEnumerable<Common.Entities.SharePointDocument> KbArticle_SharepointDocument
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.SharePointDocument>("KbArticle_SharepointDocument", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KbArticle_SharepointDocument");
				this.SetRelatedEntities<Common.Entities.SharePointDocument>("KbArticle_SharepointDocument", null, value);
				this.OnPropertyChanged("KbArticle_SharepointDocument");
			}
		}
		
		/// <summary>
		/// 1:N KbArticle_SharepointDocumentLocation
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_SharepointDocumentLocation")]
		public System.Collections.Generic.IEnumerable<Common.Entities.SharePointDocumentLocation> KbArticle_SharepointDocumentLocation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.SharePointDocumentLocation>("KbArticle_SharepointDocumentLocation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KbArticle_SharepointDocumentLocation");
				this.SetRelatedEntities<Common.Entities.SharePointDocumentLocation>("KbArticle_SharepointDocumentLocation", null, value);
				this.OnPropertyChanged("KbArticle_SharepointDocumentLocation");
			}
		}
		
		/// <summary>
		/// 1:N KbArticle_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Common.Entities.SyncError> KbArticle_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.SyncError>("KbArticle_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KbArticle_SyncErrors");
				this.SetRelatedEntities<Common.Entities.SyncError>("KbArticle_SyncErrors", null, value);
				this.OnPropertyChanged("KbArticle_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_kbarticle
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_kbarticle")]
		public System.Collections.Generic.IEnumerable<Common.Entities.UserEntityInstanceData> userentityinstancedata_kbarticle
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Common.Entities.UserEntityInstanceData>("userentityinstancedata_kbarticle", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_kbarticle");
				this.SetRelatedEntities<Common.Entities.UserEntityInstanceData>("userentityinstancedata_kbarticle", null, value);
				this.OnPropertyChanged("userentityinstancedata_kbarticle");
			}
		}
		
		/// <summary>
		/// N:1 kb_article_template_kb_articles
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticletemplateid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("kb_article_template_kb_articles")]
		public Common.Entities.KbArticleTemplate kb_article_template_kb_articles
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.KbArticleTemplate>("kb_article_template_kb_articles", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("kb_article_template_kb_articles");
				this.SetRelatedEntity<Common.Entities.KbArticleTemplate>("kb_article_template_kb_articles", null, value);
				this.OnPropertyChanged("kb_article_template_kb_articles");
			}
		}
		
		/// <summary>
		/// N:1 lk_kbarticle_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticle_createdonbehalfby")]
		public Common.Entities.SystemUser lk_kbarticle_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_kbarticle_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_kbarticle_createdonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_kbarticle_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_kbarticle_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_kbarticle_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticle_modifiedonbehalfby")]
		public Common.Entities.SystemUser lk_kbarticle_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_kbarticle_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_kbarticle_modifiedonbehalfby");
				this.SetRelatedEntity<Common.Entities.SystemUser>("lk_kbarticle_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_kbarticle_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_kbarticlebase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlebase_createdby")]
		public Common.Entities.SystemUser lk_kbarticlebase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_kbarticlebase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_kbarticlebase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlebase_modifiedby")]
		public Common.Entities.SystemUser lk_kbarticlebase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.SystemUser>("lk_kbarticlebase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 organization_kb_articles
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_kb_articles")]
		public Common.Entities.Organization organization_kb_articles
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Organization>("organization_kb_articles", null);
			}
		}
		
		/// <summary>
		/// N:1 subject_kb_articles
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_kb_articles")]
		public Common.Entities.Subject subject_kb_articles
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Subject>("subject_kb_articles", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("subject_kb_articles");
				this.SetRelatedEntity<Common.Entities.Subject>("subject_kb_articles", null, value);
				this.OnPropertyChanged("subject_kb_articles");
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_KbArticle
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_KbArticle")]
		public Common.Entities.TransactionCurrency TransactionCurrency_KbArticle
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.TransactionCurrency>("TransactionCurrency_KbArticle", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrency_KbArticle");
				this.SetRelatedEntity<Common.Entities.TransactionCurrency>("TransactionCurrency_KbArticle", null, value);
				this.OnPropertyChanged("TransactionCurrency_KbArticle");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public KbArticle(object anonymousType) : 
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
                        Attributes["kbarticleid"] = base.Id;
                        break;
                    case "kbarticleid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual KbArticle_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((KbArticle_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}