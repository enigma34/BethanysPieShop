using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
    {
        private IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            //ViewBag.Title = "Pie Overview";
            var pies = _pieRepository.GetAllPie().OrderBy(p => p.Name);
            var homeviewmodel = new HomeViewMoodel()
            {
                Title = "Welcome to Bethany's pie Shop",
                Pies = pies.ToList()
            };

            return View(homeviewmodel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPie(id);
            if (pie==null)
                return NotFound();
            return View(pie);
        }
    }
}