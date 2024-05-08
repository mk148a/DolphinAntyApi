using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DolphinAntyApi.Models;

namespace DolphinAntyApi.Services
{
    public class DolphinAntyService
    {
        private readonly DolphinAntyClient _client;

        public DolphinAntyService(DolphinAntyClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<CreateBrowserProfileRequest> CreateBrowserProfileAsync(CreateBrowserProfileRequest request)
        {

            return await _client.PostAsync<CreateBrowserProfileResponse>("/browser-profiles",request);
        }

        // Diğer API metodlarını buraya ekleyin
    }
}
