// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The new connection details and the target datasource name to be
    /// updated.
    /// </summary>
    public partial class UpdateRdlDatasourceDetails
    {
        /// <summary>
        /// Initializes a new instance of the UpdateRdlDatasourceDetails class.
        /// </summary>
        public UpdateRdlDatasourceDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateRdlDatasourceDetails class.
        /// </summary>
        /// <param name="connectionDetails">The new server and database
        /// name.</param>
        /// <param name="datasourceName">The target datasource name to be
        /// updated.</param>
        public UpdateRdlDatasourceDetails(RdlDatasourceConnectionDetails connectionDetails, string datasourceName)
        {
            ConnectionDetails = connectionDetails;
            DatasourceName = datasourceName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the new server and database name.
        /// </summary>
        [JsonProperty(PropertyName = "connectionDetails")]
        public RdlDatasourceConnectionDetails ConnectionDetails { get; set; }

        /// <summary>
        /// Gets or sets the target datasource name to be updated.
        /// </summary>
        [JsonProperty(PropertyName = "datasourceName")]
        public string DatasourceName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConnectionDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionDetails");
            }
            if (DatasourceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DatasourceName");
            }
        }
    }
}
