using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CorgiDev.StaffDirectoryProject.Data;
using CorgiDev.StaffDirectoryProject.Models;

//TODO: Decide if I need to keep the validate entry option in there. If not delete the method and the references to it.

namespace CorgiDev.StaffDirectoryProject.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public ActionResult Index()
        {
            List<Entry> entries;
            using (var context = new MyDbContext())
            {
                entries = context.Entries
                    .Include(e => e.Department)
                    .Include(e => e.Skill)
                    .OrderBy(e => e.LastName)
                    .ToList();
            }

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
            if (ModelState.IsValid)
                {
                    using (var context = new MyDbContext())
                    {
                        context.Entries.Add(entry);
                        context.SaveChanges();
                    }
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

            Entry entry; 
            using (var context = new MyDbContext())
            {
                entry = context.Entries
                    .Include(e => e.Department)
                    .Include(e => e.Skill)
                    .Single(e => e.Id == id);
            }

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
            //ValidateEntry(entry);

            if (ModelState.IsValid)
            {
                //_entriesRepository.UpdateEntry(entry);
                using (var context = new MyDbContext())
                {
                    var dbEntry = context.Entries.Find(entry.Id);
                    dbEntry.TimeClockNumber = entry.TimeClockNumber;
                    dbEntry.FirstName = entry.FirstName;
                    dbEntry.LastName = entry.LastName;
                    dbEntry.JobTitle = entry.JobTitle;
                    dbEntry.DepartmentId = entry.DepartmentId;
                    dbEntry.PhoneNumber = entry.PhoneNumber;
                    dbEntry.EmailAddress = entry.EmailAddress;
                    dbEntry.SkillId = entry.SkillId;
                    dbEntry.Notes = entry.Notes;
                    context.SaveChanges();
                }

                TempData["Message"] = "You successfully edited the staff listing.";

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

            Entry entry;
            using (var context = new MyDbContext())
            {
                entry = context.Entries
                    .Include(e => e.Department)
                    .Include(e => e.Skill)
                    .Single(e => e.Id == id);
            }

            if (entry == null)
            {
                return HttpNotFound();
            }

            return View(entry);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var context = new MyDbContext())
            {
                var entry = context.Entries.Find(id);
                context.Entries.Remove(entry);
                context.SaveChanges();
            }

            TempData["Message"] = "You successfully deleted the staff listing.";
            return RedirectToAction("Index");
        }

        private void SetupDepartmentsSelectListItems()
        {
            List<Department> departments;
            using (var context = new MyDbContext())
            {
                departments = context.Departments.ToList();
            }
            ViewBag.DepartmentsSelectListItems = new SelectList(
                            departments, "Id", "Name");
        }

        private void SetupSkillsSelectListItems()
        {
            List<Skill> skills;
            using (var context = new MyDbContext())
            {
                skills = context.Skills.ToList();
            }

            ViewBag.SkillsSelectListItems = new SelectList(
                                skills, "Id", "Name");
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