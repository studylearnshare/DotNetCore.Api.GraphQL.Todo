using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DotNetCore.Api.GraphQL.TodoTask.Web.Models
{
    public class TodoTaskModel
    {
        
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }

        
        public decimal Cost { get; set; }

        public string Status { get; set; }

        public List<FeedbackInputModel> Feedbacks { get; set; }
        


    }
}
