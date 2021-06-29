using System;
using System.Collections.Generic;
using System.Text;

namespace TDTOAN.Model.Product
{
    public class products
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public int supplierid { get; set; }
        public int categoryid { get; set; }
        public string quantityperunit { get; set; }
        public double unitprice { get; set; }
        public int unitsinstock { get; set; }
        public int unitsonorder { get; set; }
        public int reorderlevel { get; set; }
        public int discontinued { get; set; }
        public int MyProperty { get; set; }
    }
}
