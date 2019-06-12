using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookieDen.Models;
using Microsoft.AspNetCore.Mvc;

namespace CookieDen.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;
        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            _feedbackRepository.AddFeedback(feedback);
            return View();
            //return RedirectToAction("FeedbackReceived");
        }

    }
}