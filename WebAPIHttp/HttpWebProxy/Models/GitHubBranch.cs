using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpWebProxy.Models
{
    public class GitHubBranch
    {
        [JsonPropertyName ("name")]
        public string Name { get; set; }
    }
}