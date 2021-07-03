using System;
using System.Collections.Generic;
using System.Text;

namespace OKExV5Vendor.API.REST.Models
{
    interface IOKExQuote
    {
        public double? AskPrice { get; }
        public double? AskSize { get; }
        public double? BidPrice { get; }
        public double? BidSize { get; }

        public DateTime Time { get; }
    }
}
