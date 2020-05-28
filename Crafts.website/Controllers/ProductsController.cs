using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crafts.website.Models;
using Crafts.website.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crafts.website.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController (JsonfileProductServices productService)
        {
            ProductService = productService;
        }

        public JsonfileProductServices ProductService { get;}
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }
        [Route("rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery]string productId ,
            [FromQuery]int rating)
        {
            ProductService.AddRating(productId, rating);
            return Ok();
        }
    }
}

