using System;
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
   public partial class LoginForm : Form
   {
      public LoginForm()
      {
         InitializeComponent();
      }
      UserDAL userD = new UserDAL();
      public void button_connect_Click(object sender, EventArgs e)
      {
         string n = textBox_name.Text;
         string p = textBox_pass.Text;
         if (userD.Login(n,p)>0)
         {
            MessageBox.Show("Connected.");
            this.Hide();
            MainMenu mainMenu = new MainMenu(this, userD.GetUser(n,p));
            mainMenu.Show();
         }
      }
   }
}
