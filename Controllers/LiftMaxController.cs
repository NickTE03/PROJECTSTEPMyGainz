using PROJECTSTEP101010.Models;
using Microsoft.AspNetCore.Mvc;


namespace PROJECTSTEP101010.Controllers
{
    public class LiftMaxController : Controller
    {
        // Methods

        // Create
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(LiftMax e)
        {
             return RedirectToAction("Details", e);
        }

        public IActionResult Details(LiftMax e)
        {
            return View(e);
        }

        [HttpGet]

        public IActionResult Edit(int Id)
        {
            LiftMax e = new LiftMax();
            e.Id = Id;
            e.Date = null;
            e.Name = "Bench Press";
            e.Weight = 315;
            return View(e);

        }

        [HttpPost]

        public IActionResult Edit(LiftMax e)
        {
            return RedirectToAction("Details", e);
        }

       

        // Read

        // Update

        // Delete
    }
}
