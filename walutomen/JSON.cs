using System;
using System.Collections.Generic;
using System.Text;

namespace walutomen
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Rate
    {
        public string no { get; set; }
        public string effectiveDate { get; set; }
        public double mid { get; set; }
    }

    public class JSON
    {
        public string table { get; set; }
        public string currency { get; set; }
        public string code { get; set; }
        public List<Rate> rates { get; set; }
    }

}
