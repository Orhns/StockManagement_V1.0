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
   public partial class MainMenu : Form
   {
      public MainMenu(LoginForm form, User cuser)
      {
         InitializeComponent();
         loginForm = form;
         user = cuser;
         ud = new UserDAL();
      }
      LoginForm loginForm;
      User user;
      UserDAL ud;
      

      private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
      {
          Application.Exit();
      }

      private void userSettingsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         pContainer.Controls.Clear();
         UserInfoForm usr = new UserInfoForm(user)
         {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
         this.pContainer.Controls.Add(usr);
         usr.Show();
         
      }

      //private void productsToolStripMenuItem_Click(object sender, EventArgs e)
      //{
      //   pContainer.Controls.Clear();
      //   ProductsForm prd = new ProductsForm()
      //   { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
      //   this.pContainer.Controls.Add(prd);
      //   prd.Show();
      //}

      private void showProductsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         pContainer.Controls.Clear();
         ProductsForm prd = new ProductsForm()
         { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
         this.pContainer.Controls.Add(prd);
         prd.Show();
      }

      private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
      {
         pContainer.Controls.Clear();
         ProductsManageForm prdmng = new ProductsManageForm()
         { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
         this.pContainer.Controls.Add(prdmng);
         prdmng.Show();
      }

      private void virtualCartToolStripMenuItem_Click(object sender, EventArgs e)
      {
         pContainer.Controls.Clear();
         VirtualCartForm vrtCart = new VirtualCartForm();
         vrtCart.Show();
      }

      private void MainMenu_Load(object sender, EventArgs e)
      {

      }
   }
}
