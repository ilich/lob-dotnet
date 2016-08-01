namespace Lob
{
    public class LobClient : ILobClient
    {
        public LobClient(string apiKey, string apiVersion = "")
        {
            ApiKey = apiKey;
            ApiVersion = ApiVersion;
        }

        public IAddress Address => new Address(this);

        public IResources Resources => new Resources(this);

        public string ApiKey { get; set; }

        public string ApiVersion { get; set; }
    }
}
