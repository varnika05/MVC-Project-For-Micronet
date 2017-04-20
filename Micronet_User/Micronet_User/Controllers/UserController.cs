using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Micronet_User.Models;
using System.Web.Security;

namespace Micronet_User.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index( Register obj)
        {

            if (ModelState.IsValid)
            {
                Micronet_DatabaseEntities db = new Micronet_DatabaseEntities();
                db.Registers.Add(obj);
                
                db.SaveChanges();
                //if (obj)
                //{
                //    return RedirectToAction("UserProfile");
                //}
                //else
                //{
                //    ModelState.AddModelError("", "Email Id Already Exist");
                //}
                var v = db.Registers.Where(a => a.Email.Equals(obj.Email) && a.Password.Equals(obj.Password)).FirstOrDefault();
                if (v != null)
                {
                    Session["LoggedEmail"] = v.Email.ToString();
                    
                    return RedirectToAction("UserProfile");
                }
            }

           
            return View(obj);
        }

        public ActionResult UserProfile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserProfile(CardDetail cd)
        {

            if (ModelState.IsValid)
            {
                Micronet_DatabaseEntities db = new Micronet_DatabaseEntities();
                db.CardDetails.Add(cd);
                db.SaveChanges();

                return Content("Your Card Details are Saved!");

               

            }
            return View(cd);

        }


        [HttpPost]
        public JsonResult IsEmailExists(string Email)
        {

            Micronet_DatabaseEntities db = new Micronet_DatabaseEntities();
            //check if any of the Email matches the Email specified in the Parameter using the ANY extension method.  
            return Json(!db.Registers.Any(x => x.Email == Email), JsonRequestBehavior.AllowGet);
        }
    }
}