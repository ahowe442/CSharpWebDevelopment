﻿using System;
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
                "<input type='submit'q value='Greet Me!'>" +
                "</form>";
            return Content(html, "text/html");
        }

        //GET /hello/welcome
        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]
        [HttpPost]
        [Route("/helloworld")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}