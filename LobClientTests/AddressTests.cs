using System.Configuration;
using System.Threading.Tasks;
using Lob.Requests;
using NUnit.Framework;

namespace Lob.Tests
{
    [TestFixture]
    public class AddressTests : LobClientTests
    {
        [Test]
        public async Task VerifyAddress()
        {
            var response = await LobClient.Address.VerifyAsync(new AddressVerificationRequest
            {
                AddressLine1 = "185 Berry Street",
                City = "San Francisco",
                State = "CA",
                Zip = "94107"
            });

            var address = response.Address;
            Assert.AreEqual("185 BERRY ST", address.AddressLine1);
            Assert.AreEqual("", address.AddressLine2);
            Assert.AreEqual("SAN FRANCISCO", address.City);
            Assert.AreEqual("CA", address.State);
            Assert.AreEqual("94107-5705", address.Zip);
            Assert.AreEqual("address", address.Object);
            Assert.AreEqual("US", address.Country);
        }
    }
}
