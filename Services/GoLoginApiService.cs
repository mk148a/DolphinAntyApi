using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DolphinAntyApi.Models;
using GoLoginApi.Models;
using GoLoginApi.Services;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace GoLoginApiApi.Services
{
    public class GoLoginApiService
    {
        private readonly GoLoginApiClient _client;

        public GoLoginApiService(GoLoginApiClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }
        

        public async Task<CreateBrowserProfileResponse> CreateBrowserProfileAsync(CreateBrowserProfileRequest request)
        {
            // API endpoint'i belirtin
            string endpoint = "/browser";

            // DolphinAntyClient'tan PostAsync metodunu kullanarak isteği gönderin
            var httpResponse = await _client.PostAsync<CreateBrowserProfileResponse>(endpoint, request);
            return httpResponse;

        }

    

        public async Task DeleteBrowserProfileAsync(string browserProfileId)
        {
            // API endpoint'i belirtin
            string endpoint = "/browser/" + browserProfileId;

            // DolphinAntyClient'tan PostAsync metodunu kullanarak isteği gönderin
            await _client.DeleteAsync(endpoint);
           
        }
  
        public async Task<StartBrowserProfileResponse> StartBrowserProfileAsync(string browserProfileId)
        {
            // API endpoint'i belirtin
            // //browser/start-profile?profileId={{PROFILE_ID}}&sync=true, false
            string endpoint = "/browser/start-profile";
            StartBrowserProfileRequest request = new StartBrowserProfileRequest();
            request.ProfileId = browserProfileId;
            request.Sync = true;
            // DolphinAntyClient'tan PostAsync metodunu kullanarak isteği gönderin
            try
            {
                var httpResponse = (StartBrowserProfileResponse)await _client.PostAsync<StartBrowserProfileResponse>(endpoint, request);
                return httpResponse;
            }
            catch
            {
                var httpResponse = await _client.PostAsync(endpoint, request);
                StartBrowserProfileResponse failResponse = new StartBrowserProfileResponse();

                failResponse.Status = "fail";
                failResponse.WsUrl = httpResponse;
                return failResponse;
            }
          

        }


        public async Task<string> StopBrowserProfileAsync(string browserProfileId)
        {
            // API endpoint'i belirtin
            // /browser_profiles/364014651/start?automation=1
            string endpoint = "/browser/stop-profile";
            StartBrowserProfileRequest request = new StartBrowserProfileRequest();
            request.ProfileId = browserProfileId;
            request.Sync = true;
            // DolphinAntyClient'tan PostAsync metodunu kullanarak isteği gönderin
            var httpResponse = (string)await _client.PostAsync<string>(endpoint, request);

            return httpResponse;

        }
        // Diğer API metodlarını buraya ekleyin
    }
}
