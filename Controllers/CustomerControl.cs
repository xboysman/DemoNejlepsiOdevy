using DemoNejlepsiOdevy.Context;
using DemoNejlepsiOdevy.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoNejlepsiOdevy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerControl : Controller
    {
        private readonly CRUDContext _context;

        public CustomerControl(CRUDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        [HttpGet("Date", Name = "Get Customers by Date")]
        public async Task<IEnumerable<Customer>> GetCustomersByDate(DateTime from, DateTime to)
        {
            return await _context.Customers.Where(c => from >= c.VisitDateTime && c.VisitDateTime <= to).ToListAsync();
        }

        [HttpPost("InsertSingle", Name = "Insert One")]
        public async Task InsertSingle(Customer c)
        {
            _context.Customers.Add(c);
            await _context.SaveChangesAsync();
        }

        [HttpPost("InsertMultiple", Name = "Insert Multiple")]
        public async Task InsertMultiple(List<Customer> listofcustomers)
        {
            foreach (var item in listofcustomers)
                _context.Customers.Add(item);

            await _context.SaveChangesAsync();
        }
    }
}
