using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockManagement_V1._0
{
   public partial class UserInfoForm : Form
   {
      public UserInfoForm(User user)
      {
         InitializeComponent();
         ud = new UserDAL();
         userR = user;
      }
         UserDAL ud;
         User userR;
      Boolean isUpdated = false;

      //Formu update edip tekrar açınca yine eski verileri çağırıyor, reload() düzgün çalışıyor. Hata düzeltiecek.
      private void UserInfoForm_Load(object sender, EventArgs e)
      {
         if (isUpdated == true)
         {
            reload();
         }
         else
         {
            string uname = userR.userName;
            string upass = userR.password;
            ud.GetUser(uname, upass);

            textBox_ID.Text = userR.Id.ToString();
            textBox_uName.Text = userR.userName.ToString();
            textBox_password.Text = userR.password.ToString();
            comboBox_uType.SelectedIndex = (int)userR.userType;
            comboBox_status.SelectedIndex = (int)userR.userState;
         }
         
      }

      private void button_update_Click(object sender, EventArgs e)
      {
         int Id1 = int.Parse(textBox_ID.Text);
         string uname1 = textBox_uName.Text;
         string upass1 = textBox_password.Text;
         int usertype1 = comboBox_uType.SelectedIndex;
         int status1 = comboBox_status.SelectedIndex;
         int x = ud.UpdateUser(Id1,uname1,upass1,usertype1,status1, userR);
      
         if (x > 0)
         {
            isUpdated = true;
            MessageBox.Show("User info is updated Successfully.");
            this.Hide();
         }
         else
         {
            MessageBox.Show("User info couldn't updated.");
         }
      }
      public void clearForm()
      {
         textBox_uName.Text = "";
         textBox_password.Text = "";
         comboBox_status.SelectedIndex=0;
         comboBox_uType.SelectedIndex=0;
      }

      private void button_reload_Click(object sender, EventArgs e)
      {
         reload();
      }

      public void reload()
      {
         int ID = userR.Id;
         userR = ud.GetById(ID);
         textBox_uName.Text = userR.userName;
         textBox_password.Text = userR.password;
         comboBox_uType.SelectedIndex = (int)userR.userType;
         comboBox_status.SelectedIndex = (int)userR.userState;
      }
   }
}
