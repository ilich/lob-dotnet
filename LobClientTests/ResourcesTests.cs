using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lob.Tests
{
    [TestFixture]
    public class ResourcesTests : LobClientTests
    {
        [Test]
        public async Task GetCountries()
        {
            var countries = await LobClient.Resources.GetCountriesAsync();
            Assert.Greater(countries.Count(), 0);

            var usa = countries.First(c => c.ShortName == "US");
            Assert.AreEqual("United States", usa.Name);
            Assert.AreEqual("US", usa.ShortName);
            Assert.AreEqual("country", usa.Object);
        }
    }
}
