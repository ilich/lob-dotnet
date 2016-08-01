using Lob.Requests;
using Lob.Serialization;
using NUnit.Framework;

namespace Lob.Tests
{
    [TestFixture]
    class FormUrlEncodedContentSerializerTests
    {
        [Test]
        public void FormUrlSerialization()
        {
            var addess = new AddressVerificationRequest
            {
                AddressLine1 = "9700 France Ave S",
                AddressLine2 = "#20",
                City = "Bloomington",
                State = "MN",
                Zip = "55431",
                Country = "US"
            };

            var serializer = new FormUrlEncodedContentSerializer();
            var request = serializer.Convert(addess);

            Assert.AreEqual(request["address_line1"], "9700 France Ave S");
            Assert.AreEqual(request["address_line2"], "#20");
            Assert.AreEqual(request["address_city"], "Bloomington");
            Assert.AreEqual(request["address_state"], "MN");
            Assert.AreEqual(request["address_zip"], "55431");
            Assert.AreEqual(request["address_country"], "US");
        }
    }
}
