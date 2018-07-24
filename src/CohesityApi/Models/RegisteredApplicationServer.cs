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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies an Application Server and the Protection Source that registered the Application Server.
    /// </summary>
    [DataContract]
    public partial class RegisteredApplicationServer :  IEquatable<RegisteredApplicationServer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisteredApplicationServer" /> class.
        /// </summary>
        /// <param name="applicationServer">applicationServer.</param>
        /// <param name="registeredProtectionSource">registeredProtectionSource.</param>
        public RegisteredApplicationServer(ApplicationServerAndTheSubtreesBelowThem_ applicationServer = default(ApplicationServerAndTheSubtreesBelowThem_), ProtectionSource4 registeredProtectionSource = default(ProtectionSource4))
        {
            this.ApplicationServer = applicationServer;
            this.RegisteredProtectionSource = registeredProtectionSource;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationServer
        /// </summary>
        [DataMember(Name="applicationServer", EmitDefaultValue=false)]
        public ApplicationServerAndTheSubtreesBelowThem_ ApplicationServer { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredProtectionSource
        /// </summary>
        [DataMember(Name="registeredProtectionSource", EmitDefaultValue=false)]
        public ProtectionSource4 RegisteredProtectionSource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisteredApplicationServer {\n");
            sb.Append("  ApplicationServer: ").Append(ApplicationServer).Append("\n");
            sb.Append("  RegisteredProtectionSource: ").Append(RegisteredProtectionSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisteredApplicationServer);
        }

        /// <summary>
        /// Returns true if RegisteredApplicationServer instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisteredApplicationServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisteredApplicationServer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationServer == input.ApplicationServer ||
                    (this.ApplicationServer != null &&
                    this.ApplicationServer.Equals(input.ApplicationServer))
                ) && 
                (
                    this.RegisteredProtectionSource == input.RegisteredProtectionSource ||
                    (this.RegisteredProtectionSource != null &&
                    this.RegisteredProtectionSource.Equals(input.RegisteredProtectionSource))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ApplicationServer != null)
                    hashCode = hashCode * 59 + this.ApplicationServer.GetHashCode();
                if (this.RegisteredProtectionSource != null)
                    hashCode = hashCode * 59 + this.RegisteredProtectionSource.GetHashCode();
                return hashCode;
            }
        }

        
    }

}