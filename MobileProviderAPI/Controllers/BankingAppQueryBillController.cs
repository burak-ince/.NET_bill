using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MobileProviderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingAppQueryBillController : ControllerBase
    {
        private readonly List<string> _userList = new List<string> { "user1", "user2", "user3" };

        [HttpGet("QueryBill")]
        [Authorize]
        public IActionResult QueryBill(string subscriberNo, int page = 1, int pageSize = 10)
        {
            if (!_userList.Contains(subscriberNo))
            {
                return Unauthorized();
            }

            // Örnek veri oluşturulması
            var unpaidBills = new Dictionary<string, List<string>>
            {
                { "January", new List<string> { "Bill1", "Bill2" } },
                { "February", new List<string> { "Bill3" } },
                { "March", new List<string> { "Bill4", "Bill5", "Bill6" } }
            };

            var billsNotPaid = unpaidBills.SelectMany(pair => pair.Value.Select(bill => new { Month = pair.Key, Bill = bill }));

            var paginatedBills = billsNotPaid.Skip((page - 1) * pageSize).Take(pageSize);

            return Ok(paginatedBills);
        }
    }
}