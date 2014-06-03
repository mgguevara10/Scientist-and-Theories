using Scientist.web.Adapters.Adapters;
using Scientist.web.Adapters.Interfaces;
using Scientist.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scientist.web.Controllers
{
    public class HomeController : Controller
    {
        private ITheoryAdapter _adapter;
        public HomeController()
        {
            _adapter = new DataTheoryAdapter();
        }

        public ActionResult Index()
        {
            List<Theory> Theories = _adapter.GetAllTheories();
            return View(Theories);
        }

        public ActionResult CreateTheory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTheory(Theory Theory)
        {
            _adapter.AddTheory(Theory);
            return RedirectToAction("Index");
        }

    }
}