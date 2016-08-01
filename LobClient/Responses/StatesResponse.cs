using Newtonsoft.Json;

namespace Lob.Responses
{
    class StatesResponse
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("data")]
        public State[] States { get; set; }
    }

    public class State
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }
    }
}
