using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GusData.Model
{
    public class Section
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nazwa")]
        public string Name { get; set; }
        [JsonProperty("id-nadrzedny-element")]
        public int IdTopElement { get; set; }
        [JsonProperty("id-poziom")]
        public int IdLevel { get; set; }
        [JsonProperty("nazwa-poziom")]
        public string NameOfLevel { get; set; }
        [JsonProperty("czy-zmienne")]
        public bool IsChangable { get; set; }
    }
}
