using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace StockManagement_V1._0
{
   public class Connection
   {
      public static SqlConnection GetConnection()
      {
         string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                           AttachDbFilename=C:\Users\Sarunas\source\repos\StockManagement_V1.0\StockM_V1.0_Db.mdf;
                           Integrated Security=True;Connect Timeout=30";

         SqlConnection connection = new SqlConnection(connString);
         return connection;
      }
   }
}
