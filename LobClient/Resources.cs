﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Lob.Responses;

namespace Lob
{
    class Resources : ApiBase, IResources
    {
        public Resources(ILobClient client)
            : base(client)
        {
        }

        public async Task<IEnumerable<Country>> GetCountriesAsync()
        {
            var countries = await Get<CountriesResponse>("countries");
            return countries.Countries ?? new Country[0];
        }

        public async Task<IEnumerable<State>> GetStatesAsync()
        {
            var states = await Get<StatesResponse>("states");
            return states.States ?? new State[0];
        }
    }
}
