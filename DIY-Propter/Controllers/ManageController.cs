using DIY_Propter.Infrastructure;
using DIY_Propter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIY_Propter.Controllers
{
    public class ManageController : Controller
    {
        //
        // GET: /Manage/

        public ActionResult Index()
        {
            List<Prompting> prompts = DataStore.GetCollection<Prompting>("promptings").FindAll().ToList();
            return View(prompts);
        }

        //
        // GET: /Manage/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Manage/Create

        public ActionResult Create()
        {
            Prompting p = new Prompting();
            return View(p);
        }

        //
        // POST: /Manage/Create

        [HttpPost]
        public ActionResult Create(Prompting p)
        {
            try
            {
                // TODO: Add insert logic here
                var prompts = DataStore.GetCollection<Prompting>("promptings");
                prompts.Save(p);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Manage/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Manage/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Manage/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Manage/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
