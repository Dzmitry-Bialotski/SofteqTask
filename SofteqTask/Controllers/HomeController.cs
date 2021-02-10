using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SofteqTask.Models;
using SofteqTask.Task;

namespace SofteqTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IEnumerable<int> tasks = new List<int>{1,2,3,4};


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Numbers = new SelectList(tasks);
            return View();
        }
        public IActionResult Solve(TaskModel task)
        {
            ViewBag.Numbers = new SelectList(tasks);
            switch (task.Number)
            {
                case 1:
                    double[] result1 = TaskSolver1.getInstance().Solve(task.InputString);

                    foreach(double res in result1)
                    {
                        task.Result += string.Format("{0:0.000}", res) + " ";
                    }
                    break;
                case 2:
                    double result2 = TaskSolver2.getInstance().Solve(task.InputString);
                    task.Result = string.Format("{0:0.000}", result2);
                    break;
                case 3:
                    int result3 = new TaskSolver3().Solve(task.InputString);
                    task.Result = result3.ToString();
                    break;
                case 4:
                    int result4 = TaskSolver4.Solve(task.InputString);
                    task.Result = result4.ToString();
                    break;
            }
            return View("index", task);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
