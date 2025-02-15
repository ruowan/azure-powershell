// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Script block of scripts.
    /// </summary>
    public partial class ScriptActivityScriptBlock
    {
        /// <summary>
        /// Initializes a new instance of the ScriptActivityScriptBlock class.
        /// </summary>
        public ScriptActivityScriptBlock()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScriptActivityScriptBlock class.
        /// </summary>

        /// <param name="text">The query text. Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="type">The type of the query. Type: string.
        /// Possible values include: &#39;Query&#39;, &#39;NonQuery&#39;</param>

        /// <param name="parameters">Array of script parameters. Type: array.
        /// </param>
        public ScriptActivityScriptBlock(object text, string type, System.Collections.Generic.IList<ScriptActivityParameter> parameters = default(System.Collections.Generic.IList<ScriptActivityParameter>))

        {
            this.Text = text;
            this.Type = type;
            this.Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the query text. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "text")]
        public object Text {get; set; }

        /// <summary>
        /// Gets or sets the type of the query. Type: string. Possible values include: &#39;Query&#39;, &#39;NonQuery&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; set; }

        /// <summary>
        /// Gets or sets array of script parameters. Type: array.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.IList<ScriptActivityParameter> Parameters {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Text == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Text");
            }
            if (this.Type == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Type");
            }



        }
    }
}