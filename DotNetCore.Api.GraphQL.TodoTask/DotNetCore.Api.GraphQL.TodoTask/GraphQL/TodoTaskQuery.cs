using DotNetCore.Api.Repositories;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.Api.Entities;
using DotNetCore.Api.GraphQL.Types;
using GraphQL;

namespace DotNetCore.Api.GraphQL
{
    public class TodoTaskQuery:ObjectGraphType
    {
        public TodoTaskQuery(TodoTaskRepository todoTaskRepository)
        {
            Field<ListGraphType<TodoTaskObject>>("todotasks", resolve: context => todoTaskRepository.GetAll());
            Field<TodoTaskObject>(
                "todotask",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return todoTaskRepository.GetTodoTask(id);
                }
            );
        }
    }

}
