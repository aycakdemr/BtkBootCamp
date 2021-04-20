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
    public class OrderStatusesController : ControllerBase
    {
        IOrderStatusService _orderStatustService;

        public OrderStatusesController(IOrderStatusService orderStatusService)
        {
            _orderStatustService = orderStatusService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _orderStatustService.GetAll();
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();

        }
        [HttpPost("add")]
        public IActionResult Add(OrderStatus orderStatus)
        {
            var result = _orderStatustService.Add(orderStatus);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();

        }
        [HttpPost("delete")]
        public IActionResult Delete(OrderStatus orderStatus)
        {
            var result = _orderStatustService.Delete(orderStatus);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();

        }
        [HttpPost("update")]
        public IActionResult Update(OrderStatus orderStatus)
        {
            var result = _orderStatustService.Update(orderStatus);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();

        }
    }
}
