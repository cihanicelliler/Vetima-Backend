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
    public class ProductImagesController : ControllerBase
    {
        IProductImagesService _productImagesService;

        public ProductImagesController(IProductImagesService productImagesService)
        {
            _productImagesService = productImagesService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productImagesService.GetAll();
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productImagesService.Get(id);
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getimagesbyproductid")]
        public IActionResult GetImagesById(int id)
        {
            var result = _productImagesService.GetImagesByProductId(id);
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult AddAsync([FromForm(Name = ("Image"))] IFormFile file, [FromForm] ProductImages productImages)
        {
            var result = _productImagesService.Add(file, productImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var productImage = _productImagesService.Get(Id).Data;
            var result = _productImagesService.Delete(productImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int Id)
        {
            var productImage = _productImagesService.Get(Id).Data;
            var result = _productImagesService.Update(file, productImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
