using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Lob.Serialization;
using Newtonsoft.Json;

namespace Lob
{
    abstract class ApiBase
    {
        private const string ApiEndpoint = "https://api.lob.com/v1/";
        //private const string ApiEndpoint = "http://localhost:9000/";

        private readonly ILobClient lobClient;

        private readonly FormUrlEncodedContentSerializer serializer = new FormUrlEncodedContentSerializer();

        public ApiBase(ILobClient lobClient)
        {
            this.lobClient = lobClient;
        }

        protected async Task<T> Post<T, U>(string requestUri, U request)
        {
            using (var client = new HttpClient())
            {
                SetupClient(client);

                var content = serializer.Serialize(request);
                var response = await client.PostAsync(requestUri, content);
                var statusCode = (int)response.StatusCode;
                if (statusCode == 200)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<T>(json);
                    return result;
                }
                else
                {
                    throw new LobClientException(
                        response.RequestMessage.RequestUri, 
                        statusCode,  
                        response.ReasonPhrase);
                }
            }
        }

        private void SetupClient(HttpClient client)
        {
            client.BaseAddress = new Uri(ApiEndpoint);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var authToken = Convert.ToBase64String(Encoding.Default.GetBytes(lobClient.ApiKey + ":"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

            if (!string.IsNullOrEmpty(lobClient.ApiVersion))
            {
                client.DefaultRequestHeaders.Add("Lob-Version", lobClient.ApiVersion);
            }

            client.DefaultRequestHeaders.Add("User-Agent", "Lob/v1 .NET/1.0.0.0");
        }
    }
}
