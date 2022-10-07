using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}