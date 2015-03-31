using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JPP.BL;
using JPP.Domain;
using PagedList;

namespace JPP.UI.Web.MVC.Controllers
{
    [Authorize]
    public class RecensieController : Controller
    {
        private AdminManager mgr = new AdminManager();
        //TEST
        // GET: Recensie
        public ActionResult Index(int? page)
        {
            IEnumerable<Recensie> recensies = mgr.GetRecensies();


            int pageSize = 4;
            int pageNumber = (page ?? 1);
            return View(recensies.ToPagedList(pageNumber, pageSize));
           
        }

        // GET: Recensie/Details/5
        public ActionResult Details(int id)
        {

            Recensie recensie = mgr.GetRecensie(id);
            return View(recensie);
        }

        // GET: Recensie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recensie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Recensie/Edit/5
        public ActionResult Edit(int id)
        {
            Recensie recensie = mgr.GetRecensie(id);
            return View(recensie);
        }

        // POST: Recensie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Recensie recensie)
        {
            try
            {
                // TODO: Add update logic here
                mgr.ChangeRecensie(recensie);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Recensie/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            Recensie recensie = mgr.GetRecensie(id);
            return View(recensie);
        }

        // POST: Recensie/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                mgr.RemoveRecensie(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
