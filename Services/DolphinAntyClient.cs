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
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public DolphinAntyClient(string baseUrl, string apiKey)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<string> Get(string endpoint)
        {
            using var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> Post<T>(string endpoint, T data)
        {
            var json = JsonSerializer.Serialize(data, _jsonSerializerOptions);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var response = await _httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        // Diğer HTTP metodları buraya eklenebilir (PUT, DELETE, vb.)
    }
}
