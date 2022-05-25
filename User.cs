using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement_V1._0
{
   public class User
   {
      public int Id { get; set; }
      public string userName { get; set; }
      public string password { get; set; }
      public int userType { get; set; }
      public int userState { get; set; }
   }
}
