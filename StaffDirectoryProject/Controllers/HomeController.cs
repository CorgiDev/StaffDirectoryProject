using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CorgiDev.StaffDirectoryProject.Data;
using CorgiDev.StaffDirectoryProject.Models;

//TODO: Decide if I need to keep the validate entry option in there. If not delete the method and the references to it.

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

        public ActionResult Add()
        {
            var entry = new Entry()
            {
            };

            SetupDepartmentsSelectListItems();

            SetupSkillsSelectListItems();

            return View(entry);
        }

        [HttpPost]
        public ActionResult Add(Entry entry)
        {
            ValidateEntry(entry);

            if (ModelState.IsValid)
            {
                _entriesRepository.AddEntry(entry);
                TempData["Message"] = "Your staff listing was successfully added.";
                return RedirectToAction("Index");
            }

            SetupDepartmentsSelectListItems();

            SetupSkillsSelectListItems();

            return View(entry);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Entry entry = _entriesRepository.GetEntry((int)id);

            if (entry == null)
            {
                return HttpNotFound();
            }

            SetupDepartmentsSelectListItems();

            SetupSkillsSelectListItems();

            return View(entry);
        }

        [HttpPost]
        public ActionResult Edit(Entry entry)
        {
            ValidateEntry(entry);

            if (ModelState.IsValid)
            {
                _entriesRepository.UpdateEntry(entry);

                return RedirectToAction("Index");
            }

            SetupDepartmentsSelectListItems();

            SetupSkillsSelectListItems();

            TempData["Message"] = "You successfully edited the staff listing.";

            return View(entry);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entry entry = _entriesRepository.GetEntry((int)id);

            if (entry == null)
            {
                return HttpNotFound();
            }

            return View(entry);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _entriesRepository.DeleteEntry(id);

            TempData["Message"] = "You successfully deleted the staff listing.";
            return RedirectToAction("Index");
        }

        private void ValidateEntry(Entry entry)
        {
            //If there aren't any "Duration" field validation errors
            //then make sure the duration is greater than "0".
            //if (ModelState.IsValidField("Duration") && entry.Duration <= 0)
            //{
            //    ModelState.AddModelError("Duration", "The Duration field value must be greater than '0'.");
            //}
        }

        private void SetupDepartmentsSelectListItems()
        {
            ViewBag.DepartmentsSelectListItems = new SelectList(
                            Data.Data.Departments, "Id", "Name");
        }

        private void SetupSkillsSelectListItems()
        {
            ViewBag.SkillsSelectListItems = new SelectList(
                            Data.Data.Skills, "Id", "Name");
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