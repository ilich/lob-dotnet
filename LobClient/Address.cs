using System.Threading.Tasks;
using Lob.Requests;
using Lob.Responses;

namespace Lob
{
    class Address : ApiBase, IAddress
    {
        public Address(ILobClient client)
            : base(client)
        {
        }

        public async Task<AddressVerificationResponse> VerifyAsync(AddressVerificationRequest address)
        {
            return await Post<AddressVerificationResponse, AddressVerificationRequest>("verify", address);
        }
    }
}
