using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_walut___email
{
    public class SenderConfig
    {
        public string smtpServer { get; set; }
        public int port { get; set; }
        public string email { get; set; }
        public string key { get; set; }
        public int interval { get; set; }
    }

    public class json
    {
        public SenderConfig senderConfig { get; set; }
        public string email { get; set; }
    }

    public class Rate
    {
        public string no { get; set; }
        public string effectiveDate { get; set; }
        public double mid { get; set; }
    }

    public class currencyJson
    {
        public string table { get; set; }
        public string currency { get; set; }
        public string code { get; set; }
        public List<Rate> rates { get; set; }
    }

    public class RateCurrencyTable
    {
        public string currency { get; set; }
        public string code { get; set; }
        public double mid { get; set; }
    }

    public class currencyTableJson
    {
        public string table { get; set; }
        public string no { get; set; }
        public string effectiveDate { get; set; }
        public List<RateCurrencyTable> rates { get; set; }
    }

}
