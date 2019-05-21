
//[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]

namespace Common.Entities
{
	
	/// <summary>
	/// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class Dyn365ServiceContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		
		/// <summary>
		/// Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Dyn365ServiceContext(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Account"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Account> AccountSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Account>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.AccountLeads"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.AccountLeads> AccountLeadsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.AccountLeads>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ACIViewMapper"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ACIViewMapper> ACIViewMapperSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ACIViewMapper>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ActionCard"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ActionCard> ActionCardSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ActionCard>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ActionCardUserSettings"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ActionCardUserSettings> ActionCardUserSettingsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ActionCardUserSettings>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ActionCardUserState"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ActionCardUserState> ActionCardUserStateSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ActionCardUserState>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ActivityMimeAttachment"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ActivityMimeAttachment> ActivityMimeAttachmentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ActivityMimeAttachment>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ActivityParty"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ActivityParty> ActivityPartySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ActivityParty>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ActivityPointer"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ActivityPointer> ActivityPointerSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ActivityPointer>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.AdvancedSimilarityRule"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.AdvancedSimilarityRule> AdvancedSimilarityRuleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.AdvancedSimilarityRule>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Annotation"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Annotation> AnnotationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Annotation>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.AnnualFiscalCalendar"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.AnnualFiscalCalendar> AnnualFiscalCalendarSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.AnnualFiscalCalendar>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.AppConfig"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.AppConfig> AppConfigSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.AppConfig>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.AppConfigInstance"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.AppConfigInstance> AppConfigInstanceSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.AppConfigInstance>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.AppConfigMaster"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.AppConfigMaster> AppConfigMasterSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.AppConfigMaster>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.AppModule"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.AppModule> AppModuleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.AppModule>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.AppModuleComponent"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.AppModuleComponent> AppModuleComponentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.AppModuleComponent>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.AppModuleRoles"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.AppModuleRoles> AppModuleRolesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.AppModuleRoles>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Appointment"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Appointment> AppointmentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Appointment>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.AsyncOperation"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.AsyncOperation> AsyncOperationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.AsyncOperation>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.AttributeMap"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.AttributeMap> AttributeMapSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.AttributeMap>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Audit"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Audit> AuditSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Audit>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.AzureServiceConnection"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.AzureServiceConnection> AzureServiceConnectionSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.AzureServiceConnection>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BookableResource"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BookableResource> BookableResourceSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BookableResource>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BookableResourceBooking"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BookableResourceBooking> BookableResourceBookingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BookableResourceBooking>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BookableResourceBookingExchangeSyncIdMapping"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BookableResourceBookingExchangeSyncIdMapping> BookableResourceBookingExchangeSyncIdMappingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BookableResourceBookingExchangeSyncIdMapping>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BookableResourceBookingHeader"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BookableResourceBookingHeader> BookableResourceBookingHeaderSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BookableResourceBookingHeader>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BookableResourceCategory"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BookableResourceCategory> BookableResourceCategorySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BookableResourceCategory>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BookableResourceCategoryAssn"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BookableResourceCategoryAssn> BookableResourceCategoryAssnSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BookableResourceCategoryAssn>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BookableResourceCharacteristic"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BookableResourceCharacteristic> BookableResourceCharacteristicSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BookableResourceCharacteristic>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BookableResourceGroup"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BookableResourceGroup> BookableResourceGroupSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BookableResourceGroup>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BookingStatus"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BookingStatus> BookingStatusSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BookingStatus>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BulkDeleteFailure"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BulkDeleteFailure> BulkDeleteFailureSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BulkDeleteFailure>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BulkDeleteOperation"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BulkDeleteOperation> BulkDeleteOperationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BulkDeleteOperation>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BulkOperation"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BulkOperation> BulkOperationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BulkOperation>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BulkOperationLog"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BulkOperationLog> BulkOperationLogSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BulkOperationLog>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BusinessProcessFlowInstance"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BusinessProcessFlowInstance> BusinessProcessFlowInstanceSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BusinessProcessFlowInstance>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BusinessUnit"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BusinessUnit> BusinessUnitSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BusinessUnit>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.BusinessUnitNewsArticle"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.BusinessUnitNewsArticle> BusinessUnitNewsArticleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.BusinessUnitNewsArticle>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Calendar"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Calendar> CalendarSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Calendar>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Campaign"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Campaign> CampaignSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Campaign>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CampaignActivity"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CampaignActivity> CampaignActivitySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CampaignActivity>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CampaignActivityItem"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CampaignActivityItem> CampaignActivityItemSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CampaignActivityItem>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CampaignItem"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CampaignItem> CampaignItemSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CampaignItem>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CampaignResponse"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CampaignResponse> CampaignResponseSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CampaignResponse>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CardType"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CardType> CardTypeSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CardType>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Category"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Category> CategorySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Category>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ChannelAccessProfile"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ChannelAccessProfile> ChannelAccessProfileSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ChannelAccessProfile>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ChannelAccessProfileEntityAccessLevel"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ChannelAccessProfileEntityAccessLevel> ChannelAccessProfileEntityAccessLevelSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ChannelAccessProfileEntityAccessLevel>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ChannelAccessProfileRule"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ChannelAccessProfileRule> ChannelAccessProfileRuleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ChannelAccessProfileRule>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ChannelAccessProfileRuleItem"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ChannelAccessProfileRuleItem> ChannelAccessProfileRuleItemSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ChannelAccessProfileRuleItem>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ChannelProperty"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ChannelProperty> ChannelPropertySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ChannelProperty>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ChannelPropertyGroup"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ChannelPropertyGroup> ChannelPropertyGroupSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ChannelPropertyGroup>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Characteristic"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Characteristic> CharacteristicSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Characteristic>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ColumnMapping"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ColumnMapping> ColumnMappingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ColumnMapping>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Commitment"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Commitment> CommitmentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Commitment>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Competitor"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Competitor> CompetitorSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Competitor>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CompetitorProduct"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CompetitorProduct> CompetitorProductSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CompetitorProduct>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CompetitorSalesLiterature"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CompetitorSalesLiterature> CompetitorSalesLiteratureSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CompetitorSalesLiterature>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Connection"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Connection> ConnectionSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Connection>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ConnectionRole"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ConnectionRole> ConnectionRoleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ConnectionRole>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ConnectionRoleAssociation"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ConnectionRoleAssociation> ConnectionRoleAssociationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ConnectionRoleAssociation>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ConnectionRoleObjectTypeCode"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ConnectionRoleObjectTypeCode> ConnectionRoleObjectTypeCodeSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ConnectionRoleObjectTypeCode>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ConstraintBasedGroup"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ConstraintBasedGroup> ConstraintBasedGroupSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ConstraintBasedGroup>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Contact"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Contact> ContactSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Contact>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ContactInvoices"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ContactInvoices> ContactInvoicesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ContactInvoices>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ContactLeads"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ContactLeads> ContactLeadsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ContactLeads>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ContactOrders"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ContactOrders> ContactOrdersSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ContactOrders>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ContactQuotes"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ContactQuotes> ContactQuotesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ContactQuotes>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Contract"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Contract> ContractSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Contract>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ContractDetail"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ContractDetail> ContractDetailSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ContractDetail>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ContractTemplate"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ContractTemplate> ContractTemplateSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ContractTemplate>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ConvertRule"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ConvertRule> ConvertRuleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ConvertRule>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ConvertRuleItem"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ConvertRuleItem> ConvertRuleItemSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ConvertRuleItem>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CustomControl"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CustomControl> CustomControlSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CustomControl>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CustomControlDefaultConfig"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CustomControlDefaultConfig> CustomControlDefaultConfigSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CustomControlDefaultConfig>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CustomControlResource"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CustomControlResource> CustomControlResourceSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CustomControlResource>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CustomerAddress"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CustomerAddress> CustomerAddressSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CustomerAddress>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CustomerOpportunityRole"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CustomerOpportunityRole> CustomerOpportunityRoleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CustomerOpportunityRole>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.CustomerRelationship"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.CustomerRelationship> CustomerRelationshipSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.CustomerRelationship>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.DataPerformance"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.DataPerformance> DataPerformanceSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.DataPerformance>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.DelveActionHub"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.DelveActionHub> DelveActionHubSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.DelveActionHub>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Dependency"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Dependency> DependencySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Dependency>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Discount"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Discount> DiscountSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Discount>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.DiscountType"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.DiscountType> DiscountTypeSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.DiscountType>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.DisplayString"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.DisplayString> DisplayStringSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.DisplayString>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.DocumentTemplate"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.DocumentTemplate> DocumentTemplateSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.DocumentTemplate>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.DuplicateRecord"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.DuplicateRecord> DuplicateRecordSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.DuplicateRecord>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.DuplicateRule"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.DuplicateRule> DuplicateRuleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.DuplicateRule>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.DuplicateRuleCondition"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.DuplicateRuleCondition> DuplicateRuleConditionSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.DuplicateRuleCondition>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.DynamicProperty"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.DynamicProperty> DynamicPropertySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.DynamicProperty>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.DynamicPropertyAssociation"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.DynamicPropertyAssociation> DynamicPropertyAssociationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.DynamicPropertyAssociation>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.DynamicPropertyInstance"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.DynamicPropertyInstance> DynamicPropertyInstanceSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.DynamicPropertyInstance>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.DynamicPropertyOptionSetItem"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.DynamicPropertyOptionSetItem> DynamicPropertyOptionSetItemSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.DynamicPropertyOptionSetItem>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Email"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Email> EmailSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Email>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.EmailServerProfile"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.EmailServerProfile> EmailServerProfileSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.EmailServerProfile>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.EmailSignature"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.EmailSignature> EmailSignatureSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.EmailSignature>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Entitlement"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Entitlement> EntitlementSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Entitlement>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.EntitlementChannel"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.EntitlementChannel> EntitlementChannelSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.EntitlementChannel>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.EntitlementContacts"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.EntitlementContacts> EntitlementContactsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.EntitlementContacts>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.EntitlementProducts"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.EntitlementProducts> EntitlementProductsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.EntitlementProducts>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.EntitlementTemplate"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.EntitlementTemplate> EntitlementTemplateSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.EntitlementTemplate>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.EntitlementTemplateChannel"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.EntitlementTemplateChannel> EntitlementTemplateChannelSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.EntitlementTemplateChannel>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.EntitlementTemplateProducts"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.EntitlementTemplateProducts> EntitlementTemplateProductsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.EntitlementTemplateProducts>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.EntityDataProvider"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.EntityDataProvider> EntityDataProviderSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.EntityDataProvider>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.EntityDataSource"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.EntityDataSource> EntityDataSourceSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.EntityDataSource>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.EntityMap"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.EntityMap> EntityMapSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.EntityMap>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Equipment"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Equipment> EquipmentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Equipment>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ExchangeSyncIdMapping"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ExchangeSyncIdMapping> ExchangeSyncIdMappingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ExchangeSyncIdMapping>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ExpanderEvent"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ExpanderEvent> ExpanderEventSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ExpanderEvent>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ExpiredProcess"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ExpiredProcess> ExpiredProcessSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ExpiredProcess>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ExternalParty"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ExternalParty> ExternalPartySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ExternalParty>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ExternalPartyItem"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ExternalPartyItem> ExternalPartyItemSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ExternalPartyItem>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Fax"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Fax> FaxSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Fax>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Feedback"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Feedback> FeedbackSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Feedback>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.FieldPermission"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.FieldPermission> FieldPermissionSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.FieldPermission>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.FieldSecurityProfile"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.FieldSecurityProfile> FieldSecurityProfileSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.FieldSecurityProfile>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.FixedMonthlyFiscalCalendar"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.FixedMonthlyFiscalCalendar> FixedMonthlyFiscalCalendarSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.FixedMonthlyFiscalCalendar>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Goal"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Goal> GoalSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Goal>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.GoalRollupQuery"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.GoalRollupQuery> GoalRollupQuerySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.GoalRollupQuery>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.HierarchyRule"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.HierarchyRule> HierarchyRuleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.HierarchyRule>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.HierarchySecurityConfiguration"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.HierarchySecurityConfiguration> HierarchySecurityConfigurationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.HierarchySecurityConfiguration>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Import"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Import> ImportSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Import>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ImportEntityMapping"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ImportEntityMapping> ImportEntityMappingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ImportEntityMapping>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ImportFile"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ImportFile> ImportFileSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ImportFile>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ImportJob"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ImportJob> ImportJobSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ImportJob>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ImportLog"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ImportLog> ImportLogSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ImportLog>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ImportMap"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ImportMap> ImportMapSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ImportMap>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Incident"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Incident> IncidentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Incident>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.IncidentKnowledgeBaseRecord"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.IncidentKnowledgeBaseRecord> IncidentKnowledgeBaseRecordSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.IncidentKnowledgeBaseRecord>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.IncidentResolution"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.IncidentResolution> IncidentResolutionSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.IncidentResolution>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.InteractionForEmail"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.InteractionForEmail> InteractionForEmailSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.InteractionForEmail>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.InvalidDependency"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.InvalidDependency> InvalidDependencySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.InvalidDependency>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Invoice"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Invoice> InvoiceSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Invoice>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.InvoiceDetail"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.InvoiceDetail> InvoiceDetailSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.InvoiceDetail>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.IsvConfig"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.IsvConfig> IsvConfigSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.IsvConfig>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.KbArticle"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.KbArticle> KbArticleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.KbArticle>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.KbArticleComment"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.KbArticleComment> KbArticleCommentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.KbArticleComment>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.KbArticleTemplate"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.KbArticleTemplate> KbArticleTemplateSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.KbArticleTemplate>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.KnowledgeArticle"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.KnowledgeArticle> KnowledgeArticleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.KnowledgeArticle>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.KnowledgeArticleIncident"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.KnowledgeArticleIncident> KnowledgeArticleIncidentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.KnowledgeArticleIncident>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.KnowledgeArticlesCategories"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.KnowledgeArticlesCategories> KnowledgeArticlesCategoriesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.KnowledgeArticlesCategories>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.KnowledgeArticleViews"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.KnowledgeArticleViews> KnowledgeArticleViewsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.KnowledgeArticleViews>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.KnowledgeBaseRecord"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.KnowledgeBaseRecord> KnowledgeBaseRecordSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.KnowledgeBaseRecord>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.KnowledgeSearchModel"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.KnowledgeSearchModel> KnowledgeSearchModelSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.KnowledgeSearchModel>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.LanguageLocale"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.LanguageLocale> LanguageLocaleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.LanguageLocale>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Lead"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Lead> LeadSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Lead>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.LeadAddress"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.LeadAddress> LeadAddressSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.LeadAddress>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.LeadCompetitors"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.LeadCompetitors> LeadCompetitorsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.LeadCompetitors>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.LeadProduct"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.LeadProduct> LeadProductSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.LeadProduct>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.LeadToOpportunitySalesProcess"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.LeadToOpportunitySalesProcess> LeadToOpportunitySalesProcessSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.LeadToOpportunitySalesProcess>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Letter"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Letter> LetterSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Letter>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.License"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.License> LicenseSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.License>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.List"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.List> ListSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.List>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ListMember"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ListMember> ListMemberSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ListMember>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.LookUpMapping"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.LookUpMapping> LookUpMappingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.LookUpMapping>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Mailbox"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Mailbox> MailboxSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Mailbox>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.MailboxStatistics"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.MailboxStatistics> MailboxStatisticsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.MailboxStatistics>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.MailboxTrackingFolder"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.MailboxTrackingFolder> MailboxTrackingFolderSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.MailboxTrackingFolder>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.MailMergeTemplate"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.MailMergeTemplate> MailMergeTemplateSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.MailMergeTemplate>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Metric"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Metric> MetricSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Metric>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.MobileOfflineProfile"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.MobileOfflineProfile> MobileOfflineProfileSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.MobileOfflineProfile>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.MobileOfflineProfileItem"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.MobileOfflineProfileItem> MobileOfflineProfileItemSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.MobileOfflineProfileItem>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.MobileOfflineProfileItemAssociation"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.MobileOfflineProfileItemAssociation> MobileOfflineProfileItemAssociationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.MobileOfflineProfileItemAssociation>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.MonthlyFiscalCalendar"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.MonthlyFiscalCalendar> MonthlyFiscalCalendarSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.MonthlyFiscalCalendar>();
			}
		}
	
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.msdyn_odatav4ds"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.msdyn_odatav4ds> msdyn_odatav4dsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.msdyn_odatav4ds>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.msdyn_PostAlbum"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.msdyn_PostAlbum> msdyn_PostAlbumSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.msdyn_PostAlbum>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.msdyn_PostConfig"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.msdyn_PostConfig> msdyn_PostConfigSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.msdyn_PostConfig>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.msdyn_PostRuleConfig"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.msdyn_PostRuleConfig> msdyn_PostRuleConfigSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.msdyn_PostRuleConfig>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.msdyn_relationshipinsightsunifiedconfig"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.msdyn_relationshipinsightsunifiedconfig> msdyn_relationshipinsightsunifiedconfigSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.msdyn_relationshipinsightsunifiedconfig>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.msdyn_siconfig"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.msdyn_siconfig> msdyn_siconfigSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.msdyn_siconfig>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.msdyn_wallsavedquery"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.msdyn_wallsavedquery> msdyn_wallsavedquerySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.msdyn_wallsavedquery>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.msdyn_wallsavedqueryusersettings"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.msdyn_wallsavedqueryusersettings> msdyn_wallsavedqueryusersettingsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.msdyn_wallsavedqueryusersettings>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.NavigationSetting"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.NavigationSetting> NavigationSettingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.NavigationSetting>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.NewProcess"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.NewProcess> NewProcessSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.NewProcess>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.OfficeGraphDocument"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.OfficeGraphDocument> OfficeGraphDocumentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.OfficeGraphDocument>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.OfflineCommandDefinition"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.OfflineCommandDefinition> OfflineCommandDefinitionSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.OfflineCommandDefinition>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Opportunity"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Opportunity> OpportunitySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Opportunity>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.OpportunityClose"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.OpportunityClose> OpportunityCloseSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.OpportunityClose>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.OpportunityCompetitors"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.OpportunityCompetitors> OpportunityCompetitorsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.OpportunityCompetitors>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.OpportunityProduct"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.OpportunityProduct> OpportunityProductSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.OpportunityProduct>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.OpportunitySalesProcess"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.OpportunitySalesProcess> OpportunitySalesProcessSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.OpportunitySalesProcess>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.OrderClose"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.OrderClose> OrderCloseSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.OrderClose>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Organization"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Organization> OrganizationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Organization>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.OrganizationUI"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.OrganizationUI> OrganizationUISet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.OrganizationUI>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.OrgInsightsMetric"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.OrgInsightsMetric> OrgInsightsMetricSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.OrgInsightsMetric>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.OrgInsightsNotification"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.OrgInsightsNotification> OrgInsightsNotificationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.OrgInsightsNotification>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.OwnerMapping"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.OwnerMapping> OwnerMappingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.OwnerMapping>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PersonalDocumentTemplate"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PersonalDocumentTemplate> PersonalDocumentTemplateSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PersonalDocumentTemplate>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PhoneCall"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PhoneCall> PhoneCallSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PhoneCall>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PhoneToCaseProcess"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PhoneToCaseProcess> PhoneToCaseProcessSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PhoneToCaseProcess>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PickListMapping"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PickListMapping> PickListMappingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PickListMapping>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PluginAssembly"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PluginAssembly> PluginAssemblySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PluginAssembly>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PluginTraceLog"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PluginTraceLog> PluginTraceLogSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PluginTraceLog>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PluginType"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PluginType> PluginTypeSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PluginType>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PluginTypeStatistic"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PluginTypeStatistic> PluginTypeStatisticSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PluginTypeStatistic>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Position"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Position> PositionSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Position>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Post"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Post> PostSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Post>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PostComment"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PostComment> PostCommentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PostComment>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PostFollow"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PostFollow> PostFollowSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PostFollow>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PostLike"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PostLike> PostLikeSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PostLike>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PriceLevel"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PriceLevel> PriceLevelSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PriceLevel>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PrincipalEntityMap"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PrincipalEntityMap> PrincipalEntityMapSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PrincipalEntityMap>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PrincipalObjectAttributeAccess"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PrincipalObjectAttributeAccess> PrincipalObjectAttributeAccessSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PrincipalObjectAttributeAccess>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Privilege"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Privilege> PrivilegeSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Privilege>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ProcessSession"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ProcessSession> ProcessSessionSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ProcessSession>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ProcessStage"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ProcessStage> ProcessStageSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ProcessStage>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ProcessTrigger"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ProcessTrigger> ProcessTriggerSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ProcessTrigger>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Product"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Product> ProductSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Product>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ProductAssociation"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ProductAssociation> ProductAssociationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ProductAssociation>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ProductPriceLevel"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ProductPriceLevel> ProductPriceLevelSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ProductPriceLevel>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ProductSalesLiterature"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ProductSalesLiterature> ProductSalesLiteratureSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ProductSalesLiterature>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ProductSubstitute"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ProductSubstitute> ProductSubstituteSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ProductSubstitute>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Publisher"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Publisher> PublisherSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Publisher>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.PublisherAddress"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.PublisherAddress> PublisherAddressSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.PublisherAddress>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.QuarterlyFiscalCalendar"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.QuarterlyFiscalCalendar> QuarterlyFiscalCalendarSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.QuarterlyFiscalCalendar>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Queue"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Queue> QueueSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Queue>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.QueueItem"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.QueueItem> QueueItemSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.QueueItem>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.QueueMembership"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.QueueMembership> QueueMembershipSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.QueueMembership>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Quote"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Quote> QuoteSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Quote>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.QuoteClose"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.QuoteClose> QuoteCloseSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.QuoteClose>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.QuoteDetail"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.QuoteDetail> QuoteDetailSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.QuoteDetail>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RatingModel"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RatingModel> RatingModelSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RatingModel>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RatingValue"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RatingValue> RatingValueSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RatingValue>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RecommendedDocument"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RecommendedDocument> RecommendedDocumentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RecommendedDocument>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RecurrenceRule"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RecurrenceRule> RecurrenceRuleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RecurrenceRule>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RecurringAppointmentMaster"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RecurringAppointmentMaster> RecurringAppointmentMasterSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RecurringAppointmentMaster>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RelationshipRole"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RelationshipRole> RelationshipRoleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RelationshipRole>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RelationshipRoleMap"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RelationshipRoleMap> RelationshipRoleMapSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RelationshipRoleMap>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Report"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Report> ReportSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Report>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ReportCategory"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ReportCategory> ReportCategorySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ReportCategory>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ReportEntity"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ReportEntity> ReportEntitySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ReportEntity>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ReportLink"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ReportLink> ReportLinkSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ReportLink>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ReportVisibility"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ReportVisibility> ReportVisibilitySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ReportVisibility>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Resource"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Resource> ResourceSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Resource>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ResourceGroup"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ResourceGroup> ResourceGroupSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ResourceGroup>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ResourceSpec"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ResourceSpec> ResourceSpecSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ResourceSpec>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RibbonCustomization"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RibbonCustomization> RibbonCustomizationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RibbonCustomization>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Role"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Role> RoleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Role>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RolePrivileges"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RolePrivileges> RolePrivilegesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RolePrivileges>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RoleTemplatePrivileges"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RoleTemplatePrivileges> RoleTemplatePrivilegesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RoleTemplatePrivileges>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RollupField"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RollupField> RollupFieldSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RollupField>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RoutingRule"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RoutingRule> RoutingRuleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RoutingRule>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.RoutingRuleItem"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.RoutingRuleItem> RoutingRuleItemSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.RoutingRuleItem>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SalesLiterature"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SalesLiterature> SalesLiteratureSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SalesLiterature>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SalesLiteratureItem"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SalesLiteratureItem> SalesLiteratureItemSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SalesLiteratureItem>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SalesOrder"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SalesOrder> SalesOrderSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SalesOrder>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SalesOrderDetail"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SalesOrderDetail> SalesOrderDetailSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SalesOrderDetail>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SavedOrgInsightsConfiguration"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SavedOrgInsightsConfiguration> SavedOrgInsightsConfigurationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SavedOrgInsightsConfiguration>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SavedQuery"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SavedQuery> SavedQuerySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SavedQuery>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SavedQueryVisualization"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SavedQueryVisualization> SavedQueryVisualizationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SavedQueryVisualization>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SdkMessage"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SdkMessage> SdkMessageSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SdkMessage>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SdkMessageFilter"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SdkMessageFilter> SdkMessageFilterSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SdkMessageFilter>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SdkMessagePair"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SdkMessagePair> SdkMessagePairSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SdkMessagePair>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SdkMessageProcessingStep"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SdkMessageProcessingStep> SdkMessageProcessingStepSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SdkMessageProcessingStep>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SdkMessageProcessingStepImage"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SdkMessageProcessingStepImage> SdkMessageProcessingStepImageSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SdkMessageProcessingStepImage>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SdkMessageProcessingStepSecureConfig"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SdkMessageProcessingStepSecureConfig> SdkMessageProcessingStepSecureConfigSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SdkMessageProcessingStepSecureConfig>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SdkMessageRequest"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SdkMessageRequest> SdkMessageRequestSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SdkMessageRequest>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SdkMessageRequestField"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SdkMessageRequestField> SdkMessageRequestFieldSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SdkMessageRequestField>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SdkMessageResponse"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SdkMessageResponse> SdkMessageResponseSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SdkMessageResponse>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SdkMessageResponseField"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SdkMessageResponseField> SdkMessageResponseFieldSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SdkMessageResponseField>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SemiAnnualFiscalCalendar"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SemiAnnualFiscalCalendar> SemiAnnualFiscalCalendarSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SemiAnnualFiscalCalendar>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Service"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Service> ServiceSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Service>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ServiceAppointment"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ServiceAppointment> ServiceAppointmentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ServiceAppointment>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ServiceContractContacts"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ServiceContractContacts> ServiceContractContactsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ServiceContractContacts>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.ServiceEndpoint"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.ServiceEndpoint> ServiceEndpointSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.ServiceEndpoint>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SharePointData"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SharePointData> SharePointDataSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SharePointData>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SharePointDocument"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SharePointDocument> SharePointDocumentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SharePointDocument>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SharePointDocumentLocation"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SharePointDocumentLocation> SharePointDocumentLocationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SharePointDocumentLocation>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SharePointSite"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SharePointSite> SharePointSiteSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SharePointSite>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Site"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Site> SiteSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Site>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SiteMap"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SiteMap> SiteMapSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SiteMap>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SLA"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SLA> SLASet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SLA>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SLAItem"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SLAItem> SLAItemSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SLAItem>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SLAKPIInstance"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SLAKPIInstance> SLAKPIInstanceSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SLAKPIInstance>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SocialActivity"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SocialActivity> SocialActivitySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SocialActivity>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SocialInsightsConfiguration"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SocialInsightsConfiguration> SocialInsightsConfigurationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SocialInsightsConfiguration>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SocialProfile"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SocialProfile> SocialProfileSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SocialProfile>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Solution"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Solution> SolutionSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Solution>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SolutionComponent"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SolutionComponent> SolutionComponentSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SolutionComponent>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Subject"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Subject> SubjectSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Subject>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SubscriptionManuallyTrackedObject"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SubscriptionManuallyTrackedObject> SubscriptionManuallyTrackedObjectSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SubscriptionManuallyTrackedObject>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SubscriptionTrackingDeletedObject"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SubscriptionTrackingDeletedObject> SubscriptionTrackingDeletedObjectSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SubscriptionTrackingDeletedObject>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SuggestionCardTemplate"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SuggestionCardTemplate> SuggestionCardTemplateSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SuggestionCardTemplate>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SyncError"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SyncError> SyncErrorSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SyncError>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SystemForm"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SystemForm> SystemFormSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SystemForm>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SystemUser"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SystemUser> SystemUserSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SystemUser>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SystemUserLicenses"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SystemUserLicenses> SystemUserLicensesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SystemUserLicenses>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SystemUserProfiles"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SystemUserProfiles> SystemUserProfilesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SystemUserProfiles>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SystemUserRoles"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SystemUserRoles> SystemUserRolesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SystemUserRoles>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.SystemUserSyncMappingProfiles"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.SystemUserSyncMappingProfiles> SystemUserSyncMappingProfilesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.SystemUserSyncMappingProfiles>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Task"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Task> TaskSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Task>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Team"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Team> TeamSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Team>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TeamMembership"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TeamMembership> TeamMembershipSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TeamMembership>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TeamProfiles"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TeamProfiles> TeamProfilesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TeamProfiles>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TeamRoles"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TeamRoles> TeamRolesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TeamRoles>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TeamSyncAttributeMappingProfiles"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TeamSyncAttributeMappingProfiles> TeamSyncAttributeMappingProfilesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TeamSyncAttributeMappingProfiles>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TeamTemplate"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TeamTemplate> TeamTemplateSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TeamTemplate>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Template"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Template> TemplateSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Template>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Territory"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Territory> TerritorySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Territory>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TextAnalyticsEntityMapping"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TextAnalyticsEntityMapping> TextAnalyticsEntityMappingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TextAnalyticsEntityMapping>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Theme"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Theme> ThemeSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Theme>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TimeZoneDefinition"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TimeZoneDefinition> TimeZoneDefinitionSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TimeZoneDefinition>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TimeZoneLocalizedName"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TimeZoneLocalizedName> TimeZoneLocalizedNameSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TimeZoneLocalizedName>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TimeZoneRule"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TimeZoneRule> TimeZoneRuleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TimeZoneRule>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Topic"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Topic> TopicSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Topic>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TopicHistory"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TopicHistory> TopicHistorySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TopicHistory>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TopicModel"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TopicModel> TopicModelSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TopicModel>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TopicModelConfiguration"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TopicModelConfiguration> TopicModelConfigurationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TopicModelConfiguration>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TopicModelExecutionHistory"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TopicModelExecutionHistory> TopicModelExecutionHistorySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TopicModelExecutionHistory>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TraceLog"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TraceLog> TraceLogSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TraceLog>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TransactionCurrency"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TransactionCurrency> TransactionCurrencySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TransactionCurrency>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TransformationMapping"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TransformationMapping> TransformationMappingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TransformationMapping>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TransformationParameterMapping"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TransformationParameterMapping> TransformationParameterMappingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TransformationParameterMapping>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.TranslationProcess"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.TranslationProcess> TranslationProcessSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.TranslationProcess>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.UoM"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.UoM> UoMSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.UoM>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.UoMSchedule"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.UoMSchedule> UoMScheduleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.UoMSchedule>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.UserEntityInstanceData"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.UserEntityInstanceData> UserEntityInstanceDataSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.UserEntityInstanceData>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.UserEntityUISettings"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.UserEntityUISettings> UserEntityUISettingsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.UserEntityUISettings>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.UserForm"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.UserForm> UserFormSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.UserForm>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.UserMapping"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.UserMapping> UserMappingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.UserMapping>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.UserQuery"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.UserQuery> UserQuerySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.UserQuery>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.UserQueryVisualization"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.UserQueryVisualization> UserQueryVisualizationSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.UserQueryVisualization>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.UserSettings"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.UserSettings> UserSettingsSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.UserSettings>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.WebResource"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.WebResource> WebResourceSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.WebResource>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.Workflow"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.Workflow> WorkflowSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.Workflow>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.WorkflowDependency"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.WorkflowDependency> WorkflowDependencySet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.WorkflowDependency>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Common.Entities.WorkflowLog"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Common.Entities.WorkflowLog> WorkflowLogSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<Common.Entities.WorkflowLog>();
			}
		}
	}
	
	//internal sealed class EntityOptionSetEnum
	//{
		
	//	[System.Diagnostics.DebuggerNonUserCode()]
	//	public static System.Nullable<int> GetEnum(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName)
	//	{
	//		if (entity.Attributes.ContainsKey(attributeLogicalName))
	//		{
	//			Microsoft.Xrm.Sdk.OptionSetValue value = entity.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>(attributeLogicalName);
	//			if (value != null)
	//			{
	//				return value.Value;
	//			}
	//		}
	//		return null;
	//	}
	//}
}