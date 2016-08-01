using Newtonsoft.Json;

namespace Lob.Responses
{
    public sealed class AddressVerificationResponse
    {
        [JsonProperty("address")]
        public VerifiedAddress Address { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public sealed class VerifiedAddress
    {
        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("address_city")]
        public string City { get; set; }

        [JsonProperty("address_state")]
        public string State { get; set; }

        [JsonProperty("address_zip")]
        public string Zip { get; set; }

        [JsonProperty("address_country")]
        public string Country { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }
    }
}
