# IO.Swagger.Model.ProtectionJob
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AbortInBlackoutPeriod** | **bool?** | If true, the Cohesity Cluster aborts any currently executing Job Runs of this Protection Job when a blackout period specified for this Job starts, even if the Job Run started before the blackout period began. If false, a Job Run continues to execute, if the Job Run started before the blackout period starts. | [optional] 
**AlertingPolicy** | **List&lt;string&gt;** | During Job Runs, the following Job Events are generated: 1) Job succeeds 2) Job fails 3) Job violates the SLA These Job Events can cause Alerts to be generated. &#39;kSuccess&#39; means the Protection Job succeeded. &#39;kFailure&#39; means the Protection Job failed. &#39;kSlaViolation&#39; means the Protection Job took longer than the time period specified in the SLA. | [optional] 
**CloudParameters** | [**CloudParameters**](CloudParameters.md) | Specifies Cloud specific parameters applicable in various scenarios. | [optional] 
**CreationTimeUsecs** | **long?** | Specifies the time when the Protection Job was created. | [optional] 
**Description** | **string** | Specifies a text description about the Protection Job. | [optional] 
**EndTimeUsecs** | **long?** | Specifies the epoch time (in microseconds) after which the Protection Job becomes dormant. | [optional] 
**Environment** | **string** | Specifies the environment type (such as kVMware or kSQL) of the Protection Source this Job is protecting. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
**EnvironmentParameters** | [**EnvironmentTypeJobParameters**](EnvironmentTypeJobParameters.md) | Specifies additional settings that are applicable to all Sources in the Protection Job that are of specified environment type. For example, you can specify to exclude a disk from backup for all &#39;kVMware&#39; Protection Sources in the Protection Job. If a setting conflicts with sourceSpecialParameters, then sourceSpecialParameters will be used. | [optional] 
**ExcludeSourceIds** | **List&lt;long?&gt;** | List of Object ids from a Protection Source that should not be protected and are excluded from being backed up by the Protection Job. Leaf and non-leaf Objects may be in this list and an Object in this list must have an ancestor in the sourceId list. | [optional] 
**ExcludeVmTagIds** | **List&lt;List&lt;long?&gt;&gt;** | Optionally specify a list of VMs to exclude from protecting by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to exclude from protecting, which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. For example a Datacenter is selected to be protected but you want to exclude all the &#39;Former Employees&#39; VMs in the East and West but keep all the VMs for &#39;Former Employees&#39; in the South which are also stored in this Datacenter, by specifying the following tag id array: [ [1000, 2221], [1000, 3031] ], where 1000 is the &#39;Former Employee&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The first inner array [1000, 2221] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;East&#39; (an intersection). The second inner array [1000, 3031] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;West&#39; (an intersection). The outer array combines the list of VMs from the two inner arrays. The list of resulting VMs are excluded from being protected this Job. | [optional] 
**FullProtectionSlaTimeMins** | **long?** | If specified, this setting is number of minutes that a Job Run of a Full (no CBT) backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule. | [optional] 
**FullProtectionStartTime** | [**FullNoCBTProtectionScheduleStartTime_**](FullNoCBTProtectionScheduleStartTime_.md) |  | [optional] 
**Id** | **long?** | Specifies an id for the Protection Job. | [optional] 
**IncrementalProtectionSlaTimeMins** | **long?** | If specified, this setting is number of minutes that a Job Run of a CBT-based backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule. | [optional] 
**IncrementalProtectionStartTime** | [**CBTbasedProtectionScheduleStartTime_**](CBTbasedProtectionScheduleStartTime_.md) |  | [optional] 
**IndexingPolicy** | [**IndexingPolicy**](IndexingPolicy.md) | Specifies the settings for indexing files found in an Object (such as a VM) so these files can be searched and recovered. In addition, it specifies inclusion and exclusion rules that determine the directories to index. | [optional] 
**IsActive** | **bool?** | Indicates if the current state of the Protection Job is Active or Inactive. When you create a Protection Job on a Primary Cluster with a replication schedule, the Cohesity Cluster creates an Inactive copy of the Job on the Remote Cluster. In addition, when an Active and running Job is deactivated, the Job becomes Inactive. | [optional] 
**IsDeleted** | **bool?** | Equals &#39;true&#39; if the Protection Job was deleted but some Snapshots are still associated with this Job. If &#39;true&#39;, no new Job Runs are started by this Protection Job. | [optional] 
**IsPaused** | **bool?** | Indicates if the Protection Job is paused, which means that no new Job Runs are started but any existing Job Runs continue to execute. | [optional] 
**LastRun** | [**ProtectionRunInstance**](ProtectionRunInstance.md) | Specifies the last run of the Protection Job if any. This field is set only if it was requested. | [optional] 
**LeverageStorageSnapshots** | **bool?** | Specifies whether to leverage the storage array based snapshots for this backup job. To leverage storage snapshots, the storage array has to be registered as a source. If storage based snapshots can not be taken, job will fallback to the default backup method. | [optional] 
**ModificationTimeUsecs** | **long?** | Specifies the last time this Job was updated. | [optional] 
**ModifiedByUser** | **string** | Specifies the last Cohesity user who updated this Job. | [optional] 
**Name** | **string** | Specifies the name of the Protection Job. | 
**ParentSourceId** | **long?** | Specifies the id of the registered Protection Source that is the parent of the Objects that may be protected by this Job. For example when a vCenter Server is registered on a Cohesity Cluster, the Cohesity Cluster assigns a unique id to this field that represents the vCenter Server. | [optional] 
**PolicyAppliedTimeMsecs** | **long?** | Specifies the epoch time (in milliseconds) when the associated Policy was last applied to this Job. This is used to determine if the Policy has changed since it was last applied to this Job. | [optional] 
**PolicyId** | **string** | Specifies the unique id of the Protection Policy associated with the Protection Job. The Policy provides retry settings, Protection Schedules, Priority, SLA, etc. The Job defines the Storage Domain (View Box), the Objects to Protect (if applicable), Start Time, Indexing settings, etc. | 
**Priority** | **string** | Specifies the priority of execution for a Protection Job. Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority. This field also specifies the replication priority. | [optional] 
**QosType** | **string** | Specifies the QoS policy type to use for this Protection Job. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs. | [optional] 
**Quiesce** | **bool?** | Indicates if the App-Consistent option is enabled for this Job. If the option is enabled, the Cohesity Cluster quiesces the file system and applications before taking Application-Consistent Snapshots. VMware Tools must be installed on the guest Operating System. | [optional] 
**RemoteScript** | [**RemoteAdapter_**](RemoteAdapter_.md) |  | [optional] 
**SourceIds** | **List&lt;long?&gt;** | Specifies the list of Object ids from the Protection Source to protect (or back up) by the Protection Job. An Object in this list may be descendant of another Object in this list. For example a Datacenter could be selected but its child Host excluded. However, a child VM under the Host could be explicitly selected to be protected. Both the Datacenter and the VM are listed. | [optional] 
**SourceSpecialParameters** | [**List&lt;SourceSpecialParameter&gt;**](SourceSpecialParameter.md) | Specifies additional settings that can apply to a subset of the Sources listed in the Protection Job. For example, you can specify a list of files and folders to protect instead of protecting the entire Physical Server. If this field&#39;s setting conflicts with environmentParameters, then this setting will be used. | [optional] 
**StartTime** | [**ProtectionScheduleStartTime_**](ProtectionScheduleStartTime_.md) |  | [optional] 
**SummaryStats** | [**ProtectionJobSummaryStats**](ProtectionJobSummaryStats.md) | Specifies the summary stats of the Protection Job. This field is set only if it was requested. | [optional] 
**Timezone** | **string** | Specifies the timezone to use when calculating time for this Protection Job such as the Job start time. Specify the timezone in the following format: \&quot;Area/Location\&quot;, for example: \&quot;America/New_York\&quot;. | [optional] 
**Uid** | [**UniqueGlobalId5**](UniqueGlobalId5.md) |  | [optional] 
**ViewBoxId** | **long?** | Specifies the Storage Domain (View Box) id where this Job writes data. | 
**ViewName** | **string** | For a Remote Adapter &#39;kPuppeteer&#39; Job or a &#39;kView&#39; Job, this field specifies a View name that should be protected. Specify this field when creating a Protection Job for the first time for a View. If this field is specified, ParentSourceId, SourceIds, and ExcludeSourceIds should not be specified. | [optional] 
**VmTagIds** | **List&lt;List&lt;long?&gt;&gt;** | Optionally specify a list of VMs to protect by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to protect which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. To protect only &#39;Eng&#39; VMs in the East and all the VMs in the West, specify the following tag id array: [ [1101, 2221], [3031] ], where 1101 is the &#39;Eng&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The inner array [1101, 2221] produces a list of VMs that are both tagged with &#39;Eng&#39; and &#39;East&#39; (an intersection). The outer array combines the list from the inner array with list of VMs tagged with &#39;West&#39; (a union). The list of resulting VMs are protected by this Job. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
