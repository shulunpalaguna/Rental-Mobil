using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalMobil.View
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMasterMobil_Click(object sender, EventArgs e)
        {
            FrmMobil frm = new FrmMobil();
            frm.ShowDialog();
            
        }

        private void btnPelanggan_Click(object sender, EventArgs e)
        {
            FrmLaporan frm = new FrmLaporan();
            frm.ShowDialog();
            
        }

        private void btnPaketSewa_Click(object sender, EventArgs e)
        {
            FrmPaketSewa frm = new FrmPaketSewa();
            frm.ShowDialog();
            
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            FrmTransaksi frm = new FrmTransaksi();
            frm.ShowDialog();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPelanggan_Click_1(object sender, EventArgs e)
        {
            FrmPelanggan frm = new FrmPelanggan();
            frm.ShowDialog();
            
        }
    }
}
