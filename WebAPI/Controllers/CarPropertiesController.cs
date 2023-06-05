using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Core.Resolving.Middleware;
using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPropertiesController : ControllerBase
    {
        private ICarPropertiesService _carPropertiesService;

        public CarPropertiesController(ICarPropertiesService carPropertiesService)
        {
            _carPropertiesService = carPropertiesService;
        }

        [DisableCors]
        [HttpGet("all")]
        public IActionResult GetList()
        {
            var result = _carPropertiesService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        
        [DisableCors]
        [HttpPost("car-property-add")]
        public IActionResult Add(CarPropertyAddDto carPropertyAddDto)
        {
            var result = _carPropertiesService.Add(carPropertyAddDto);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
