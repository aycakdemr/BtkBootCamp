using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();

        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();

        }
        [HttpGet("getbycategoryid")]
        public IActionResult GetListByCategoryId(int id)
        {
            var result = _productService.GetAllByCategory(id);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();

        }
    }
}
