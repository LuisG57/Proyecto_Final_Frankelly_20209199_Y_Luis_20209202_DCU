using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EntityLayer;
using ServicesLayer;

namespace Proyecto_Final_Frankelly_20209199_Y_Luis_20209202_DCU.Controllers
{
    public class WebController : Controller
    {
        private UserDataService _userdata = new UserDataService();
        // GET: Web
        public ActionResult Index()
        {
            return View();
        }

        // GET: Web/Details/5
        public ActionResult PageIndex(int id)
        {
            var activeuser = _userdata.GetUser(id);
            var model = new WebDTO();
            model.activeUser = activeuser;
            return View(model);
        }
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult dlc()
        {
            var users = _userdata.GetUsers();
            return View(users);
        }
         public ActionResult sed()
        {
            var users = _userdata.GetUsers();
            return View(users);
        }
         public ActionResult dlp()
        {
            var users = _userdata.GetUsers();
            return View(users);
        }
         public ActionResult dec()
        {
            var users = _userdata.GetUsers();
            return View(users);
        }
         public ActionResult vib()
        {
            var users = _userdata.GetUsers();
            return View(users);
        }

        // GET: Web/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Web/Create
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

        // GET: Web/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Web/Edit/5
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

        // GET: Web/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Web/Delete/5
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
