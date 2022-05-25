namespace StockManagement_V1._0
{
   partial class ProductsManageForm
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
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.Label1 = new System.Windows.Forms.Label();
         this.searchByIdTxt = new System.Windows.Forms.TextBox();
         this.textBox_ID = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.textBox_Name = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.textBox_Price = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.comboBox_Status = new System.Windows.Forms.ComboBox();
         this.comboBox_Ctg = new System.Windows.Forms.ComboBox();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.AllowUserToAddRows = false;
         this.dataGridView1.AllowUserToDeleteRows = false;
         this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(12, 52);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.ReadOnly = true;
         this.dataGridView1.RowHeadersWidth = 51;
         this.dataGridView1.RowTemplate.Height = 24;
         this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dataGridView1.Size = new System.Drawing.Size(443, 326);
         this.dataGridView1.TabIndex = 0;
         this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
         // 
         // Label1
         // 
         this.Label1.AutoSize = true;
         this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Label1.Location = new System.Drawing.Point(12, 20);
         this.Label1.Name = "Label1";
         this.Label1.Size = new System.Drawing.Size(116, 18);
         this.Label1.TabIndex = 1;
         this.Label1.Text = "Search By ID :";
         // 
         // searchByIdTxt
         // 
         this.searchByIdTxt.Location = new System.Drawing.Point(134, 20);
         this.searchByIdTxt.Name = "searchByIdTxt";
         this.searchByIdTxt.Size = new System.Drawing.Size(138, 22);
         this.searchByIdTxt.TabIndex = 2;
         this.searchByIdTxt.TextChanged += new System.EventHandler(this.textBox_searchByIdTxt);
         // 
         // textBox_ID
         // 
         this.textBox_ID.Enabled = false;
         this.textBox_ID.Location = new System.Drawing.Point(464, 74);
         this.textBox_ID.Name = "textBox_ID";
         this.textBox_ID.Size = new System.Drawing.Size(177, 22);
         this.textBox_ID.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(461, 53);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(95, 18);
         this.label2.TabIndex = 4;
         this.label2.Text = "Product Id :";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(463, 109);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(126, 18);
         this.label3.TabIndex = 6;
         this.label3.Text = "Product Name :";
         // 
         // textBox_Name
         // 
         this.textBox_Name.Location = new System.Drawing.Point(466, 130);
         this.textBox_Name.Name = "textBox_Name";
         this.textBox_Name.Size = new System.Drawing.Size(177, 22);
         this.textBox_Name.TabIndex = 5;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(461, 165);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(150, 18);
         this.label4.TabIndex = 8;
         this.label4.Text = "Product Category :";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(461, 226);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(121, 18);
         this.label5.TabIndex = 10;
         this.label5.Text = "Product Price :";
         // 
         // textBox_Price
         // 
         this.textBox_Price.Location = new System.Drawing.Point(464, 247);
         this.textBox_Price.Name = "textBox_Price";
         this.textBox_Price.Size = new System.Drawing.Size(177, 22);
         this.textBox_Price.TabIndex = 9;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(461, 285);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(130, 18);
         this.label6.TabIndex = 12;
         this.label6.Text = "Product Status :";
         // 
         // comboBox_Status
         // 
         this.comboBox_Status.FormattingEnabled = true;
         this.comboBox_Status.Items.AddRange(new object[] {
            "Active",
            "Passive"});
         this.comboBox_Status.Location = new System.Drawing.Point(464, 306);
         this.comboBox_Status.Name = "comboBox_Status";
         this.comboBox_Status.Size = new System.Drawing.Size(177, 24);
         this.comboBox_Status.TabIndex = 13;
         // 
         // comboBox_Ctg
         // 
         this.comboBox_Ctg.FormattingEnabled = true;
         this.comboBox_Ctg.Items.AddRange(new object[] {
            "-Seçim yok-",
            "Tatlı",
            "Tuzlu",
            "Kahve",
            "Kişisel Bakım"});
         this.comboBox_Ctg.Location = new System.Drawing.Point(464, 186);
         this.comboBox_Ctg.Name = "comboBox_Ctg";
         this.comboBox_Ctg.Size = new System.Drawing.Size(177, 24);
         this.comboBox_Ctg.TabIndex = 14;
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.SeaGreen;
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button1.Location = new System.Drawing.Point(560, 347);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(83, 31);
         this.button1.TabIndex = 21;
         this.button1.Text = "Add";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button_Add_Click);
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.Color.RoyalBlue;
         this.button2.Enabled = false;
         this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button2.Location = new System.Drawing.Point(464, 347);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(90, 31);
         this.button2.TabIndex = 22;
         this.button2.Text = "Update";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.button_Update_Click);
         // 
         // button3
         // 
         this.button3.BackColor = System.Drawing.Color.Crimson;
         this.button3.Enabled = false;
         this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button3.Location = new System.Drawing.Point(464, 14);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(177, 31);
         this.button3.TabIndex = 23;
         this.button3.Text = "Delete";
         this.button3.UseVisualStyleBackColor = false;
         // 
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Items.AddRange(new object[] {
            "Passive",
            "Active"});
         this.comboBox1.Location = new System.Drawing.Point(305, 19);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(150, 24);
         this.comboBox1.TabIndex = 24;
         this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
         // 
         // ProductsManageForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(662, 404);
         this.Controls.Add(this.comboBox1);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.comboBox_Ctg);
         this.Controls.Add(this.comboBox_Status);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.textBox_Price);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.textBox_Name);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.textBox_ID);
         this.Controls.Add(this.searchByIdTxt);
         this.Controls.Add(this.Label1);
         this.Controls.Add(this.dataGridView1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "ProductsManageForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ProductsManageForm";
         this.Load += new System.EventHandler(this.ProductsManageForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Label Label1;
      private System.Windows.Forms.TextBox searchByIdTxt;
      private System.Windows.Forms.TextBox textBox_ID;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox textBox_Name;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox textBox_Price;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.ComboBox comboBox_Status;
      private System.Windows.Forms.ComboBox comboBox_Ctg;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.ComboBox comboBox1;
   }
}