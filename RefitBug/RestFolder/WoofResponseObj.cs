using System;
using Newtonsoft.Json;

namespace RefitBug.RestFolder
{
    public partial class WoofResponseObject
    {
        [JsonProperty("fileSizeBytes")]
        public long FileSizeBytes { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
