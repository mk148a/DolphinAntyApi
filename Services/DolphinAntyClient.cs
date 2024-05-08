using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace DolphinAntyApi.Services
{
    public class DolphinAntyClient
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://api.dolphinanty.com/";

        // Bearer token
        private readonly string _bearerToken;
        public DolphinAntyClient(string bearerToken)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseUrl);

            // Token tanımlama
            _bearerToken = bearerToken;
        }


        // Örnek bir HTTP GET isteği için genel metot
        public async Task<T> GetAsync<T>(string endpoint)
        {
            // Yetkilendirme başlığını ekleme
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);

            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(content);
        }

        // Örnek bir HTTP POST isteği için genel metot
        public async Task<T> PostAsync<T>(string endpoint, object data)
        {
            // Yetkilendirme başlığını ekleme
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);

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
