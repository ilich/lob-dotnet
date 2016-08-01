using Lob.Serialization;

namespace Lob.Requests
{
    public sealed class AddressVerificationRequest
    {
        [FormUrl("address_line1")]
        public string AddressLine1 { get; set; }

        [FormUrl("address_line2")]
        public string AddressLine2 { get; set; }

        [FormUrl("address_city")]
        public string City { get; set; }

        [FormUrl("address_state")]
        public string State { get; set; }

        [FormUrl("address_zip")]
        public string Zip { get; set; }

        [FormUrl("address_country")]
        public string Country { get; set; }
    }
}
