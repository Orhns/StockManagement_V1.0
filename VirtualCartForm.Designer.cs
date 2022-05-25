namespace StockManagement_V1._0
{
   partial class VirtualCartForm
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
         this.listView1 = new System.Windows.Forms.ListView();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.prodNameText = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.comboBoxCategory = new System.Windows.Forms.ComboBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.button2 = new System.Windows.Forms.Button();
         this.label10 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.label12 = new System.Windows.Forms.Label();
         this.button3 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.button5 = new System.Windows.Forms.Button();
         this.button6 = new System.Windows.Forms.Button();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         this.label13 = new System.Windows.Forms.Label();
         this.button7 = new System.Windows.Forms.Button();
         this.button8 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.panel2 = new System.Windows.Forms.Panel();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(15, 226);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.ReadOnly = true;
         this.dataGridView1.RowHeadersWidth = 51;
         this.dataGridView1.RowTemplate.Height = 24;
         this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dataGridView1.Size = new System.Drawing.Size(308, 266);
         this.dataGridView1.TabIndex = 0;
         this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
         // 
         // listView1
         // 
         this.listView1.HideSelection = false;
         this.listView1.Location = new System.Drawing.Point(16, 147);
         this.listView1.Name = "listView1";
         this.listView1.Size = new System.Drawing.Size(323, 194);
         this.listView1.TabIndex = 2;
         this.listView1.UseCompatibleStateImageBehavior = false;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(15, 152);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(138, 18);
         this.label2.TabIndex = 4;
         this.label2.Text = "Select Category :";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(15, 198);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(126, 18);
         this.label3.TabIndex = 5;
         this.label3.Text = "Product Name :";
         // 
         // prodNameText
         // 
         this.prodNameText.Location = new System.Drawing.Point(170, 198);
         this.prodNameText.Name = "prodNameText";
         this.prodNameText.Size = new System.Drawing.Size(153, 22);
         this.prodNameText.TabIndex = 6;
         this.prodNameText.TextChanged += new System.EventHandler(this.prodNameText_TextChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(309, 61);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(185, 31);
         this.label1.TabIndex = 7;
         this.label1.Text = "Your Balance :";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Transparent;
         this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.Black;
         this.label4.Location = new System.Drawing.Point(498, 61);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(29, 31);
         this.label4.TabIndex = 8;
         this.label4.Text = "0";
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(592, 24);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(94, 22);
         this.textBox2.TabIndex = 9;
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.SeaGreen;
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button1.Location = new System.Drawing.Point(702, 18);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(110, 33);
         this.button1.TabIndex = 22;
         this.button1.Text = "Deposit";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // comboBoxCategory
         // 
         this.comboBoxCategory.FormattingEnabled = true;
         this.comboBoxCategory.Items.AddRange(new object[] {
            "-Seçim yok-",
            "Tatlı",
            "Tuzlu",
            "Kahve",
            "Kişisel Bakım"});
         this.comboBoxCategory.Location = new System.Drawing.Point(170, 150);
         this.comboBoxCategory.Name = "comboBoxCategory";
         this.comboBoxCategory.Size = new System.Drawing.Size(153, 24);
         this.comboBoxCategory.TabIndex = 23;
         this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(13, 9);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(128, 18);
         this.label5.TabIndex = 24;
         this.label5.Text = "Your Selection :";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(13, 49);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(77, 18);
         this.label6.TabIndex = 26;
         this.label6.Text = "Product :";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.Red;
         this.label7.Location = new System.Drawing.Point(96, 49);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(14, 18);
         this.label7.TabIndex = 27;
         this.label7.Text = "-";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.ForeColor = System.Drawing.Color.Red;
         this.label8.Location = new System.Drawing.Point(96, 82);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(14, 18);
         this.label8.TabIndex = 29;
         this.label8.Text = "-";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.Location = new System.Drawing.Point(13, 82);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(57, 18);
         this.label9.TabIndex = 28;
         this.label9.Text = "Price :";
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.Color.SeaGreen;
         this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button2.Location = new System.Drawing.Point(210, 108);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(129, 33);
         this.button2.TabIndex = 30;
         this.button2.Text = "Add to Cart";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label10.Location = new System.Drawing.Point(356, 250);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(100, 18);
         this.label10.TabIndex = 31;
         this.label10.Text = "Total Price :";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label11.ForeColor = System.Drawing.Color.Red;
         this.label11.Location = new System.Drawing.Point(472, 249);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(14, 18);
         this.label11.TabIndex = 32;
         this.label11.Text = "-";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panel1.Controls.Add(this.button8);
         this.panel1.Controls.Add(this.textBox1);
         this.panel1.Controls.Add(this.button5);
         this.panel1.Controls.Add(this.button6);
         this.panel1.Controls.Add(this.button4);
         this.panel1.Controls.Add(this.button3);
         this.panel1.Controls.Add(this.label12);
         this.panel1.Controls.Add(this.button1);
         this.panel1.Controls.Add(this.textBox2);
         this.panel1.Controls.Add(this.label4);
         this.panel1.Controls.Add(this.label1);
         this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
         this.panel1.Location = new System.Drawing.Point(18, 12);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(840, 120);
         this.panel1.TabIndex = 33;
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label12.Location = new System.Drawing.Point(3, 7);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(144, 18);
         this.label12.TabIndex = 23;
         this.label12.Text = "Select Customer :";
         // 
         // button3
         // 
         this.button3.BackColor = System.Drawing.Color.DodgerBlue;
         this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button3.Location = new System.Drawing.Point(3, 38);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(118, 33);
         this.button3.TabIndex = 34;
         this.button3.Text = "Ümit";
         this.button3.UseVisualStyleBackColor = false;
         // 
         // button4
         // 
         this.button4.BackColor = System.Drawing.Color.DodgerBlue;
         this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button4.Location = new System.Drawing.Point(3, 77);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(118, 33);
         this.button4.TabIndex = 35;
         this.button4.Text = "Meral";
         this.button4.UseVisualStyleBackColor = false;
         // 
         // button5
         // 
         this.button5.BackColor = System.Drawing.Color.DodgerBlue;
         this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button5.Location = new System.Drawing.Point(127, 77);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(118, 33);
         this.button5.TabIndex = 37;
         this.button5.Text = "Ali";
         this.button5.UseVisualStyleBackColor = false;
         // 
         // button6
         // 
         this.button6.BackColor = System.Drawing.Color.DodgerBlue;
         this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button6.Location = new System.Drawing.Point(127, 38);
         this.button6.Name = "button6";
         this.button6.Size = new System.Drawing.Size(118, 33);
         this.button6.TabIndex = 36;
         this.button6.Text = "Mansur";
         this.button6.UseVisualStyleBackColor = false;
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.Location = new System.Drawing.Point(114, 114);
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(80, 22);
         this.numericUpDown1.TabIndex = 34;
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label13.Location = new System.Drawing.Point(18, 115);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(80, 18);
         this.label13.TabIndex = 35;
         this.label13.Text = "Quantity :";
         // 
         // button7
         // 
         this.button7.BackColor = System.Drawing.Color.SeaGreen;
         this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button7.Location = new System.Drawing.Point(359, 286);
         this.button7.Name = "button7";
         this.button7.Size = new System.Drawing.Size(127, 33);
         this.button7.TabIndex = 36;
         this.button7.Text = "Purchase";
         this.button7.UseVisualStyleBackColor = false;
         // 
         // button8
         // 
         this.button8.BackColor = System.Drawing.Color.SeaGreen;
         this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button8.Location = new System.Drawing.Point(702, 64);
         this.button8.Name = "button8";
         this.button8.Size = new System.Drawing.Size(110, 33);
         this.button8.TabIndex = 39;
         this.button8.Text = "Withdraw";
         this.button8.UseVisualStyleBackColor = false;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(592, 70);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(94, 22);
         this.textBox1.TabIndex = 38;
         // 
         // panel2
         // 
         this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel2.Controls.Add(this.button7);
         this.panel2.Controls.Add(this.label13);
         this.panel2.Controls.Add(this.numericUpDown1);
         this.panel2.Controls.Add(this.label11);
         this.panel2.Controls.Add(this.label10);
         this.panel2.Controls.Add(this.button2);
         this.panel2.Controls.Add(this.label8);
         this.panel2.Controls.Add(this.label9);
         this.panel2.Controls.Add(this.label7);
         this.panel2.Controls.Add(this.label6);
         this.panel2.Controls.Add(this.label5);
         this.panel2.Controls.Add(this.listView1);
         this.panel2.Location = new System.Drawing.Point(345, 141);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(513, 351);
         this.panel2.TabIndex = 37;
         // 
         // VirtualCartForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(870, 504);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.comboBoxCategory);
         this.Controls.Add(this.prodNameText);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.dataGridView1);
         this.Name = "VirtualCartForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "VirtualCartForm";
         this.Load += new System.EventHandler(this.VirtualCartForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.ListView listView1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox prodNameText;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.ComboBox comboBoxCategory;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button button5;
      private System.Windows.Forms.Button button6;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.Button button7;
      private System.Windows.Forms.Button button8;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Panel panel2;
   }
}