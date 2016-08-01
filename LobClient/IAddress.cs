using System.Threading.Tasks;
using Lob.Requests;
using Lob.Responses;

namespace Lob
{
    public interface IAddress
    {
        Task<AddressVerificationResponse> VerifyAsync(AddressVerificationRequest address);
    }
}
