using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Api.GraphQL.TodoTask.Web.Models
{
    public class FeedbackInputModel
    {
        public int Id { get; set; }

        public string Comment { get; set; }
    }
}
