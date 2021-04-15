namespace RentalMobil.View
{
    partial class FrmUtama
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
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paketSewaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiPenyewaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mobilToolStripMenuItem,
            this.paketSewaToolStripMenuItem,
            this.pelangganToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // mobilToolStripMenuItem
            // 
            this.mobilToolStripMenuItem.Name = "mobilToolStripMenuItem";
            this.mobilToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.mobilToolStripMenuItem.Text = "Mobil";
            this.mobilToolStripMenuItem.Click += new System.EventHandler(this.mobilToolStripMenuItem_Click);
            // 
            // paketSewaToolStripMenuItem
            // 
            this.paketSewaToolStripMenuItem.Name = "paketSewaToolStripMenuItem";
            this.paketSewaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.paketSewaToolStripMenuItem.Text = "Paket Sewa";
            this.paketSewaToolStripMenuItem.Click += new System.EventHandler(this.paketSewaToolStripMenuItem_Click);
            // 
            // pelangganToolStripMenuItem
            // 
            this.pelangganToolStripMenuItem.Name = "pelangganToolStripMenuItem";
            this.pelangganToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.pelangganToolStripMenuItem.Text = "Pelanggan";
            this.pelangganToolStripMenuItem.Click += new System.EventHandler(this.pelangganToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaksiPenyewaanToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // transaksiPenyewaanToolStripMenuItem
            // 
            this.transaksiPenyewaanToolStripMenuItem.Name = "transaksiPenyewaanToolStripMenuItem";
            this.transaksiPenyewaanToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.transaksiPenyewaanToolStripMenuItem.Text = "Transaksi Penyewaan";
            this.transaksiPenyewaanToolStripMenuItem.Click += new System.EventHandler(this.transaksiPenyewaanToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::RentalMobil.Properties.Resources._176573_11322517122020_rental_mobil;
            this.ClientSize = new System.Drawing.Size(650, 319);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUtama";
            this.Load += new System.EventHandler(this.FrmUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paketSewaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiPenyewaanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
    }
}