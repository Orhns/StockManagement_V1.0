using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement_V1._0
{
   internal class Account
   {
      public string hesapAdi;
      private double balance;

      public Account(string h, double b)
      {
         this.hesapAdi = h;
         this.balance = b;
      }
      public double addMoney(double amount) { 
         this.balance = balance + amount;
         return this.balance; 
      }
      public double withDrawMoney(double amount)
      {
         this.balance = balance - amount;
         return this.balance;
      }
      public double getBalance()
      {
         return this.balance;
      }
      public string getHesapAdi()
      {
         return this.hesapAdi;
      }
   }
}
