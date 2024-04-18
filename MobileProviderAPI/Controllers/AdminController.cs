using Microsoft.AspNetCore.Mvc;
using MobileProviderAPI.Models;

namespace MobileProviderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly BillContext _context;

        public AdminController(BillContext context)
        {
            _context = context;
        }

        [HttpPost("AddBill")]
        public IActionResult AddBill(string subscriberNo, string month)
        {
            // Veritabanına yeni bir fatura ekleyin
            var bill = new Bill
            {
                SubscriberNo = subscriberNo,
                Month = month,
                Amount = 100.00m, // Örnek bir fatura tutarı
                IsPaid = false // Fatura henüz ödenmemiş
            };

            _context.Bills.Add(bill);
            _context.SaveChanges();

            return Ok("Transaction status: Success");
        }
    }
}