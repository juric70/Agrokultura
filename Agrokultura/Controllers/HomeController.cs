﻿using Agrokultura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Agrokultura.Controllers
{
    public class HomeController : Controller
    {
        private readonly AgroContext _context;

        
        public HomeController(AgroContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            int brojNarudzbi = _context.Orders.Count()-2;
            ViewBag.Order = brojNarudzbi;
            int numberOfPeople = _context.People.Count();
            ViewBag.People = numberOfPeople;
            var agroContext = _context.Orders.Include(o => o.Customer).Include(o => o.OrderStatus).Include(o => o.Plant);
            var ChoreContext = _context.ChorePeople.Include(c => c.Chore).Include(c => c.OrderStatus).Include(c => c.Person);

            var orders = agroContext.ToList();
    var chores = ChoreContext.ToList();

    var combinedViewModel = new CombinedViewModel
    {
        Orders = orders,
        Chores = chores
    };

    return View(combinedViewModel);
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