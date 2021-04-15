using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalMobil.Controller;

namespace RentalMobil.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminController controller = new AdminController();

            bool isValidUser = controller.IsValidUser( txtNamaA.Text, txtPasswordA.Text);
            if (isValidUser)
            {
                
                FormUtama frm = new FormUtama();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}

