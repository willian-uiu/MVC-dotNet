using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name, int numTimes=1)
    {
        //return "This is the Welcome action method...";
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;        
        return View();
    }
    // 
    // GET: /HelloWorld/Teste/ 
    public string Teste()
    {
        return "Este é apenas um teste...";
    }
}