using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarCRUD.Models;
using CarCRUD.Repositories;

namespace CarCRUD.Controllers
{
    [Route("api/car-parts")]
    [ApiController]
    public class ApiCarPartController : ControllerBase
    {
        private PartRepository _repo;
        public ApiCarPartController(PartRepository repo)
        {
            _repo = repo;
        }

        [Route("get")]
        public ActionResult GetOption(int id)
        {
            var result = _repo.Get(id);
            return Ok(result);
        }
        [Route("list")]
        public ActionResult ListOption()
        {
            var result = _repo.List();
            return Ok(result);
        }
        [Route("create")]
        [HttpPost]
        public ActionResult CreateOption(CarPart Model)
        {
            _repo.Create(Model);
            return Ok(Model);
        }
        [Route("delete")]
        [HttpDelete]
        public ActionResult DeleteOption(int id)
        {
            _repo.Delete(id);
            return Ok();
        }
        [Route("update")]
        [HttpPut]
        public ActionResult UpdateOption(CarPart Model, int id)
        {
            _repo.Update(id, Model);
            return Ok();
        }
    }
}
