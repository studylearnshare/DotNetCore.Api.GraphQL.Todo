using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Api.GraphQL.TodoTask.Web.Utilities
{
    public class GraphQLException : ApplicationException
    {
        public GraphQLException(string message) : base(message)
        {

        }
    }
}
