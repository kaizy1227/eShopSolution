﻿using eShopSolution.ViewModel.System.Users;
using Newtonsoft.Json;
using System.Text;

namespace eShopSolution.AdminApp.Services
{
    public class UserApiClient : IUserApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public UserApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7043");
           var reponse = await client.PostAsync("/api/users/authenticate", httpContent);
            var token = await reponse.Content.ReadAsStringAsync();
            return token;
        }

       
    }
}
