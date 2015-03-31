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
    public class BerichtController : Controller
    {
        
         private AdminManager mgr = new AdminManager();

        // GET: Bericht
         public ActionResult Index(int? page)
        {
            IEnumerable<Bericht> berichten = mgr.GetBerichten();

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            return View(berichten.ToPagedList(pageNumber, pageSize));
        }

        // GET: Bericht/Details/5
        public ActionResult Details(int id)
        {
            Bericht bericht = mgr.GetBericht(id);
            return View(bericht);
        }

        // GET: Bericht/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bericht/Create
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

        // GET: Bericht/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bericht/Edit/5
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

        // GET: Bericht/Delete/5
        [Authorize (Roles="Admin")]
        public ActionResult Delete(int id)
        {
            Bericht bericht = mgr.GetBericht(id);

            return View(bericht);
        }

        // POST: Bericht/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                mgr.RemoveBericht(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
