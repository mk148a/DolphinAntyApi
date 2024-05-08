using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace DolphinAntyApi.Services
{
    public class DolphinAntyClient
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://api.dolphinanty.com/v1";

        public DolphinAntyClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseUrl);
        }


        // Örnek bir HTTP GET isteği için genel metot
        private async Task<T> GetAsync<T>(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(content);
        }

        // Örnek bir HTTP POST isteği için genel metot
        private async Task<T> PostAsync<T>(string endpoint, object data)
        {
            var jsonData = JsonSerializer.Serialize(data);
            var httpContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(endpoint, httpContent);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(content);
        }
        // Diğer HTTP metodları buraya eklenebilir (PUT, DELETE, vb.)
    }
}
