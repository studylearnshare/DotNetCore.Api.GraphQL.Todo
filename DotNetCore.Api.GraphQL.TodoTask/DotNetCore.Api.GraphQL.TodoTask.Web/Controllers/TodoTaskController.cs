using DotNetCore.Api.GraphQL.TodoTask.Web.Clients;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Api.GraphQL.TodoTask.Web.Controllers
{
    public class TodoTaskController : Controller
    {
        private readonly TodoTaskHttpClient _httpClient;
        private readonly TodoTaskGraphClient _todoGraphClient;

        
        public TodoTaskController(TodoTaskHttpClient httpClient,
            TodoTaskGraphClient todoGraphClient)
        {
            _httpClient = httpClient;
            _todoGraphClient = todoGraphClient;
        }


        public async Task<IActionResult> Index()
        {
            var responseModel = await _httpClient.GetTodoTasks();
            responseModel.ThrowErrors();
            return View(responseModel.Data.TodoTasks);
        }

        public async Task<IActionResult> TaskDetail(int taskId)
        {
            var task = await _todoGraphClient.GetTask(taskId);
            return View(task);
        }

      
    }
}
