using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement_V1._0
{
   public partial class ProductsForm : Form
   {
      public ProductsForm()
      {
         InitializeComponent();
      }
      ProductDal Dal = new ProductDal();
      Product prd;
      private void ProductsForm_Load(object sender, EventArgs e)
      {
         fillProductTable();
      }
      
     private void fillProductTable()
      {
         //getting total numbers of the rows in table
         int totalRows = Dal.getProductsCount();

         for (int i = 0; i < totalRows; i++)
         {
         prd = Dal.LoadProduct(i);

         int id = prd.productId;
         string pName = prd.productName;
         int pCategory = prd.productCategory;
         double pPrice = prd.productPrice;
         bool pStatus = prd.productStatus;

         //getting category name
         string cName = Dal.getCategoryNames(pCategory);
         //adding rows to table
         dataGridView_products.Rows.Add();
         dataGridView_products.Rows[i].Cells[0].Value = id;
         dataGridView_products.Rows[i].Cells[1].Value = pName;
         dataGridView_products.Rows[i].Cells[2].Value = cName;
         dataGridView_products.Rows[i].Cells[3].Value = pPrice;
         dataGridView_products.Rows[i].Cells[4].Value = pStatus;
         }
      }

      //COMBO BOX DEĞİŞTİĞİNDE TABLOYU DEĞİŞTİRMESİ GEREKEN METHOD

      private void buttonFilterCategory(object sender, EventArgs e)
      {
         if (comboBox1.SelectedIndex == 0)
         {
            dataGridView_products.Rows.Clear();
            dataGridView_products.Refresh();
            fillProductTable();
         }
         else
         {
            fillProductTableByCategory();
         }
      }

      private void fillProductTableByCategory()
      {
         dataGridView_products.Rows.Clear();
         dataGridView_products.Refresh();
         int selected = comboBox1.SelectedIndex;
         int totalRows = Dal.getProductsCount();
         int helperToRow = 0;
         for (int i = 0; i < totalRows; i++)
         {
            prd = Dal.LoadProduct(i);
            if (prd.productCategory == selected)
            {
               int id = prd.productId;
               string pName = prd.productName;
               int pCategory = prd.productCategory;
               double pPrice = prd.productPrice;
               bool pStatus = prd.productStatus;

               //getting category name
               string cName = Dal.getCategoryNames(pCategory);
               //adding rows to table
               dataGridView_products.Rows.Add();
               dataGridView_products.Rows[helperToRow].Cells[0].Value = id;
               dataGridView_products.Rows[helperToRow].Cells[1].Value = pName;
               dataGridView_products.Rows[helperToRow].Cells[2].Value = cName;
               dataGridView_products.Rows[helperToRow].Cells[3].Value = pPrice;
               dataGridView_products.Rows[helperToRow].Cells[4].Value = pStatus;
               helperToRow++;
            }
         }
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {
         String textBoxId = textBox1.Text;
         if (textBoxId == "")
         {
            fillProductTable();
            buttonRefresh.Focus();
         }
         else
         {
            int sendedId = int.Parse(textBoxId);
            getRowsById(sendedId);
         }
      } 

      private void getRowsById(int id)
      {
         dataGridView_products.Rows.Clear();
         dataGridView_products.Refresh();
         int totalRows = Dal.getProductsCount();
         int helperToRow = 0;
         for (int i = 0; i < totalRows; i++)
         {
            prd = Dal.LoadProduct(i);
            if (prd.productId == id)
            {
               int idd = prd.productId;
               string pName = prd.productName;
               int pCategory = prd.productCategory;
               double pPrice = prd.productPrice;
               bool pStatus = prd.productStatus;

               //getting category name
               string cName = Dal.getCategoryNames(pCategory);
               //adding rows to table
               dataGridView_products.Rows.Add();
               dataGridView_products.Rows[helperToRow].Cells[0].Value = idd;
               dataGridView_products.Rows[helperToRow].Cells[1].Value = pName;
               dataGridView_products.Rows[helperToRow].Cells[2].Value = cName;
               dataGridView_products.Rows[helperToRow].Cells[3].Value = pPrice;
               dataGridView_products.Rows[helperToRow].Cells[4].Value = pStatus;
               helperToRow++;
            }
         }


      }

      private void checkBox1_CheckStateChanged(object sender, EventArgs e)
      {
         if (checkBox1.Checked)
         {
            dataGridView_products.Rows.Clear();
            dataGridView_products.Refresh();
            int totalRows = Dal.getProductsCount();
            int helperToRow = 0;
            for (int i = 0; i < totalRows; i++)
            {
               prd = Dal.LoadProduct(i);
               if (prd.productStatus == true)
               {
                  int idd = prd.productId;
                  string pName = prd.productName;
                  int pCategory = prd.productCategory;
                  double pPrice = prd.productPrice;
                  bool pStatus = prd.productStatus;

                  //getting category name
                  string cName = Dal.getCategoryNames(pCategory);
                  //adding rows to table
                  dataGridView_products.Rows.Add();
                  dataGridView_products.Rows[helperToRow].Cells[0].Value = idd;
                  dataGridView_products.Rows[helperToRow].Cells[1].Value = pName;
                  dataGridView_products.Rows[helperToRow].Cells[2].Value = cName;
                  dataGridView_products.Rows[helperToRow].Cells[3].Value = pPrice;
                  dataGridView_products.Rows[helperToRow].Cells[4].Value = pStatus;
                  helperToRow++;
               }
            }
         }
         else
         {
            dataGridView_products.Rows.Clear();
            dataGridView_products.Refresh();
            int totalRows = Dal.getProductsCount();
            int helperToRow = 0;
            for (int i = 0; i < totalRows; i++)
            {
               prd = Dal.LoadProduct(i);
               if (prd.productStatus == false)
               {
                  int idd = prd.productId;
                  string pName = prd.productName;
                  int pCategory = prd.productCategory;
                  double pPrice = prd.productPrice;
                  bool pStatus = prd.productStatus;

                  //getting category name
                  string cName = Dal.getCategoryNames(pCategory);
                  //adding rows to table
                  dataGridView_products.Rows.Add();
                  dataGridView_products.Rows[helperToRow].Cells[0].Value = idd;
                  dataGridView_products.Rows[helperToRow].Cells[1].Value = pName;
                  dataGridView_products.Rows[helperToRow].Cells[2].Value = cName;
                  dataGridView_products.Rows[helperToRow].Cells[3].Value = pPrice;
                  dataGridView_products.Rows[helperToRow].Cells[4].Value = pStatus;
                  helperToRow++;
               }
            }
         }
      }

      private void buttonRefresh_Click(object sender, EventArgs e)
      {
         dataGridView_products.Rows.Clear();
         dataGridView_products.Refresh();
         textBox1.Clear();
         comboBox1.ResetText();
         checkBox1.Checked = false ;
         fillProductTable();
      }
   }
}
