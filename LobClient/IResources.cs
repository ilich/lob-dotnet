using System.Collections.Generic;
using System.Threading.Tasks;
using Lob.Responses;

namespace Lob
{
    public interface IResources
    {
        Task<IEnumerable<Country>> GetCountriesAsync();

        Task<IEnumerable<State>> GetStatesAsync();
    }
}
