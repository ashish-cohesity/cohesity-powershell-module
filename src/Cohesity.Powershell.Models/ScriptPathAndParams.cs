// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the path to the remote script and any parameters expected by the remote script.
    /// </summary>
    [DataContract]
    public partial class ScriptPathAndParams :  IEquatable<ScriptPathAndParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptPathAndParams" /> class.
        /// </summary>
        /// <param name="scriptParams">Specifies the parameters and values to pass into the remote script. For example if the script expects values for the &#39;database&#39; and &#39;user&#39; parameters, specify the parameters and values using the following string: \&quot;database&#x3D;myDatabase user&#x3D;me\&quot;..</param>
        /// <param name="scriptPath">Specifies the path to the script on the remote host..</param>
        public ScriptPathAndParams(string scriptParams = default(string), string scriptPath = default(string))
        {
            this.ScriptParams = scriptParams;
            this.ScriptPath = scriptPath;
        }
        
        /// <summary>
        /// Specifies the parameters and values to pass into the remote script. For example if the script expects values for the &#39;database&#39; and &#39;user&#39; parameters, specify the parameters and values using the following string: \&quot;database&#x3D;myDatabase user&#x3D;me\&quot;.
        /// </summary>
        /// <value>Specifies the parameters and values to pass into the remote script. For example if the script expects values for the &#39;database&#39; and &#39;user&#39; parameters, specify the parameters and values using the following string: \&quot;database&#x3D;myDatabase user&#x3D;me\&quot;.</value>
        [DataMember(Name="scriptParams", EmitDefaultValue=false)]
        public string ScriptParams { get; set; }

        /// <summary>
        /// Specifies the path to the script on the remote host.
        /// </summary>
        /// <value>Specifies the path to the script on the remote host.</value>
        [DataMember(Name="scriptPath", EmitDefaultValue=false)]
        public string ScriptPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as ScriptPathAndParams);
        }

        /// <summary>
        /// Returns true if ScriptPathAndParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ScriptPathAndParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScriptPathAndParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScriptParams == input.ScriptParams ||
                    (this.ScriptParams != null &&
                    this.ScriptParams.Equals(input.ScriptParams))
                ) && 
                (
                    this.ScriptPath == input.ScriptPath ||
                    (this.ScriptPath != null &&
                    this.ScriptPath.Equals(input.ScriptPath))
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
                if (this.ScriptParams != null)
                    hashCode = hashCode * 59 + this.ScriptParams.GetHashCode();
                if (this.ScriptPath != null)
                    hashCode = hashCode * 59 + this.ScriptPath.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

