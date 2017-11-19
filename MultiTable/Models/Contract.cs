using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace MultiTable.Models
{
    public class Contract
    {
        public int ID { get; set; }
        public string Product { get; set; }
        public string Destination { get; set; }
        public int ContractValue { get; set; }
    }
}