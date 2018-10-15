using BibleVerseCollector.Context;
using BibleVerseCollector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibleVerseCollector.Controllers
{
    public class BibleVerseController : Controller
    {
        BibleVerseContext db = new BibleVerseContext();

        // GET: BibleVerse
        public ActionResult Index()
        {
            return View(db.BibleVerse.ToList());
        }

        // GET: BibleVerse/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BibleVerse/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BibleVerse/Create
        [HttpPost]
        public ActionResult Create(BibleVerse bibleVerse)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.BibleVerse.Add(bibleVerse);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(bibleVerse);
            }
        }

        // GET: BibleVerse/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BibleVerse/Edit/5
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

        // GET: BibleVerse/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BibleVerse/Delete/5
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
