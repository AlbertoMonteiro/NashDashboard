using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using dashing.net.common;

namespace dashing.net.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Sampletv()
        {
            return View();
        }

        public ActionResult Sample()
        {
            return View();
        }
        public ActionResult ListJobs()
        {
            var jobs = string.Join(", ",Jobs.Get().Select(j => j.GetType().Name));
            return Content(jobs);
        }
    }
}
