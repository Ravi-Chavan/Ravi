using Sapmple.Models;
using System.Web.Mvc;

namespace Sapmple.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>Disply default View</summary>
        /// <returns>View</returns>
        public ActionResult Index()
        {
            Add model = new Add();
            return View(model);
        }

        /// <summary>Addition of two numbers</summary>
        /// <param name="model">Add</param>
        /// <returns>View</returns>
        [HttpPost]
        public ActionResult Index(Add model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Result = model.FirstNumber + model.SecondNumber;
            }
            return View("Index");
        }
    }
}