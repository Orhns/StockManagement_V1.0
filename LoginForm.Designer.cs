namespace StockManagement_V1._0
{
   partial class LoginForm
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.textBox_name = new System.Windows.Forms.TextBox();
         this.textBox_pass = new System.Windows.Forms.TextBox();
         this.button_connect = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(33, 42);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(115, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "User Name :";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(33, 87);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(103, 20);
         this.label2.TabIndex = 1;
         this.label2.Text = "Password :";
         // 
         // textBox_name
         // 
         this.textBox_name.Location = new System.Drawing.Point(154, 42);
         this.textBox_name.Name = "textBox_name";
         this.textBox_name.Size = new System.Drawing.Size(145, 22);
         this.textBox_name.TabIndex = 2;
         this.textBox_name.Text = "admin";
         // 
         // textBox_pass
         // 
         this.textBox_pass.Location = new System.Drawing.Point(154, 85);
         this.textBox_pass.Name = "textBox_pass";
         this.textBox_pass.Size = new System.Drawing.Size(145, 22);
         this.textBox_pass.TabIndex = 3;
         this.textBox_pass.Text = "1234";
         // 
         // button_connect
         // 
         this.button_connect.BackColor = System.Drawing.Color.Aquamarine;
         this.button_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button_connect.Location = new System.Drawing.Point(196, 135);
         this.button_connect.Name = "button_connect";
         this.button_connect.Size = new System.Drawing.Size(103, 42);
         this.button_connect.TabIndex = 4;
         this.button_connect.Text = "Connect";
         this.button_connect.UseVisualStyleBackColor = false;
         this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
         // 
         // LoginForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(333, 203);
         this.Controls.Add(this.button_connect);
         this.Controls.Add(this.textBox_pass);
         this.Controls.Add(this.textBox_name);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "LoginForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.Load += new System.EventHandler(this.LoginForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textBox_name;
      private System.Windows.Forms.TextBox textBox_pass;
      private System.Windows.Forms.Button button_connect;
   }
}

