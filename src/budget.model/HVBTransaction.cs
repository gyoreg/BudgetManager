using System;

namespace budget.model
{
    public class HVBTransaction : AccountTransaction
    {
        public string AccountNumber { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime Valuta { get; set; }
        public string Receiver1 { get; set; }
        public string Receiver2 { get; set; }
        public string Note { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
    }
}