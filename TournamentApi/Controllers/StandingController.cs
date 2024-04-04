using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TournamentApi.Controllers
{
    public class StandingController : Controller
    {
        // GET: StandingController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StandingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StandingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StandingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StandingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StandingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StandingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StandingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
