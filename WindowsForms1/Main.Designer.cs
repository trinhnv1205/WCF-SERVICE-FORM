namespace WindowsForms1
{
    partial class Main
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
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhậpSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàCungCấpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.bánHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhậpSảnPhẩmToolStripMenuItem,
            this.quảnLýNhàCungCấpToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýNhàCungCấpToolStripMenuItem1});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnBánToolStripMenuItem});
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.bánHàngToolStripMenuItem.Text = "Bán Hàng";
            // 
            // quảnLýNhậpSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýNhậpSảnPhẩmToolStripMenuItem.Name = "quảnLýNhậpSảnPhẩmToolStripMenuItem";
            this.quảnLýNhậpSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.quảnLýNhậpSảnPhẩmToolStripMenuItem.Text = "Quản lý nhập sản phẩm";
            // 
            // quảnLýNhàCungCấpToolStripMenuItem
            // 
            this.quảnLýNhàCungCấpToolStripMenuItem.Name = "quảnLýNhàCungCấpToolStripMenuItem";
            this.quảnLýNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.quảnLýNhàCungCấpToolStripMenuItem.Text = "Quản lý nhà cung cấp";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // quảnLýNhàCungCấpToolStripMenuItem1
            // 
            this.quảnLýNhàCungCấpToolStripMenuItem1.Name = "quảnLýNhàCungCấpToolStripMenuItem1";
            this.quảnLýNhàCungCấpToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.quảnLýNhàCungCấpToolStripMenuItem1.Text = "Quản lý nhà cung cấp";
            // 
            // hóaĐơnBánToolStripMenuItem
            // 
            this.hóaĐơnBánToolStripMenuItem.Name = "hóaĐơnBánToolStripMenuItem";
            this.hóaĐơnBánToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hóaĐơnBánToolStripMenuItem.Text = "Hóa Đơn Bán";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhậpSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánToolStripMenuItem;
    }
}