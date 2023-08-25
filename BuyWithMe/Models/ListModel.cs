using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWithMe.Models
{
    public  class ListModel
    {
        public string ItemName{ get; set; }
        public decimal ItemPrice { get; set; }
        public short ItemQuantity { get; set; }
        public bool Taxable { get; set; }
    }
}
