using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalMobil.Model.Entity;
using RentalMobil.Controller;

namespace RentalMobil.View
{
    public partial class FrmLaporan : Form
    {
        private List<tbl_transaksi> listOfTransaksi = new List<tbl_transaksi>();
        private tbl_transaksiController controller;
        public FrmLaporan()
        {
            InitializeComponent();
            controller = new tbl_transaksiController();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            listView1.View = System.Windows.Forms.View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("No.", 35, HorizontalAlignment.Center);
            listView1.Columns.Add("Kode Transaksi", 105, HorizontalAlignment.Center);
            listView1.Columns.Add("Kode Pelanggan", 105, HorizontalAlignment.Center);
            listView1.Columns.Add("Jaminan", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("Kode Paket", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Jumlah", 80, HorizontalAlignment.Center);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    listOfTransaksi = controller.ReadAll();
                    break;
                case 1:
                    listOfTransaksi = controller.ReadByNama(textBox1.Text);
                    break;
                case 2:
                    listOfTransaksi = controller.ReadByKDTransaksi(textBox1.Text);
                    break;
                case 3:
                    listOfTransaksi = controller.ReadByKDPelanggan(textBox1.Text);
                    break;
                default:
                    listOfTransaksi = controller.ReadAll();
                    break;
            }
            listView1.Items.Clear();
            if (listOfTransaksi == null || listOfTransaksi.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Pencarian data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                foreach (var transaksi in listOfTransaksi)
                {
                    var noUrut = listView1.Items.Count + 1;

                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(transaksi.kd_transaksi);
                    item.SubItems.Add(transaksi.kd_pelanggan);
                    item.SubItems.Add(transaksi.jaminan);
                    item.SubItems.Add(transaksi.kd_paket);
                    item.SubItems.Add(transaksi.jumlah);

                    listView1.Items.Add(item);
                }
            }
        }
    }
}
