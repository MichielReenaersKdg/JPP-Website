using JPP.BL;
using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace JPP.UI.Web.MVC.Controllers
{
   [CustomAuthorizeAttribute(Roles = "Admin")]
    public class ContactpersoonController : Controller
    {
       public class CustomAuthorizeAttribute : AuthorizeAttribute
       {
          

           public override void OnAuthorization(AuthorizationContext filterContext)
           {
               base.OnAuthorization(filterContext);
               if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
               {
                   filterContext.Result = new RedirectResult("~/Account/Login");
                   return;
               }

               if (filterContext.Result is HttpUnauthorizedResult)
               {
                   filterContext.Result = new RedirectResult("~/Account/AccessDenied");
                   return;
               }
           }
       }

       private ContactManager mgr = new ContactManager();

       // /Contactpersonen/Index
       public ActionResult Index(int? page)
        {
            IEnumerable<Contactpersoon> contactpersonen = mgr.GetContactpersonen();

            int pageSize = 8;
            int pageNumber = (page ?? 1);

            return View(contactpersonen.ToPagedList(pageNumber, pageSize));
        }





       // GET: /Contactpersonen/Delete/5
        public ActionResult Delete(int id)
        {
            Contactpersoon contactpersoon = mgr.GetContactpersoon(id);
            return View(contactpersoon);
        }


        // GET: /Contactpersonen/Details/5
        public ActionResult Details(int id)
        {
            Contactpersoon contactpersoon = mgr.GetContactpersoon(id);
            return View(contactpersoon);
        }

        // POST: /Contactpersonen/Delete/5
        [HttpPost]
        [CustomAuthorizeAttribute(Roles = "Admin")]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                mgr.RemoveContactpersoon(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }

  

}