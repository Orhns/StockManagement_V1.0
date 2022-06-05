using System;
using System.Collections;
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
      double totalPrice=0;
      //cart list to hold items to show on listview
      List<CartItem> cartProducts = new List<CartItem>();
      ArrayList listOfAccounts = new ArrayList();
      int selectedAccountNumber;
      //Account Ümit;
      //Account Mansur;
      //Account Meral;
      //Account Ali;
      Account acc;

      private void VirtualCartForm_Load(object sender, EventArgs e)
      {
         fillTable();
         //setting account balance 50 when the form load
         createAccounts();
         
         // burada kaldım yapmaya çalıştığım şey selectedAccountName
         // değişkenini kullanarak listofaccounts listesindeki objelerin değerlerine ulaşmak.
   
         //set listview
         setListView();
         
      }
      public void setListView()
      {
         listView1.Clear();
         listView1.View = View.Details;
         listView1.GridLines = true;
         listView1.FullRowSelect = true;

         //Add column header
         listView1.Columns.Add("ProductName", 100);
         listView1.Columns.Add("Price", 70);
         listView1.Columns.Add("Quantity", 70);

         int i = 0; // counting rows from 0 to end.
         while (i< cartProducts.Count)
         {
            string[] arr = new string[4];
            ListViewItem itm;
            arr[0] = cartProducts[i].getName().ToString();
            arr[1] = cartProducts[i].getPrice().ToString();
            arr[2] = cartProducts[i].getQty().ToString();
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
            i++;
         }
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
         label4.Text = acc.getBalance().ToString();
         textBox2.Text = "";
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
         string itemName;
         double price;
         int qty;
         //getting the values from form to pass into cart item
         itemName = label7.Text.ToString();
         price = double.Parse(label8.Text);
         qty = (int)numericUpDown1.Value;
         // create the cartItem..
         var newCartItem = new CartItem(itemName, price, qty);
         // ..and add it in the list.
         cartProducts.Add(newCartItem);    
      }
      private void button2_AddToCart_Click(object sender, EventArgs e)
      {
         addToCartOpt();
         setListView();
         label7.Text = "-";
         label8.Text = "-";
         numericUpDown1.Value = 1;
         countTotalPrice();
         label11.Text = totalPrice.ToString();
      }

      private void button8_Withdraw_Click(object sender, EventArgs e)
      {
         double amount = double.Parse(textBox1.Text.ToString());
         acc.withDrawMoney(amount);
         label4.Text = acc.getBalance().ToString();
         textBox1.Text = "";
      }

      public void countTotalPrice()
      {
         totalPrice = 0;

         for (int i = 0; i < cartProducts.Count; i++)
         {
            int qty = cartProducts[i].getQty();
            double price = cartProducts[i].getPrice();
            totalPrice += qty * price;
         }
      }

      public void createAccounts()
      {
         
         string hesapAdi1 = "Ümit";
         string hesapAdi2 = "Mansur";
         string hesapAdi3 = "Meral";
         string hesapAdi4 = "Ali";
         Account Ümit = new Account(hesapAdi1, 450);
         Account Mansur = new Account(hesapAdi2, 300);
         Account Meral = new Account(hesapAdi3, 250);
         Account Ali = new Account(hesapAdi4, 500);
         listOfAccounts.Add(Ümit);
         listOfAccounts.Add(Mansur);
         listOfAccounts.Add(Meral);
         listOfAccounts.Add(Ali);
         // ilerde kullanılabilir, şuan böyle bir işleve ihtiyaç yok.
         //while (listOfAccounts.Count<4)
         //{
         //}
      }
      // Alttaki 4 buton hesapları seçerken kullandığımız butonlar.
      private void button3_Click(object sender, EventArgs e)
      {
         selectedAccountNumber = 0;
         changeAccount();
      }

      private void button6_Click(object sender, EventArgs e)
      {
         selectedAccountNumber = 1;
         changeAccount();
      }

      private void button4_Click(object sender, EventArgs e)
      {
         selectedAccountNumber = 2;
         changeAccount();
      }

      private void button5_Click(object sender, EventArgs e)
      {
         selectedAccountNumber = 3;
         changeAccount();
      }
      public void changeAccount()
      {
         acc = (Account)listOfAccounts[selectedAccountNumber];
         label14.Text = acc.getHesapAdi();
         label4.Text = acc.getBalance().ToString();
      }

      private void button7_PurchaseBUTTON_Click(object sender, EventArgs e)
      {
         double a =  double.Parse(label11.Text);
         acc.withDrawMoney(a);
         changeAccount();
         cartProducts.Clear();
         label11.Text = "-";
         setListView();
      }
   }
}
