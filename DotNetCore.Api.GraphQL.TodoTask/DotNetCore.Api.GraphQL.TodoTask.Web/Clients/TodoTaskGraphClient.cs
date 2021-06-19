using DotNetCore.Api.GraphQL.TodoTask.Web.Models;
using GraphQL.Client.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Api.GraphQL.TodoTask.Web.Clients
{
    public class TodoTaskGraphClient
    {
        private readonly GraphQLHttpClient _client;

        public TodoTaskGraphClient(GraphQLHttpClient client)
        {
            _client = client;
        }


        public async Task<TodoTaskModel> GetTask(int id)
        {
            var query = new GraphQLHttpRequest
            {
                Query = @" 
                query taskById($taskId:ID!)
                {   todotask(id:$taskId)  
                    { 
                        id,title,description,cost
  	                    feedbacks {id, comment}
                    }  
                }",
                Variables = new { taskId = id }
            };
            var response = await _client.SendQueryAsync<TodoTasktResponse>(query);
            return response.Data.TodoTask;
        }

      
    }
}
