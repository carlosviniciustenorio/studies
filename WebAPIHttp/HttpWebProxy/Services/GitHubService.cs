using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HttpWebProxy.Models;
using Microsoft.Net.Http.Headers;

namespace HttpWebProxy.Services
{
    public class GitHubService
    {
        private readonly HttpClient _httpClient;

        public GitHubService(HttpClient httpClient) => (_httpClient) = (httpClient);

        public async Task<IEnumerable<GitHubBranch>?> GetAspNetCoreDocsBranchesAsync() =>
            await _httpClient.GetFromJsonAsync<IEnumerable<GitHubBranch>>(
                "repos/dotnet/AspNetCore.Docs/branches");

        public async Task<HttpResponseMessage> PostAspNetCoreBranchAsync(GitHubBranch obj) => await _httpClient.PostAsJsonAsync("https://localhost:7028/WeatherForecast", obj);
        
    }
}