using DotNetCore.Api.GraphQL.TodoTask.Web.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Api.GraphQL.TodoTask.Web.Models
{
    public class Response<T>
    {
        public T Data { get; set; }
        public List<ErrorModel> Errors { get; set; }

        public void ThrowErrors()
        {
            if (Errors != null && Errors.Any())
                throw new GraphQLException(
                    $"Message: {Errors[0].Message} Code: {Errors[0].Code}");
        }
    }

    public class TodoTaskContainer
    {
        public List<TodoTaskModel> TodoTasks { get; set; }
    }
}
