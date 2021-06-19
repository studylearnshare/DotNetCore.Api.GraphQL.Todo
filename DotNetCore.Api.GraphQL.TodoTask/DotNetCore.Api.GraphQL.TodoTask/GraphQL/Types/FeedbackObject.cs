using DotNetCore.Api.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Api.GraphQL.Types
{
    public class FeedbackObject: ObjectGraphType<Feedback>
    {
        public FeedbackObject()
        {
            Field(f=>f.Id);
            Field(f => f. Comment);
            

        }
    }
}
