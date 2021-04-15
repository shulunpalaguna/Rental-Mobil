namespace RentalMobil.View
{
    partial class FrmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaA = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordA = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Admin";
            // 
            // txtNamaA
            // 
            this.txtNamaA.Location = new System.Drawing.Point(355, 126);
            this.txtNamaA.Name = "txtNamaA";
            this.txtNamaA.Size = new System.Drawing.Size(115, 20);
            this.txtNamaA.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(250, 218);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBatal.Location = new System.Drawing.Point(376, 218);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(94, 23);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // txtPasswordA
            // 
            this.txtPasswordA.Location = new System.Drawing.Point(355, 165);
            this.txtPasswordA.Name = "txtPasswordA";
            this.txtPasswordA.Size = new System.Drawing.Size(115, 20);
            this.txtPasswordA.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::RentalMobil.Properties.Resources.user_profile__2_;
            this.panel3.Location = new System.Drawing.Point(324, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(67, 69);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RentalMobil.Properties.Resources._176573_11322517122020_rental_mobil__2_;
            this.panel1.Location = new System.Drawing.Point(1, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 138);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RentalMobil.Properties.Resources.mobil_2;
            this.panel2.Location = new System.Drawing.Point(1, -39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 204);
            this.panel2.TabIndex = 9;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(482, 255);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPasswordA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtNamaA);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNamaA;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Button btnBatal;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPasswordA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}