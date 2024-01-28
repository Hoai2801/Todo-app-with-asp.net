using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Message"] = "Welcome to my todo app";
        ViewData["Data"] = Repository.Responses;
        Console.Write(Repository.Responses);
        return View();
    }

    [HttpPost]
    public IActionResult NewTask(Models.Todo todoResponse)
    {
        Repository.AddTodo(todoResponse);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}