using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CorgiDev.StaffDirectoryProject.Data;
using CorgiDev.StaffDirectoryProject.Models;

namespace CorgiDev.StaffDirectoryProject.Controllers
{
    public class HomeController : Controller
    {
        private EntriesRepository _entriesRepository = null;

        public HomeController()
        {
            _entriesRepository = new EntriesRepository();
        }

        public ActionResult Index()
        {
            List<Entry> entries = _entriesRepository.GetEntries();

            return View(entries);
        }

        public ActionResult About()
        {
            ViewBag.Message = "About the Accessibility Help Directory";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Only the CorgiDev website below is a legitamate address at this time.";

            return View();
        }
    }
}