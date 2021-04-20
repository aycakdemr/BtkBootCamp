﻿using Business.Abstract;
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
    public class AddressesController : ControllerBase
    {
        IAddressService _addressService;

        public AddressesController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _addressService.GetAll();
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();

        }
        [HttpPost("add")]
        public IActionResult Add(Address address)
        {
            var result = _addressService.Add(address);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();

        }
        [HttpPost("delete")]
        public IActionResult Delete(Address address)
        {
            var result = _addressService.Delete(address);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();

        }
        [HttpPost("update")]
        public IActionResult Update(Address address)
        {
            var result = _addressService.Update(address);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();

        }
    }
}
