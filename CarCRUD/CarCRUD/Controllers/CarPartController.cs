using CarCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarCRUD.Repositories;

namespace CarCRUD.Views
{
    [Route("car-parts")]
    public class CarPartController : Controller
    {
        private PartRepository _repo;
        public CarPartController(PartRepository repo)
        {
            _repo = repo;
        }
        [Route("")]
        public IActionResult Index()
        {
            var carPartList = _repo.List();
            return View("index", carPartList);
        }
        [Route("create")]
        public IActionResult AddPart()
        {
            return View("addPart");
        }
    }
}
