using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyWithMe.Models
{
    public class SelectItemsModel
    {
        public string uUniqeID { get; set; }
        public string sItemName { get; set; }
        public decimal dItemPrice { get; set; }
        public short iItemQuantity { get; set; }
        public string sAddedBy { get; set; }
        public DateTime tAddedDate { get; set; }
        public string sUpdatedBy { get; set; }
        public DateTime tUpdatedDate { get; set; }
        public bool bDeletedIndicator { get; set; }
    }
}
