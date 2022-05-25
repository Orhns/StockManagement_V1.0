namespace StockManagement_V1._0
{
   partial class MainMenu
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
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.showProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.userSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.pContainer = new System.Windows.Forms.Panel();
         this.virtualCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.virtualCartToolStripMenuItem,
            this.userSettingsToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(800, 28);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // productsToolStripMenuItem
         // 
         this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.showProductsToolStripMenuItem});
         this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
         this.productsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
         this.productsToolStripMenuItem.Text = "Products";
         // 
         // addProductToolStripMenuItem
         // 
         this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
         this.addProductToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
         this.addProductToolStripMenuItem.Text = "Manage Products";
         this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
         // 
         // showProductsToolStripMenuItem
         // 
         this.showProductsToolStripMenuItem.Name = "showProductsToolStripMenuItem";
         this.showProductsToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
         this.showProductsToolStripMenuItem.Text = "Show Products";
         this.showProductsToolStripMenuItem.Click += new System.EventHandler(this.showProductsToolStripMenuItem_Click);
         // 
         // stockToolStripMenuItem
         // 
         this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
         this.stockToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
         this.stockToolStripMenuItem.Text = "Stock";
         // 
         // userSettingsToolStripMenuItem
         // 
         this.userSettingsToolStripMenuItem.Name = "userSettingsToolStripMenuItem";
         this.userSettingsToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
         this.userSettingsToolStripMenuItem.Text = "User Info";
         this.userSettingsToolStripMenuItem.Click += new System.EventHandler(this.userSettingsToolStripMenuItem_Click);
         // 
         // pContainer
         // 
         this.pContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pContainer.Location = new System.Drawing.Point(12, 31);
         this.pContainer.Name = "pContainer";
         this.pContainer.Size = new System.Drawing.Size(776, 407);
         this.pContainer.TabIndex = 1;
         // 
         // virtualCartToolStripMenuItem
         // 
         this.virtualCartToolStripMenuItem.Name = "virtualCartToolStripMenuItem";
         this.virtualCartToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
         this.virtualCartToolStripMenuItem.Text = "Virtual Cart";
         this.virtualCartToolStripMenuItem.Click += new System.EventHandler(this.virtualCartToolStripMenuItem_Click);
         // 
         // MainMenu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.pContainer);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "MainMenu";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "MainMenu";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem userSettingsToolStripMenuItem;
      private System.Windows.Forms.Panel pContainer;
      private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem showProductsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem virtualCartToolStripMenuItem;
   }
}