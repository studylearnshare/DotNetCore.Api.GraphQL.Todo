using DotNetCore.Api.Context;
using DotNetCore.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Api.Repositories
{
    public class FeedbackRepository
    {
        private readonly TodoTaskDbContext _todoTaskDbContext;

        public FeedbackRepository(TodoTaskDbContext  dbContext)
        {
            _todoTaskDbContext = dbContext;
        }

        public async Task<IEnumerable<Feedback>> GetTaskFeedback(int todoTaskId)
        {
            return await _todoTaskDbContext.Feedbacks.Where(t => t.TodoTaskId == todoTaskId).ToListAsync();
        }

        public async Task<ILookup<int, Feedback>> GetFeedbacks(IEnumerable<int> todoTaskIds)
        {
            var feedbacks = await _todoTaskDbContext.Feedbacks.Where(t => todoTaskIds.Contains(t.TodoTaskId)).ToListAsync();
            return feedbacks.ToLookup(f=> f.TodoTaskId);
        }
    }
}
