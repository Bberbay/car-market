using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICarsService _carsService;

        public CarsController(ICarsService carsService)
        {
            _carsService = carsService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _carsService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        
        [HttpGet("getlistbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _carsService.GetListByCategory(categoryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        
        [HttpGet("getbyid")]
        public IActionResult GetById(int carsId)
        {
            var result = _carsService.GetById(carsId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        
        [HttpPost("add")]
        public IActionResult Add(Cars cars)
        {
            var result = _carsService.Add(cars);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        
        [HttpPost("update")]
        public IActionResult Update(Cars cars)
        {
            var result = _carsService.Update(cars);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        
        [HttpPost("delete")]
        public IActionResult Delete(Cars cars)
        {
            var result = _carsService.Add(cars);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
