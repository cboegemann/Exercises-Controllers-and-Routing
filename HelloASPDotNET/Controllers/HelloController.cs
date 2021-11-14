using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // GET: /hello/welcome
        // [HttpGet]
        // [Route("/helloworld/welcome/{name?}")]

        [HttpGet("welcome/{name?}/{language?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "World", string language = "english")
        {
            string welcomeMessage = "Welcome to my app, ";
            if(language == "english")
            {
                welcomeMessage = "Welcome to my app,";
            }
            else if(language == "hindi")
            {
                welcomeMessage = "Namaste, ";
            }
            else if(language == "japanese")
            {
                welcomeMessage = "Konnichiwa, ";
            }
            else if(language == "korean")
            {
                welcomeMessage = "Ahn-yong-ha-se-yo, ";
            }
            else if(language == "spanish")
            {
                welcomeMessage = "Hola, ";
            }
            else if(language == "italian")
            {
                welcomeMessage = "Ciao, ";
            }

            return Content($"<h1>{welcomeMessage} {name}! </h1>", "text/html");
        }
    }
}
