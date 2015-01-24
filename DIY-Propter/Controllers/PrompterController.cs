using DIY_Propter.Infrastructure;
using DIY_Propter.Models;
using MongoDB.Driver.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIY_Propter.Controllers
{
    public class PrompterController : Controller
    {
        //
        // GET: /Prompter/

        public ActionResult Start(Guid id)
        {
            Prompting p = DataStore.GetCollection<Prompting>("promptings").FindOne(Query<Prompting>.EQ(x => x.PromptID, id));

            List<string> promptTexts = p.Text.Split('*').Select(x => x.Trim()).ToList();
            return View(promptTexts);
        }

    }
}
