using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement_V1._0
{
   internal class ProductDal
   {
      public Product LoadProduct(int ID)
      {
         SqlConnection conn = Connection.GetConnection();
         Product product1 = null;
         SqlCommand cmd;

         string sql = "Select * From Products where productId=@ID";

         try
         {
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            SqlParameterCollection prm = cmd.Parameters;
            prm.AddWithValue("ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               product1 = new Product();
               product1.productId = (int)dr.GetSqlInt32(0);
               product1.productName = (string)dr.GetSqlString(1);
               product1.productCategory = (int)dr.GetSqlInt32(2);
               product1.productPrice = (double)dr.GetDouble(3);
               product1.productStatus = (bool)dr.GetSqlBoolean(4);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
         return product1;
      }
      public int AddProduct(Product addThisProduct)
      {
         SqlConnection conn = Connection.GetConnection();
         SqlCommand cmd;
         string str = "insert into Products (productId, productName, productCategory, productPrice, productStatus) values (@pid, @pname, @pcat, @pprice, @psta)";
         int check = 0;
         try
         {
            conn.Open();
            cmd=new SqlCommand(str, conn);
            SqlParameterCollection prm =cmd.Parameters;
            prm.AddWithValue("pid",addThisProduct.productId);
            prm.AddWithValue("pname",addThisProduct.productName);
            prm.AddWithValue("pcat",addThisProduct.productCategory);
            prm.AddWithValue("pprice",addThisProduct.productPrice);
            prm.AddWithValue("psta",addThisProduct.productStatus);
            cmd.ExecuteNonQuery();
            check = 1;
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         } finally { conn.Close(); }
         return check;
      }

      //public int DeleteProduct(int id)
      //{
      //   SqlConnection conn = Connection.GetConnection();
      //   string str = "DELETE FROM Products WHERE productId=@pid";
      //   SqlCommand cmd = new SqlCommand(str, conn);
      //   SqlParameterCollection prm = cmd.Parameters;
      //   prm.AddWithValue("productId",id);
      //   return 0;
      //}
      public int UpdateProduct(Product prd)
      {
         SqlConnection conn = Connection.GetConnection();
         SqlCommand cmd;
         String str = "UPDATE Products SET productName=@pname, productCategory=@pcat, productPrice=@pprice, productStatus=@psta WHERE productId=@pid";
         int result = 0;
         try
         {
            conn.Open();
            cmd = new SqlCommand(str, conn);
            SqlParameterCollection prm = cmd.Parameters;
            prm.AddWithValue("pid", prd.productId);
            prm.AddWithValue("pname", prd.productName);
            prm.AddWithValue("pcat", prd.productCategory);
            prm.AddWithValue("pprice", prd.productPrice);
            prm.AddWithValue("psta", prd.productStatus);
            result = (int)cmd.ExecuteNonQuery();
         }
         catch (Exception ex)
         {
            MessageBox.Show (ex.Message);
         } finally { conn.Close(); }
         return result;
      }
      public int getProductsCount()
      {
         SqlConnection conn = Connection.GetConnection();
         conn.Open();
         SqlCommand cmd;

         string str = "SELECT COUNT(productId) FROM Products ";
         int c = 0;

         try
         {
            cmd = new SqlCommand(str, conn);
            c = (int)cmd.ExecuteScalar();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         } finally { conn.Close(); }
         
         return c;
      }
      public string getCategoryNames(int ctg)
      {
         List<string> list = new List<string>();
         list.Add("0");
         list.Add("Tatlı");
         list.Add("Tuzlu");
         list.Add("Kahve");
         list.Add("Kişisel bakım");

         string ctgName;

         ctgName = list.ElementAt(ctg);

         return ctgName;
      }

      //to fill dtgridview at prod management form
      public DataTable MngDT_fillSearchByID(string txt, int s)
      {
         string txboxtx = txt;
         string str = "Select productId, ProductName FROM[Products] WHERE[productId] like '" + txboxtx + "%' AND [productStatus] like '" + s + "'";
         SqlConnection con = Connection.GetConnection();
         con.Open();
         SqlDataAdapter sda = new SqlDataAdapter(str, con);
         DataTable dt = new DataTable();
         sda.Fill(dt);
         return dt;
      }
      public DataTable CartDT_fillSearchByID(string txt, int cat)
      {
         string txboxtx = txt;
         string str = "Select ProductName, productPrice FROM[Products] WHERE[productName] like '" + txboxtx + "%' AND [productCategory] like '" + cat + "'";
         SqlConnection con = Connection.GetConnection();
         con.Open();
         SqlDataAdapter sda = new SqlDataAdapter(str, con);
         DataTable dt = new DataTable();
         sda.Fill(dt);
         return dt;
      }
   }
}
