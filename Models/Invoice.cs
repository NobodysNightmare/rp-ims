using System;
using System.Collections.Generic;

namespace rp_ims.Pages.Models
{
    public enum InvoiceState
    {
        Draft,
        Open,
        Paid
    }

    public class Invoice
    {
        public int ID { get; set; }
        public InvoiceState State { get; set; }
        public DateTime CreatedAt { get; set; }
        // public int CreatorID { get; set; }
        // public User Creator { get; set; }
        public ICollection<LineItem> LineItems { get; set; }
    }
}