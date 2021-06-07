using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paytabsPT_2Server.Controllers {
    public class SuccessController : Controller {
        // GET: SuccessController
        public ActionResult Index() {
            return View();
        }

        // GET: SuccessController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: SuccessController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: SuccessController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: SuccessController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: SuccessController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: SuccessController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: SuccessController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }
    }
}
