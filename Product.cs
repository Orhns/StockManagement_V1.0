using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement_V1._0
{
   internal class Product
   {
      public int productId { get; set; }
      public string productName { get; set; }
      public int productCategory { get; set; }
      public double productPrice { get; set; }
      public Boolean productStatus { get; set; }
   }
}
