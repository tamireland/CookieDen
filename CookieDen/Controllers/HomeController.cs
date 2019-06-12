using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookieDen.Models;
using CookieDen.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CookieDen.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var cookies = _repository.GetCookies().OrderBy(x => x.Name);
            var homeViewModel = new HomeViewModel
            {
                Title = "Cookies and only Cookies",
                Cookies = cookies.ToList()
            };
            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var cookie = _repository.GetCookie(id);
            return View(cookie);
        }
    }
}