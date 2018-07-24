/* 
 * Cohesity REST API
 *
 * This API provides operations for interfacing with the Cohesity Cluster. NOTE: To view the documentation on the responses, click 'Model' next to 'Example Value' and keep clicking to expand the hierarchy.
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing VaultsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VaultsApiTests
    {
        private VaultsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VaultsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VaultsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VaultsApi
            //Assert.IsInstanceOfType(typeof(VaultsApi), instance, "instance is a VaultsApi");
        }

        
        /// <summary>
        /// Test CreateVault
        /// </summary>
        [Test]
        public void CreateVaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Vault body = null;
            //var response = instance.CreateVault(body);
            //Assert.IsInstanceOf<Vault> (response, "response is Vault");
        }
        
        /// <summary>
        /// Test DeleteVault
        /// </summary>
        [Test]
        public void DeleteVaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteVault(id);
            
        }
        
        /// <summary>
        /// Test GetArchiveMediaInfo
        /// </summary>
        [Test]
        public void GetArchiveMediaInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? clusterIncarnationId = null;
            //long? qstarArchiveJobId = null;
            //long? clusterId = null;
            //long? qstarRestoreTaskId = null;
            //List<long?> entityIds = null;
            //var response = instance.GetArchiveMediaInfo(clusterIncarnationId, qstarArchiveJobId, clusterId, qstarRestoreTaskId, entityIds);
            //Assert.IsInstanceOf<List<TapeMediaInformation>> (response, "response is List<TapeMediaInformation>");
        }
        
        /// <summary>
        /// Test GetVaultById
        /// </summary>
        [Test]
        public void GetVaultByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetVaultById(id);
            //Assert.IsInstanceOf<Vault> (response, "response is Vault");
        }
        
        /// <summary>
        /// Test GetVaultEncryptionKeyInfo
        /// </summary>
        [Test]
        public void GetVaultEncryptionKeyInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetVaultEncryptionKeyInfo(id);
            //Assert.IsInstanceOf<VaultEncryptionKey> (response, "response is VaultEncryptionKey");
        }
        
        /// <summary>
        /// Test GetVaults
        /// </summary>
        [Test]
        public void GetVaultsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //bool? includeMarkedForRemoval = null;
            //long? id = null;
            //var response = instance.GetVaults(name, includeMarkedForRemoval, id);
            //Assert.IsInstanceOf<List<Vault>> (response, "response is List<Vault>");
        }
        
        /// <summary>
        /// Test UpdateVault
        /// </summary>
        [Test]
        public void UpdateVaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //Vault body = null;
            //var response = instance.UpdateVault(id, body);
            //Assert.IsInstanceOf<Vault> (response, "response is Vault");
        }
        
    }

}