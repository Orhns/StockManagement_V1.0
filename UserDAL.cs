using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockManagement_V1._0
{
   internal class UserDAL
   {
      public int Login(string name, string pass)
      {
         SqlConnection conn = Connection.GetConnection(); 
         conn.Open();
         SqlCommand cmd;
         string userCheckStr = "SELECT COUNT (userName) FROM Users WHERE (userName=@name) AND (password=@pass)";
         
         int x = 0;
         try
         {
            
            cmd = new SqlCommand(userCheckStr, conn);
            SqlParameterCollection parms = cmd.Parameters;
            parms.AddWithValue("name", name);
            parms.AddWithValue("pass", pass);
            x = (int)cmd.ExecuteScalar();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         } 
         finally {   
            conn.Close(); 
         }
         return x;
      }
      public User GetUser(string name, string pass)
      {
         SqlConnection connection = Connection.GetConnection();
         
         User userx = null;
         SqlCommand cmd;
         string str = "select [id],[userType],[userState] from Users where (userName = @name) AND (password = @pass)";

         try
         {
            connection.Open();
            cmd = new SqlCommand(str, connection);
            SqlParameterCollection spar = cmd.Parameters;
            spar.AddWithValue("name", name);
            spar.AddWithValue("pass", pass);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
               userx = new User();
               userx.Id = (int)rdr.GetSqlInt32(0);
               userx.userName = name;
               userx.password = pass;
               userx.userType = (int)rdr.GetSqlInt32(1);
               userx.userState = (int)rdr.GetSqlInt32(2);

            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection.Close();
         }
         return userx;
      }
      public User GetById(int ID) 
      {
         SqlConnection conn = Connection.GetConnection();
         SqlCommand cmd;
         User usery = null;
         string str = "SELECT [userName], [password], [userType], [userState] FROM Users WHERE ID=@id";
         try
         {
            conn.Open();
            cmd = new SqlCommand(str, conn);
            SqlParameterCollection sp = cmd.Parameters;
            sp.AddWithValue("id", ID);
            
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
               usery = new User();
               usery.Id = ID;
               usery.userName = rdr.GetString(0);
               usery.password = rdr.GetString(1);
               usery.userType = (int)rdr.GetSqlInt32(2);
               usery.userState = (int)rdr.GetSqlInt32(3);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally { conn.Close(); }  
         return usery;
      }
      public int UpdateUser(int id2, string name2, string pass2, int utype2, int ustate2,User user)
      {
         SqlConnection conn = Connection.GetConnection();
         SqlCommand cmd;
         string sql = "UPDATE Users SET userName=@uname, password=@upass, userType=@utype, userState=@usta WHERE Id=@id";
         int result = 0;
         try
         {
            conn.Open();
            cmd =new SqlCommand(sql, conn);
            SqlParameterCollection prm = cmd.Parameters;
            prm.AddWithValue("id", user.Id);
            prm.AddWithValue("uname", name2);
            prm.AddWithValue("upass", pass2);
            prm.AddWithValue("utype", utype2);
            prm.AddWithValue("usta", ustate2);
            result = (int)cmd.ExecuteNonQuery();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally { conn.Close(); }
         return result;
      }
   }

   
}
