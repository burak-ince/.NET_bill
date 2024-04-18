using Microsoft.EntityFrameworkCore;

namespace MobileProviderAPI.Models
{
    public class MobileBill
    {
        public int Id { get; set; }
        public string SubscriberNo { get; set; }
        public string Month { get; set; }
        public decimal BillTotal { get; set; }
        public bool PaidStatus { get; set; }
    }

    public class MobileBillContext : DbContext
    {
        public DbSet<MobileBill> MobileBills { get; set; }

   }
}