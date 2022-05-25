using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement_V1._0
{
   internal class Account
   {
      public string HesapAdi { get; set; }
      public double Balance { get; set; }

      public double addMoney(double amount) { 
         this.Balance = Balance + amount;
         return Balance; 
      }
   }
}
