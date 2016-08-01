namespace Lob
{
    public class LobClient : ILobClient
    {
        private const string DefaultApiVersion = "2016-06-30";

        public LobClient(string apiKey, string apiVersion = DefaultApiVersion)
        {
            ApiKey = apiKey;
            ApiVersion = ApiVersion;
        }

        public IAddress Address => new Address(this);

        public string ApiKey { get; set; }

        public string ApiVersion { get; set; }
    }
}
