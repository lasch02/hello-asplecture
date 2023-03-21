using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace HelloASPLecture.Controllers
{
    public class GreetController : Controller
    {
        // GET : /<controller>'
        //localhost: [port#]/controller_name
        //[Route("/welcometotheshow")]
        [HttpGEt]
        public IActionResult Index()
        {
            return Content("<h1>Welcome to the show</h1>", "text/html");
        }

        [HttpGet("greet/kick/{name?}")] //will use generic get request if you do not specify
        public IActionResult Kick(string name = "You")
        {
            //string html = "<h1>Kick</h1>";

            string html = $"{name}, you need a <h1>Kick</h1> in the head.";
            return Content(html, "text/html");
        }


    }
}
