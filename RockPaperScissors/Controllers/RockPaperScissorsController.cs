using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissorsApp;
using System;

namespace RockPaperScissorsApp.Controllers
{
    public class RockPaperScissorsController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View(null);
        }

        [HttpPost("/")]
        public ActionResult Create()
        {
            Console.WriteLine("Hey");
            Console.WriteLine(int.Parse(Request.Form["player1"]));
            return View("Index", RockPaperScissors.Game(int.Parse(Request.Form["player1"]), int.Parse(Request.Form["player2"])));
        }
    }
}
