using Microsoft.AspNetCore.Mvc;
using MobileProviderAPI.Models;
using System.Linq;

namespace MobileProviderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MobileBillController : ControllerBase
    {
        private readonly MobileBillContext _billContext;
        private readonly MobileBillDetailContext _detailContext;

        public MobileBillController(MobileBillContext billContext, MobileBillDetailContext detailContext)
        {
            _billContext = billContext;
            _detailContext = detailContext;
        }

        [HttpGet("QueryBill")]
        public IActionResult QueryBill(string subscriberNo, string month)
        {
            var mobileBill = _billContext.MobileBills.FirstOrDefault(b => b.SubscriberNo == subscriberNo && b.Month == month);

            if (mobileBill == null)
            {
                return NotFound();
            }

            return Ok(new { mobileBill.BillTotal, mobileBill.PaidStatus });
        }

        [HttpGet("QueryBillDetailed")]
        public IActionResult QueryBillDetailed(string subscriberNo, string month)
        {
            var mobileBillDetail = _detailContext.MobileBillDetails.FirstOrDefault(b => b.SubscriberNo == subscriberNo && b.Month == month);

            if (mobileBillDetail == null)
            {
                return NotFound();
            }

            return Ok(new { mobileBillDetail.BillTotal, mobileBillDetail.BillDetails });
        }
    }
}