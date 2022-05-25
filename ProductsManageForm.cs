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
   public partial class ProductsManageForm : Form
   {
      public ProductsManageForm()
      {
         InitializeComponent();
      }
      ProductDal prdDal = new ProductDal();
      Product prd;
      public void textBox_searchByIdTxt(object sender, EventArgs e)
      {
         DataTable dt = prdDal.MngDT_fillSearchByID(searchByIdTxt.Text,comboBox1.SelectedIndex);
         dataGridView1.DataSource = dt;
      }
      private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
      {
         button2.Enabled = true;
         int selectedItemsId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
         prd = prdDal.LoadProduct(selectedItemsId);
         textBox_ID.Text = prd.productId.ToString();
         textBox_Name.Text = prd.productName.ToString();
         comboBox_Ctg.SelectedIndex = (int)prd.productCategory;
         textBox_Price.Text = prd.productPrice.ToString();
         bool b = prd.productStatus;
         if (b) {
            comboBox_Status.SelectedIndex = 0;
         } else {
            comboBox_Status.SelectedIndex = 1;
         }   
      }
      private void button_Update_Click(object sender, EventArgs e)
      {
         prd = new Product();
         prd.productId = int.Parse(textBox_ID.Text);
         prd.productName = textBox_Name.Text;
         prd.productCategory = (int)comboBox_Ctg.SelectedIndex;
         prd.productPrice = double.Parse(textBox_Price.Text);
         prd.productStatus = boolValueOfCbox();
         int check = prdDal.UpdateProduct(prd);
         if (check == 1)
         {
            MessageBox.Show("Product Updated Succesfully");
            searchByIdTxt.Text = "";
         }
         else
         {
            MessageBox.Show("Something gone wrong.");
         }
      }
      public bool boolValueOfCbox()
      {
         Boolean b;
         if (comboBox_Status.SelectedIndex == 0)
         {
            b = true;
         }
         else
         {
            b = false;
         }
         return b;
      }
      private void ProductsManageForm_Load(object sender, EventArgs e)
      {
         comboBox1.SelectedIndex = 1;
         DataTable dt = prdDal.MngDT_fillSearchByID(searchByIdTxt.Text, comboBox1.SelectedIndex);
         dataGridView1.DataSource = dt;
      }
      private void button_Add_Click(object sender, EventArgs e)
      {
         createNewProduct();
      }
      private void createNewProduct()
      {
         prd = new Product();
         int newProductsId = prdDal.getProductsCount();
         prd.productId = newProductsId;
         prd.productName = textBox_Name.Text;
         prd.productCategory = (int)comboBox_Ctg.SelectedIndex;
         prd.productPrice = double.Parse(textBox_Price.Text);
         prd.productStatus = boolValueOfCbox();
         int check = prdDal.AddProduct(prd);
         if (check == 1)
         {
            MessageBox.Show("Product Added Succesfully");
            searchByIdTxt.Text = "";
         }
         else
         {
            MessageBox.Show("Something gone wrong.");
         }
      }
      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataTable dt = prdDal.MngDT_fillSearchByID(searchByIdTxt.Text, comboBox1.SelectedIndex);
         dataGridView1.DataSource = dt;
      }
   }
}
