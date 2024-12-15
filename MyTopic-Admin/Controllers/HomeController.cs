using Microsoft.AspNetCore.Mvc;
using MyTopic_Admin.Models;
using System.Diagnostics;

namespace MyTopic_Admin.Controllers
{
    public class HomeController : Controller
    {
        private static List<Topic> Topics = new List<Topic>
        {
            new Topic { Name = "Sport" },
            new Topic { Name = "Technology" }
        };


        public IActionResult Index()
        {
            return View(Topics);
        }
        [HttpPost]
        public IActionResult AddTopic(string topicName)
        {
            if (!string.IsNullOrEmpty(topicName) && Topics.)
            {
                
            }
        }
    }
}
