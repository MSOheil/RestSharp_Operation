using RestShar_Sample.Models;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace RestShar_Sample.Interfaces.Services
{
    public class RestSharpManagement
    {
        private readonly string serverAddress;
        public RestSharpManagement(string serverUrl)
        {
            serverAddress = serverUrl;
        }

        public async Task PostAsync<TResult>(object requestBody)
        {
            var restClient = new RestClient(serverAddress);
            var request = new RestRequest("/api/Sa/gett").AddJsonBody(requestBody);
            var response = restClient.Post<TResult>(request);
            var sdfs=1;
        }
        public async Task GetAsync<TResult>(object requestBody)
        {
            var restClient = new RestClient(serverAddress);
            var request = new RestRequest("/api/Sa/get");
            request.AddObject(requestBody);
            var response = restClient.Get<TResult>(request);
            var sdfs = 1;
        }

    }
}
