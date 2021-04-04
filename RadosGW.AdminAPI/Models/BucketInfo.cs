using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Radosgw.AdminAPI.Models
{
    public class BucketInfo
    {
        [JsonProperty("bucket")]
        public string Name { get; set; }
        [JsonProperty("num_shards")]
        public int NumShards { get; set; }
        public string Tenant { get; set; }
        /// <summary>
        /// The unique bucket id.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Internal bucket tag.
        /// </summary>
        public string Marker { get; set; }
        [JsonProperty("index_type")]
        public string IndexType { get; set; }
        public string Owner { get; set; }
        [JsonProperty("ver")]
        public string Version { get; set; }
        [JsonProperty("master_ver")]
        public string MasterVersion { get; set; }
        [JsonProperty("mtime")]
        public DateTime ModifyTime { get; set; }
        [JsonProperty("creation_time")]
        public DateTime CreationTime { get; set; }
        public Dictionary<string, UsageData> Usage { get; set; }
    }
}
