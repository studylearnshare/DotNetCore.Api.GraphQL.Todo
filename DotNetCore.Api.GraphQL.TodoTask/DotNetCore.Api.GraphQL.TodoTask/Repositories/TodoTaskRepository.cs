using DotNetCore.Api.Context;
using DotNetCore.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DotNetCore.Api.Repositories
{
    
    public class TodoTaskRepository
    {
        private readonly TodoTaskDbContext _dbContext;

        public TodoTaskRepository(TodoTaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Entities.TodoTask>> GetAll()
        {
            return _dbContext.TodoTasks.ToListAsync();
        }
        public Task<TodoTask> GetTodoTask(int id)
        {
            return _dbContext.TodoTasks.SingleAsync(p => p.Id == id);
        }
    }
}
