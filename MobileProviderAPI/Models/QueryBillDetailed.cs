using Microsoft.EntityFrameworkCore;

namespace MobileProviderAPI.Models
{
    public class MobileBillDetail
    {
        public int Id { get; set; }
        public string SubscriberNo { get; set; }
        public string Month { get; set; }
        public decimal BillTotal { get; set; }
        public string BillDetails { get; set; }
    }

    public class MobileBillDetailContext : DbContext
    {
        public DbSet<MobileBillDetail> MobileBillDetails { get; set; }
    }
}