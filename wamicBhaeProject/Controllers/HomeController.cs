using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wamicBhaeProject.Models;
using System.IO;

namespace wamicBhaeProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            dbClass dbhandle = new dbClass();
            ModelState.Clear();
            return View(dbhandle.viewMember());
///            return View();
        }

        [HttpGet]
        public ActionResult Addmember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Addmember(addMemberClass add)
        {
            dbClass sdb = new dbClass();
                         

            String fn = Path.GetFileNameWithoutExtension(add.ImageFile.FileName);
            String ext = Path.GetExtension(add.ImageFile.FileName);
            fn = fn + DateTime.Now.ToString("yymmssfff") + ext;
            add.path = "~/images/" + fn;
            fn = Path.Combine(Server.MapPath("~/images/"), fn);
            add.ImageFile.SaveAs(fn);

            add.photo = fn.ToString();

                try
                {
                    if (ModelState.IsValid)
                    {
                        if (sdb.AddMember(add))
                        {
                            

                            // ViewBag.Message = String.Format("Hello{0}.\\ncurrent Date and time:{1}", "name", DateTime.Now.ToString());
                            ViewBag.Message = "Member Added Successfully";
                            ModelState.Clear();
                            return RedirectToAction("Index");


                        }
                    }

                }
                catch
                {
                    return View();
                }
            return View();
        }

        [HttpGet]
        public ActionResult viewmember()
        {
            dbClass dbhandle = new dbClass();
            ModelState.Clear();
            return View(dbhandle.viewMember());
         }

        public ActionResult Details(int id)
        {
            dbClass sdb = new dbClass();
            return View(sdb.viewMember().Find(smodel => smodel.Id == id));
        }


    }
}