namespace Lob
{
    public interface ILobClient
    {
        string ApiKey { get; set; }

        string ApiVersion { get; set; }

        IAddress Address { get; }
    }
}
