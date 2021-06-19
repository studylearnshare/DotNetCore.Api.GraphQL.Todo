using DotNetCore.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Api.Context
{
    public class TodoTaskDbContext:DbContext
    {
        public TodoTaskDbContext(DbContextOptions<TodoTaskDbContext> options):base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<TodoTask>()
        //        .HasKey(tk => new { tk.Id});
        //}
        public DbSet<TodoTask> TodoTasks { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

    }
}
