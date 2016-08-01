using Newtonsoft.Json;

namespace Lob.Responses
{
    class CountriesResponse
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("data")]
        public Country[] Countries { get; set; }
    }

    public class Country
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }
    }
}
