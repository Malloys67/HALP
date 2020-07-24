using System;
using System.Collections.Generic;
using System.Text;

namespace HALP
{
    public class Transaction
    {
        public int ID { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
    }
}
