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
    public class TransactionController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> Purchase(TransactionCreate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (model.ItemCount <= 0) return BadRequest("Purchase quantity must be greater than 0");

            Customer customer = await _context.Customers.FindAsync(model.CustomerId);
            if (customer == null) return BadRequest($"Invalid Customer ID: {model.CustomerId}");

            Product product = await _context.Products.FindAsync(model.ProductSKU);
            if (product == null) return BadRequest($"Invalid Product SKU: {model.ProductSKU}");

            if (!product.IsInStock) return BadRequest($"I'm sorry, we're all out of {product.Name}");

            if (product.QuantityInStock < model.ItemCount) return BadRequest($"Not enough {product.Name} in stock");

            product.QuantityInStock -= model.ItemCount;
            Transaction transaction = new Transaction()
            {
                ProductSKU = model.ProductSKU,
                CustomerId = model.CustomerId,
                ItemCount = model.ItemCount,
                DateOfTransaction = DateTime.Now,
            };

            _context.Transactions.Add(transaction);

            if (await _context.SaveChangesAsync() == 2) return Ok();
            return InternalServerError();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAllTranasactions()
        {
            List<Transaction> transactions = await _context.Transactions.ToListAsync();

            List<TransactionListItem> transactionList = transactions.Select(
                t => new TransactionListItem()
                {
                    TransactionId = t.Id,
                    ProductName = t.Product.Name,
                    CustomerName = t.Customer.FullName,
                    DateOfTransaction = t.DateOfTransaction,
                    Quantity = t.ItemCount,
                    TotalCost = (t.ItemCount * t.Product.Price)
                }
                ).ToList();

            List<TransactionListItem> transactionList2 = transactions.Select(
                t => {
                    double totalCost = t.ItemCount * t.Product.Price;

                    return new TransactionListItem()
                    {
                        TransactionId = t.Id,
                        ProductName = t.Product.Name,
                        CustomerName = t.Customer.FullName,
                        DateOfTransaction = t.DateOfTransaction,
                        Quantity = t.ItemCount,
                        TotalCost = totalCost
                    };
                }
                ).ToList();

            return Ok(transactionList);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetTransactionById(int id)
        {
            Transaction transaction = await _context.Transactions.FindAsync(id);
            TransactionDetail transactionDetail = new TransactionDetail()
            {
                TransactionId = transaction.Id,
                ProductSKU = transaction.Product.SKU,
                ProductName = transaction.Product.Name,
                CustomerId = transaction.CustomerId,
                CustomerName = transaction.Customer.FullName,
                DateOfTransaction = transaction.DateOfTransaction,
                Quantity = transaction.ItemCount,
                TotalCost = (transaction.ItemCount * transaction.Product.Price)
            };
            return Ok(transactionDetail);
        }
    }
}
