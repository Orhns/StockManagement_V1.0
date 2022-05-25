namespace StockManagement_V1._0
{
   partial class UserInfoForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.button_reload = new System.Windows.Forms.Button();
         this.textBox_password = new System.Windows.Forms.TextBox();
         this.textBox_uName = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.comboBox_uType = new System.Windows.Forms.ComboBox();
         this.comboBox_status = new System.Windows.Forms.ComboBox();
         this.label6 = new System.Windows.Forms.Label();
         this.textBox_ID = new System.Windows.Forms.TextBox();
         this.button_update = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // button_reload
         // 
         this.button_reload.BackColor = System.Drawing.Color.Aquamarine;
         this.button_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button_reload.Location = new System.Drawing.Point(44, 281);
         this.button_reload.Name = "button_reload";
         this.button_reload.Size = new System.Drawing.Size(103, 42);
         this.button_reload.TabIndex = 9;
         this.button_reload.Text = "Reload";
         this.button_reload.UseVisualStyleBackColor = false;
         this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
         // 
         // textBox_password
         // 
         this.textBox_password.Location = new System.Drawing.Point(165, 133);
         this.textBox_password.Name = "textBox_password";
         this.textBox_password.Size = new System.Drawing.Size(145, 22);
         this.textBox_password.TabIndex = 8;
         // 
         // textBox_uName
         // 
         this.textBox_uName.Location = new System.Drawing.Point(165, 90);
         this.textBox_uName.Name = "textBox_uName";
         this.textBox_uName.Size = new System.Drawing.Size(145, 22);
         this.textBox_uName.TabIndex = 7;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(44, 135);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(103, 20);
         this.label2.TabIndex = 6;
         this.label2.Text = "Password :";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(44, 90);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(115, 20);
         this.label1.TabIndex = 5;
         this.label1.Text = "User Name :";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(44, 227);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(127, 20);
         this.label3.TabIndex = 11;
         this.label3.Text = "User Status : ";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(44, 176);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(107, 20);
         this.label5.TabIndex = 14;
         this.label5.Text = "User Type :";
         // 
         // comboBox_uType
         // 
         this.comboBox_uType.FormattingEnabled = true;
         this.comboBox_uType.Items.AddRange(new object[] {
            "Normal User",
            "Admin"});
         this.comboBox_uType.Location = new System.Drawing.Point(165, 176);
         this.comboBox_uType.Name = "comboBox_uType";
         this.comboBox_uType.Size = new System.Drawing.Size(145, 24);
         this.comboBox_uType.TabIndex = 15;
         // 
         // comboBox_status
         // 
         this.comboBox_status.FormattingEnabled = true;
         this.comboBox_status.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
         this.comboBox_status.Location = new System.Drawing.Point(165, 222);
         this.comboBox_status.Name = "comboBox_status";
         this.comboBox_status.Size = new System.Drawing.Size(145, 24);
         this.comboBox_status.TabIndex = 16;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(44, 48);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(40, 20);
         this.label6.TabIndex = 17;
         this.label6.Text = "ID :";
         // 
         // textBox_ID
         // 
         this.textBox_ID.Enabled = false;
         this.textBox_ID.Location = new System.Drawing.Point(165, 46);
         this.textBox_ID.Name = "textBox_ID";
         this.textBox_ID.Size = new System.Drawing.Size(145, 22);
         this.textBox_ID.TabIndex = 18;
         // 
         // button_update
         // 
         this.button_update.BackColor = System.Drawing.Color.RoyalBlue;
         this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button_update.Location = new System.Drawing.Point(207, 281);
         this.button_update.Name = "button_update";
         this.button_update.Size = new System.Drawing.Size(103, 42);
         this.button_update.TabIndex = 19;
         this.button_update.Text = "Update";
         this.button_update.UseVisualStyleBackColor = false;
         this.button_update.Click += new System.EventHandler(this.button_update_Click);
         // 
         // UserInfoForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(522, 393);
         this.Controls.Add(this.button_update);
         this.Controls.Add(this.textBox_ID);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.comboBox_status);
         this.Controls.Add(this.comboBox_uType);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.button_reload);
         this.Controls.Add(this.textBox_password);
         this.Controls.Add(this.textBox_uName);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "UserInfoForm";
         this.Text = "User Info";
         this.Load += new System.EventHandler(this.UserInfoForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button_reload;
      private System.Windows.Forms.TextBox textBox_password;
      private System.Windows.Forms.TextBox textBox_uName;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ComboBox comboBox_uType;
      private System.Windows.Forms.ComboBox comboBox_status;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox textBox_ID;
      private System.Windows.Forms.Button button_update;
   }
}