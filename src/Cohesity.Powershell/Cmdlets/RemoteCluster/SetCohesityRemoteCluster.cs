﻿// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.RemoteCluster
{
    /// <summary>
    /// <para type="synopsis">
    /// Updates a remote cluster registered with the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Returns the updated remote cluster.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesityRemoteCluster -RemoteCluster $remoteCluster
    ///   </code>
    ///   <para>
    ///   Updates a remote cluster with the specified parameters.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Set, "CohesityRemoteCluster")]
    [OutputType(typeof(Models.RemoteCluster))]
    public class SetCohesityRemoteCluster : PSCmdlet
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
        /// The updated remote cluster.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        public Models.RemoteCluster RemoteCluster { get; set; } = null;

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
            // PUT public/remoteClusters/{id}
            var preparedUrl = $"/public/remoteClusters/{RemoteCluster.ClusterId.ToString()}";
            var result = Session.ApiClient.Put<Models.RemoteCluster>(preparedUrl, RemoteCluster);
            WriteObject(result);
        }

        #endregion

    }
}
