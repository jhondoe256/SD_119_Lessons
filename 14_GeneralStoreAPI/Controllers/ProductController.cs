using _14_GeneralStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _14_GeneralStoreAPI.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> CreateProduct(ProductCreate model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (model.QuantityInStock < 0)
            {
                return BadRequest("Quantity in stock must not be a negative number");
            }

            Product product = new Product()
            {
                SKU = model.SKU,
                Name = model.Name,
                Price = model.Price,
                QuantityInStock = model.QuantityInStock
            };

            _context.Products.Add(product);
            if (await _context.SaveChangesAsync() == 1) return Ok();
            return InternalServerError();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAllProducts()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetProductById([FromUri] string id)
        {
            Product product = await _context.Products.FindAsync(id);

            if (product == null) return NotFound();
            
            return Ok(product);
        }

        [HttpPut]
        [ActionName("Update")]
        public async Task<IHttpActionResult> UpdateProduct([FromUri] string id, [FromBody] ProductEdit model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            Product product = await _context.Products.FindAsync(id);

            if (product == null) return NotFound();

            product.Name = model.Name;
            product.Price = model.Price;

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        [ActionName("Restock")]
        public async Task<IHttpActionResult> RestockProduct([FromUri] string id, [FromBody] ProductRestock model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            Product product = await _context.Products.FindAsync(id);

            if (product == null) return NotFound();

            if (model.Quantity <= 0) return BadRequest("Restock quantity must be greater than 0");

            product.QuantityInStock += model.Quantity;

            RestockLog restockLog = new RestockLog()
            {
                ProductSKU = id,
                Quantity = model.Quantity,
                DateOfRestock = DateTime.Now
            };
            _context.RestockLogs.Add(restockLog);

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
