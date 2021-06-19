using DotNetCore.Api.GraphQL.TodoTask.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DotNetCore.Api.GraphQL.TodoTask.Web.Clients
{
    public class TodoTaskHttpClient
    {
        private readonly HttpClient _httpClient;

        public TodoTaskHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Response<TodoTaskContainer>> GetTodoTasks()
        {
            var response = await _httpClient.GetAsync(@"?query= 
            {
                todotasks 	{  id title description cost status }
            }");
            var stringResult = await response.Content.ReadAsStringAsync();
           return JsonSerializer.Deserialize<Response<TodoTaskContainer>>(stringResult, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            
        }
    }
}
