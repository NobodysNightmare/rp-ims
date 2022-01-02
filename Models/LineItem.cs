using System;

namespace rp_ims.Pages.Models
{
    public class LineItem
    {
        public int ID { get; set; }
        public int InvoiceID { get; set; }
        public Invoice Invoice { get; set; }
        public string description { get; set; }
        public decimal amount { get; set; }
    }
}