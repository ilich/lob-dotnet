using System.Configuration;
using NUnit.Framework;

namespace Lob.Tests
{
    public abstract class LobClientTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            var apiKey = ConfigurationManager.AppSettings["ApiKey"];
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ConfigurationErrorsException("ApiKey");
            }

            var apiVersion = ConfigurationManager.AppSettings["ApiVersion"];
            if (string.IsNullOrEmpty(apiVersion))
            {
                throw new ConfigurationErrorsException("ApiVersion");
            }

            LobClient = new LobClient(apiKey, apiVersion);
        }

        protected ILobClient LobClient { get; private set; }
    }
}
