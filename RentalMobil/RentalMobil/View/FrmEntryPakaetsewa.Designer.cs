namespace RentalMobil.View
{
    partial class FrmEntryPakaetsewa
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
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtPaketSewa = new System.Windows.Forms.TextBox();
            this.txtKdMobil = new System.Windows.Forms.TextBox();
            this.txtKdPaket = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(357, 257);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(100, 20);
            this.txtHarga.TabIndex = 15;
            // 
            // txtPaketSewa
            // 
            this.txtPaketSewa.Location = new System.Drawing.Point(357, 231);
            this.txtPaketSewa.Name = "txtPaketSewa";
            this.txtPaketSewa.Size = new System.Drawing.Size(100, 20);
            this.txtPaketSewa.TabIndex = 14;
            // 
            // txtKdMobil
            // 
            this.txtKdMobil.Location = new System.Drawing.Point(357, 205);
            this.txtKdMobil.Name = "txtKdMobil";
            this.txtKdMobil.Size = new System.Drawing.Size(100, 20);
            this.txtKdMobil.TabIndex = 13;
            // 
            // txtKdPaket
            // 
            this.txtKdPaket.Location = new System.Drawing.Point(357, 179);
            this.txtKdPaket.Name = "txtKdPaket";
            this.txtKdPaket.Size = new System.Drawing.Size(100, 20);
            this.txtKdPaket.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Paket Sewa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "KD Mobil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "KD Paket";
            // 
            // btnSelesai
            // 
            this.btnSelesai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelesai.Location = new System.Drawing.Point(386, 289);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(96, 32);
            this.btnSelesai.TabIndex = 23;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSimpan.Location = new System.Drawing.Point(258, 289);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(96, 32);
            this.btnSimpan.TabIndex = 22;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Entry Paket Sewa";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::RentalMobil.Properties.Resources.auto_loan;
            this.panel3.Location = new System.Drawing.Point(339, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(66, 46);
            this.panel3.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RentalMobil.Properties.Resources.mobil_2;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 204);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RentalMobil.Properties.Resources._176573_11322517122020_rental_mobil__2_;
            this.panel1.Location = new System.Drawing.Point(1, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 154);
            this.panel1.TabIndex = 24;
            // 
            // FrmEntryPakaetsewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 360);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtPaketSewa);
            this.Controls.Add(this.txtKdMobil);
            this.Controls.Add(this.txtKdPaket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEntryPakaetsewa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEntryPakaetsewa";
            this.Load += new System.EventHandler(this.FrmEntryPakaetsewa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtPaketSewa;
        private System.Windows.Forms.TextBox txtKdMobil;
        private System.Windows.Forms.TextBox txtKdPaket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
    }
}