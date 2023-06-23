using Microsoft.AspNetCore.Mvc;
using Szkolenie_techniczne_3_projekt.Models;
using Szkolenie_techniczne_3_projekt.Services.Interfaces;

namespace Szkolenie_techniczne_3_projekt.Controllers
{
    public class TeachersController : Controller
    {

        private readonly ITeachersService _teachersService;

        public TeachersController(ITeachersService teachersService)
        {
            _teachersService = teachersService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Teachers body)
        {
            if (!ModelState.IsValid)
            {
                return View(body);
            }
            var id = _teachersService.Save(body);
            TempData["TeachersId"] = id;
            return RedirectToAction("list");
        }

        [HttpGet]
        public IActionResult List()
        {
            var teachers = _teachersService.GetAll();
            return View(teachers);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var teachers = _teachersService.Get(id);
            return View(teachers);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _teachersService.Delete(id);
            return RedirectToAction("list");
        }
    }
}
