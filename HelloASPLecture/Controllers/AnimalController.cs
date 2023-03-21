using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPLecture.Controllers
{
    public class AnimalController : Controller
    {
        [HttpGet("/animal")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            string form = "<h1>SUBMIT YOUR ANIMAL HERE</h1>" +
                "<form action='/animal/feature' method='post'>" +
                "<p><label>Name: <input type='text' name='name'></label></p>" +
                "<p><label>Species: <input type='text' name='species'></label></p>" +
                "<p><label>Quirk: <input type='text' name='quirk'></label></p>" +
                "<p><input type=submit value='S U B M I T'></p>" +
                "</form>";
            return Content(form, "text/html");
        }

        // GET & POST: /controller/feature
        [HttpGet("/animal/feature")]
        [HttpPost("/animal/feature")]
        public IActionResult ShowOff(string name = "Bananya", string species = "Banana Cat", string quirk = "Very yellow")
        {
            string html = "<h1>AND HERE'S THE STAR OF THE SHOW</h1>" +
                $"<p><strong>Name:</strong> {name}</p>" +
                $"<p><strong>Species:</strong> {species}</p>" +
                $"<p><strong>Quirk:</strong> {quirk}</p>";

            return Content(html, "text/html");
        }
    }
}

