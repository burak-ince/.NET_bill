using Microsoft.AspNetCore.Mvc;
using MobileProviderAPI.Models;
using System;
using System.Linq;

namespace MobileProviderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PayBillController : ControllerBase
    {
        private readonly BillContext _context;

        public PayBillController(BillContext context)
        {
            _context = context;
        }

        [HttpPost("PayBill")]
        public IActionResult PayBill(string subscriberNo, string month)
        {
            var bill = _context.Bills.FirstOrDefault(b => b.SubscriberNo == subscriberNo && b.Month == month);

            if (bill == null)
            {
                return NotFound("Bill not found for the specified subscriber and month.");
            }

            // Fatura zaten ödenmişse hata döndür
            if (bill.IsPaid)
            {
                return BadRequest("The bill has already been paid.");
            }

            // Faturayı ödendi olarak işaretle
            bill.IsPaid = true;
            _context.SaveChanges();

            return Ok("Successful");
        }
    }
}