using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement_V1._0
{
   internal class CartItem
   {
      private string itemName;
      private double price;
      private int quantity;

      public CartItem(string name, double price, int quantity)
      {
         this.itemName = name;
         this.price = price;
         this.quantity = quantity;
      }
      public string getName()
      {
         return this.itemName;
      }
      public double getPrice()
      {
         return this.price;
      }
      public int getQty()
      {
         return this.quantity;
      }
   }
}
