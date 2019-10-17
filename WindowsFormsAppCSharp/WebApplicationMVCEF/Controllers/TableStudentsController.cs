using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVCEF.Models;

namespace WebApplicationMVCEF.Controllers
{
    public class TableStudentsController : Controller
    {
        private crmEntities db = new crmEntities();

        // GET: TableStudents
        public ActionResult Index()
        {
            return View(db.TableStudents.ToList());
        }

        // GET: TableStudents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableStudent tableStudent = db.TableStudents.Find(id);
            if (tableStudent == null)
            {
                return HttpNotFound();
            }
            return View(tableStudent);
        }

        // GET: TableStudents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TableStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email")] TableStudent tableStudent)
        {
            if (ModelState.IsValid)
            {
                db.TableStudents.Add(tableStudent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tableStudent);
        }

        // GET: TableStudents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableStudent tableStudent = db.TableStudents.Find(id);
            if (tableStudent == null)
            {
                return HttpNotFound();
            }
            return View(tableStudent);
        }

        // POST: TableStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email")] TableStudent tableStudent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tableStudent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tableStudent);
        }

        // GET: TableStudents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableStudent tableStudent = db.TableStudents.Find(id);
            if (tableStudent == null)
            {
                return HttpNotFound();
            }
            return View(tableStudent);
        }

        // POST: TableStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TableStudent tableStudent = db.TableStudents.Find(id);
            db.TableStudents.Remove(tableStudent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
