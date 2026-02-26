using Microsoft.AspNetCore.Mvc;
using ProductService.Data;
using ProductService.Models;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductDbContext _context;

        public ProductController(ProductDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Products.ToList());
        }



        //[HttpPost]
        //public IActionResult Create(Product product)
        //{
        //    _context.Products.Add(product);
        //    _context.SaveChanges();
        //    return Ok(product);
        //}



        //[HttpPut("{id}")]
        //public IActionResult Update(int id, Product updated)
        //{
        //    var existingProd = _context.Products.Find(id);
        //    if (existingProd == null) return NotFound();

        //    existingProd.Name = updated.Name;
        //    existingProd.Price = updated.Price;

        //    _context.SaveChanges();
        //    return Ok(existingProd);

        //}



    }
}
