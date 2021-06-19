using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Api.GraphQL.TodoTask.Web.Models
{
    public class ErrorModel
    {
        public string Message { get; set; }
        public string Code { get; set; }
    }
}
