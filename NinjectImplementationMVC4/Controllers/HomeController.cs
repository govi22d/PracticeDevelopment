using NinjectImplementationMVC4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjectImplementationMVC4.Controllers
{
    public class HomeController : Controller
    {
        private IDatabaseProvider _db;

        public HomeController(IDatabaseProvider db)
        {
            this._db = db;
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            string str = _db.GetGreetingMessage();
            ViewBag.Message = str;
            return View();
        }

    }
}
