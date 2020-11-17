using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        //GET: /<controller>/
        //[HttpGet]
        [Route("/helloworld")]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name' />" +
                "<select name='language' id='language'>" +
                    "<option value='french'>French</option>" +
                    "<option value='english'>English</option>" +
                    "<option value='spanish'>Spanish</option>" +
                "</select>" +
                "<input type='submit'q value='Greet Me!'>" +
                "</form>";
            return Content(html, "text/html");
        }

        //GET /hello/welcome
        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]
        [HttpPost]
        [Route("/helloworld")]
        public IActionResult Welcome(string name, string language )
        {
            if(language == "english")
            {
                return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
            }
            else if (language == "french")
            {
                return Content("<h1>Oooh la la....Bienvenue sur mon appli, " + name + "!</h1>", "text/html");
            }
            else if (language == "spanish")
            {
                return Content("<h1>Bienvenido a mi aplicación, " + name + "!</h1>", "text/html");
            }
            else
                return Content("Thanks for playing", "text/html");
                
            
        }
    }
}
