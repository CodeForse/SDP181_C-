using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    class Request
    {
        public enum RequestType {SALES,SALESIMS,STORED,MOVING,GOOD_RECEIPT}

        public int Kunnr { get; set; }
        public int Burks { get; set; }
        public int Werks { get; set; }
        public int Data1 { get; set; }
        public int Data2 { get; set; }
    }
}
