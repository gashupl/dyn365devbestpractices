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
	/// Stores data regarding Mailbox processing cycles
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("mailboxstatistics")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class MailboxStatistics : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AsyncEventId = "asynceventid";
			public const string CrmItemsBacklog = "crmitemsbacklog";
			public const string IndividualStepDurations = "individualstepdurations";
			public const string ItemsFailed = "itemsfailed";
			public const string ItemsProcessed = "itemsprocessed";
			public const string MachineName = "machinename";
			public const string MailboxId = "mailboxid";
			public const string MailboxProcessCompletedOn = "mailboxprocesscompletedon";
			public const string MailboxProcessScheduledOn = "mailboxprocessscheduledon";
			public const string MailboxProcessStartedOn = "mailboxprocessstartedon";
			public const string MailboxStatisticsId = "mailboxstatisticsid";
			public const string Id = "mailboxstatisticsid";
			public const string OperationTypeId = "operationtypeid";
			public const string OrganizationId = "organizationid";
			public const string ProcessResult = "processresult";
			public const string ProcessTimeIntervalInMinutes = "processtimeintervalinminutes";
			public const string ScheduledTimeIntervalInMinutes = "scheduledtimeintervalinminutes";
			public const string mailbox_mailboxstatistics = "mailbox_mailboxstatistics";
			public const string organization_mailboxstatistics = "organization_mailboxstatistics";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public MailboxStatistics() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "mailboxstatistics";
		
		public const string PrimaryIdAttribute = "mailboxstatisticsid";
		
		public const int EntityTypeCode = 9607;
		
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
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asynceventid")]
		public System.Nullable<System.Guid> AsyncEventId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("asynceventid");
			}
		}
		
		/// <summary>
		/// Items remaining in CRM to process after this synchronization cycle.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crmitemsbacklog")]
		public System.Nullable<int> CrmItemsBacklog
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("crmitemsbacklog");
			}
		}
		
		/// <summary>
		/// Time each exchange sync step is taking
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("individualstepdurations")]
		public string IndividualStepDurations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("individualstepdurations");
			}
		}
		
		/// <summary>
		/// Number of items processed unsuccessfully.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("itemsfailed")]
		public System.Nullable<int> ItemsFailed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("itemsfailed");
			}
		}
		
		/// <summary>
		/// Number of items processed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("itemsprocessed")]
		public System.Nullable<int> ItemsProcessed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("itemsprocessed");
			}
		}
		
		/// <summary>
		/// Name of Machine on which mailbox was processed
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("machinename")]
		public string MachineName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("machinename");
			}
		}
		
		/// <summary>
		/// Regarding Mailbox.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailboxid")]
		public Microsoft.Xrm.Sdk.EntityReference MailboxId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("mailboxid");
			}
		}
		
		/// <summary>
		/// Completion time of the synchronization cycle.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailboxprocesscompletedon")]
		public System.Nullable<System.DateTime> MailboxProcessCompletedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("mailboxprocesscompletedon");
			}
		}
		
		/// <summary>
		/// Scheduled time of the synchronization cycle.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailboxprocessscheduledon")]
		public System.Nullable<System.DateTime> MailboxProcessScheduledOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("mailboxprocessscheduledon");
			}
		}
		
		/// <summary>
		/// Start time of the synchronization cycle.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailboxprocessstartedon")]
		public System.Nullable<System.DateTime> MailboxProcessStartedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("mailboxprocessstartedon");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailboxstatisticsid")]
		public System.Nullable<System.Guid> MailboxStatisticsId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("mailboxstatisticsid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailboxstatisticsid")]
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
				base.Id = value;
			}
		}
		
		/// <summary>
		/// Type of the mailbox operation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operationtypeid")]
		public Microsoft.Xrm.Sdk.OptionSetValue OperationTypeId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("operationtypeid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the record.
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
		/// Result of Mailbox processing cycle
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processresult")]
		public System.Nullable<bool> ProcessResult
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("processresult");
			}
		}
		
		/// <summary>
		/// Time it took to process the mailbox.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processtimeintervalinminutes")]
		public System.Nullable<int> ProcessTimeIntervalInMinutes
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("processtimeintervalinminutes");
			}
		}
		
		/// <summary>
		/// Time it took from the scheduled time to the actual start time to process the mailbox.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledtimeintervalinminutes")]
		public System.Nullable<int> ScheduledTimeIntervalInMinutes
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("scheduledtimeintervalinminutes");
			}
		}
		
		/// <summary>
		/// N:1 mailbox_mailboxstatistics
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailboxid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("mailbox_mailboxstatistics")]
		public Common.Entities.Mailbox mailbox_mailboxstatistics
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Mailbox>("mailbox_mailboxstatistics", null);
			}
		}
		
		/// <summary>
		/// N:1 organization_mailboxstatistics
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_mailboxstatistics")]
		public Common.Entities.Organization organization_mailboxstatistics
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Common.Entities.Organization>("organization_mailboxstatistics", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public MailboxStatistics(object anonymousType) : 
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
                        Attributes["mailboxstatisticsid"] = base.Id;
                        break;
                    case "mailboxstatisticsid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operationtypeid")]
		public virtual MailboxStatistics_OperationTypeId? OperationTypeIdEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((MailboxStatistics_OperationTypeId?)(EntityOptionSetEnum.GetEnum(this, "operationtypeid")));
			}
		}
	}
}