using DotNetCore.Api.Entities;
using DotNetCore.Api.Repositories;
using GraphQL.DataLoader;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Api.GraphQL.Types
{
    public class TodoTaskObject: ObjectGraphType<TodoTask>
    {
        public TodoTaskObject(FeedbackRepository feedbackRepository, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(f => f.Id);
            Field(f => f.Title).Description("Title of the task");
            Field(f => f.Description);
            Field(f => f.Cost);
            Field<TodoTaskEnumStatus> ("Status","The status of the todo task");

            Field<ListGraphType<FeedbackObject>>(
                "feedbacks",
                resolve: context =>
                {
                    var loader =
                        dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, Feedback>(
                            "GetFeedbackByTaskId", feedbackRepository.GetFeedbacks);
                    return loader.LoadAsync(context.Source.Id);
                });

        }
    }
}
