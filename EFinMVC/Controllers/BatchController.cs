using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFinMVC.Models;
namespace EFinMVC.Controllers
{
    public class BatchController : Controller
    {
        BatchDbContext db = new BatchDbContext();
        // GET: Student
        public ActionResult Index()
        { 
            if(TempData["msg"]!=null)
            {
                ViewBag.msg = TempData["msg"];
            }
            return View(db.Batches.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Batch batch)
        {
             
                db.Batches.Add(batch);
                db.SaveChanges();
                TempData["msg"] = "Record inserted";
                return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                Batch batch = db.Batches.FirstOrDefault(x => x.Id == id);
                if (batch != null)
                    return View(batch);
                else
                    ViewBag.msg = "Record not found";
                return View();
            }
            else
            {
                ViewBag.msg = "Please provide ID";
                return View();
            }
        }
            [HttpPost]
        public ActionResult Edit(int id, Batch batch)
        {
            Batch obj = db.Batches.FirstOrDefault(x => x.Id == id);
            if (obj != null)
            {
                foreach (Batch temp in db.Batches)
                {
                    if(obj.Id==temp.Id)
                    {
                        temp.BatchCode = batch.BatchCode;
                        temp.StartDate = batch.StartDate;
                        temp.Course = batch.Course;
                        break;

                    }
                }
            }
            
            db.SaveChanges();
            TempData["msg"] = "Record edited";
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                Batch batch = db.Batches.FirstOrDefault(x => x.Id == id);
                if (batch != null)
                    return View(batch);
                else
                    ViewBag.msg = "Record not found";
                return View();
            }
            else
            {
                ViewBag.msg = "Please provide ID";
                return View();
            }
        }
        [HttpPost]
        public ActionResult Delete(int id, Batch batch)
        {
            Batch obj = db.Batches.FirstOrDefault(x => x.Id == id);
            if (obj != null)
            {

                db.Batches.Remove(obj);
                    
                }
            db.SaveChanges();
            TempData["msg"] = "Record deleted";
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Batch batch = db.Batches.FirstOrDefault(x => x.Id == id);
                if (batch != null)
                    return View(batch);
                else
                    ViewBag.msg = "Record not found";
                return View();
            }
            else
            {
                ViewBag.msg = "Please provide ID";
                return View();
            }
        }
    }
}