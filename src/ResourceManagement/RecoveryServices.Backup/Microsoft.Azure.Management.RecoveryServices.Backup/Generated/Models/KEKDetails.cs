// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// KEK is encryption key for BEK.
    /// </summary>
    public partial class KEKDetails
    {
        /// <summary>
        /// Initializes a new instance of the KEKDetails class.
        /// </summary>
        public KEKDetails() { }

        /// <summary>
        /// Initializes a new instance of the KEKDetails class.
        /// </summary>
        /// <param name="keyUrl">Key is KEK.</param>
        /// <param name="keyVaultId">Key Vault ID where this Key is
        /// stored.</param>
        /// <param name="keyBackupData">KEK data.</param>
        public KEKDetails(string keyUrl = default(string), string keyVaultId = default(string), string keyBackupData = default(string))
        {
            KeyUrl = keyUrl;
            KeyVaultId = keyVaultId;
            KeyBackupData = keyBackupData;
        }

        /// <summary>
        /// Gets or sets key is KEK.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyUrl")]
        public string KeyUrl { get; set; }

        /// <summary>
        /// Gets or sets key Vault ID where this Key is stored.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultId")]
        public string KeyVaultId { get; set; }

        /// <summary>
        /// Gets or sets KEK data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyBackupData")]
        public string KeyBackupData { get; set; }

    }
}
