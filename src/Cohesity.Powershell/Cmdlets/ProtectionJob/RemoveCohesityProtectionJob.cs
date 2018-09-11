﻿using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    /// <summary>
    /// <para type="synopsis">
    /// Removes a protection job.
    /// </para>
    /// <para type="description">
    /// Returns success if the protection job is deleted.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Remove-CohesityProtectionJob -Id 1234
    ///   </code>
    ///   <para>
    ///   Removes a protection job with the Id of 1234 and all snapshots generated by the protection job.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Remove-CohesityProtectionJob -Id 1234 -DeleteSnapshots false
    ///   </code>
    ///   <para>
    ///   Removes a protection job with the Id of 1234, snapshots generated by the protection job are not deleted.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Remove, "CohesityProtectionJob", SupportsShouldProcess = true)]
    public class RemoveCohesityProtectionJob : PSCmdlet
    {
        private Session Session
        {
            get
            {
                var result = SessionState.PSVariable.GetValue("Session") as Session;
                if (result == null)
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        #region Params

        /// <summary>
        /// <para type="description">
        /// Specifies the unique id of the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        [ValidateRange(1, long.MaxValue)]
        public long Id { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies if snapshots generated by the protection job should also be deleted when the job is deleted.
        /// Default value is true.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public bool DeleteSnapshots { get; set; } = true;

        #endregion

        #region Processing

        /// <summary>
        /// Preprocess
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process
        /// </summary>
        protected override void ProcessRecord()
        {
            // POST /public/protectionJobState/{id}
            if (ShouldProcess("CohesityCluster"))
            {
                var content = new
                {
                    DeleteSnapshots
                };


                var preparedUrl = $"/public/protectionJobs/{Id.ToString()}";
                Session.NetworkClient.Delete(preparedUrl, content);
                WriteObject($"Protection job with Id {Id} was deleted successfully.");
            }

            else
            {
                WriteObject($"Protection job with Id {Id} was not deleted.");
            }
        }
        #endregion
    }
}
