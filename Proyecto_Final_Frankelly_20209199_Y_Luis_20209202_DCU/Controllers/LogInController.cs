using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLayer;
using ServicesLayer;

namespace Proyecto_Final_Frankelly_20209199_Y_Luis_20209202_DCU.Controllers
{
    public class LogInController : Controller
    {
        private UserDataService _userdata = new UserDataService();
        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserVerification(string Email, string Password)
        {
            var ValidCredentials = false;
            var users = _userdata.GetUsers();
            foreach(var user in users)
            {
                if (user.Email.ToUpper().Equals(Email.ToUpper()) && user.Password.Equals(Password)) ValidCredentials = true;
            }
            return ValidCredentials ? RedirectToAction("details") : RedirectToAction("index");
        }

        // GET: LogIn/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogIn/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogIn/Create
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

        // GET: LogIn/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogIn/Edit/5
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

        // GET: LogIn/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogIn/Delete/5
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
