using Microsoft.EntityFrameworkCore;

namespace MobileProviderAPI.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public string SubscriberNo { get; set; }
        public string Month { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
    }

    public class BillContext : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
    }
}