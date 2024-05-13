using GoLoginApi.Models;
using GoLoginApiApi.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

using System.Threading.Tasks;


namespace GoLoginApi.Services
{
    public class GoLoginApiClient
    {
        private readonly HttpClient _httpClient;
       

        // Bearer token
        private readonly string _bearerToken;
        public GoLoginApiClient(string bearerToken,string BaseUrl)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseUrl);

            // Token tanımlama
            _bearerToken = bearerToken;
        }


        // Örnek bir HTTP GET isteği için genel metot
        public async Task<object> GetAsync<T>(string endpoint)
        {
            // Yetkilendirme başlığını ekleme
          
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);

            var response = await _httpClient.GetAsync(endpoint);
           // response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            try
            {
                return JsonConvert.DeserializeObject<T>(content);
            }
            catch (Exception e)
            {
                return content;
            }
          
        }

        // Örnek bir HTTP POST isteği için genel metot
        public async Task<T> PostAsync<T>(string endpoint, object data)
        {
            // Yetkilendirme başlığını ekleme
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);

            // Null olan değerlerin eklenmemesini sağlamak için JsonSerializerSettings kullanın
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            var jsonData = JsonConvert.SerializeObject(data,settings);
            var httpContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(endpoint, httpContent);
           // response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }
        public async Task<string> PostAsync(string endpoint, object data)
        {
            // Yetkilendirme başlığını ekleme
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);

            // Null olan değerlerin eklenmemesini sağlamak için JsonSerializerSettings kullanın
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
          
            var jsonData = JsonConvert.SerializeObject(data, settings);
            var httpContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(endpoint, httpContent);
            // response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
        // Diğer HTTP metodları buraya eklenebilir (PUT, DELETE, vb.)

        // Örnek bir HTTP POST isteği için genel metot
        public async Task DeleteAsync(string endpoint)
        {
            // Yetkilendirme başlığını ekleme
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);
            await _httpClient.DeleteAsync(endpoint);
            
        }

    
    }
}
