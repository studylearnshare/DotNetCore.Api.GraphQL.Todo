using GraphQL.Types;
using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Utilities;

namespace DotNetCore.Api.GraphQL
{
    public class TodoTaskSchema:Schema
    {
        public TodoTaskSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<TodoTaskQuery>();
        }
    }
}
