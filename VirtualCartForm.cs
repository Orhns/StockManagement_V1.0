﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement_V1._0
{
   public partial class VirtualCartForm : Form
   {
      public VirtualCartForm()
      {
         InitializeComponent();
      }
      ProductDal prdDal = new ProductDal();
      Account acc = new Account();
      double totalPrice=0;
      private void VirtualCartForm_Load(object sender, EventArgs e)
      {
         fillTable();

         //setting account balance 50 when the form load
         acc.Balance = 50;
         label4.Text = acc.Balance.ToString();
      }
      private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
      {
         fillTable();
      }
      private void prodNameText_TextChanged(object sender, EventArgs e)
      {
         fillTable();
      }
      public void fillTable()
      {
         string name = prodNameText.Text;
         DataTable dt = prdDal.CartDT_fillSearchByID(name, comboBoxCategory.SelectedIndex);
         dataGridView1.DataSource = dt;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         double amount = double.Parse(textBox2.Text.ToString());
         acc.addMoney(amount);
         label4.Text = acc.Balance.ToString();
      }

      private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
      {
         string selectedItemsName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
         double selectedItemsPrice = double.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
         label7.Text = selectedItemsName;
         label8.Text = selectedItemsPrice.ToString();
  
      }
      public void addToCartOpt()
      {
         listView1.Controls.Add(label7);
      }

      private void button2_Click(object sender, EventArgs e)
      {
         addToCartOpt();
      }
   }
}