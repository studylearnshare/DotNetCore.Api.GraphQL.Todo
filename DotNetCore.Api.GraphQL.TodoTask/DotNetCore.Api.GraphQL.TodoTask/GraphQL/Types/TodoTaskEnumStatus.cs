using DotNetCore.Api.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Api.GraphQL.Types
{
    public class TodoTaskEnumStatus:EnumerationGraphType<TodoTaskStatus>
    {
        public TodoTaskEnumStatus()
        {
            Name = "Status";
            Description = "The status of todo task";
        }
    }
}
