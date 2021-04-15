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
    public partial class FrmUtama : Form
    {
        public FrmUtama()
        {
            InitializeComponent();
        }

        private void mobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMobil frm = new FrmMobil();
            frm.ShowDialog();
        }

        private void paketSewaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPaketSewa frm = new FrmPaketSewa();
            frm.ShowDialog();
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPelanggan frm = new FrmPelanggan();
            frm.ShowDialog();
        }

        private void transaksiPenyewaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransaksi frm = new FrmTransaksi();
            frm.ShowDialog();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLaporan frm = new FrmLaporan();
            frm.ShowDialog();
        }

        private void FrmUtama_Load(object sender, EventArgs e)
        {

        }
    }
}
