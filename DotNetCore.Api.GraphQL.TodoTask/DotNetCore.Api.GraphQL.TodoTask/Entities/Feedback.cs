using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Api.Entities
{
    public class Feedback
    {
        public int Id { get; set; }

        public int TodoTaskId { get; set; }

        public TodoTask Task { get; set; }

        public string Comment { get; set; }

    }
}
