using DIY_Propter.Infrastructure;
using DIY_Propter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIY_Propter.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<Prompting> prompts = DataStore.GetCollection<Prompting>("promptings").FindAll().ToList();
            return View(prompts);
        }

        public ActionResult Search(string searchterm)
        {
            return View();
        }
    }
}
