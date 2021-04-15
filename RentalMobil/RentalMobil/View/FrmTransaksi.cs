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
    public partial class FrmTransaksi : Form
    {
        private List<tbl_transaksi> listOfTransaksi = new List<tbl_transaksi>();
        private tbl_transaksiController controller;
        public FrmTransaksi()
        {
            InitializeComponent();
            controller = new tbl_transaksiController();
            InisialisasiListView();
            LoadDataTransaksi();
        }
        private void InisialisasiListView()
        {
            listView1.View = System.Windows.Forms.View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("No.", 35, HorizontalAlignment.Center);
            listView1.Columns.Add("Kode Transaksi", 110, HorizontalAlignment.Center);
            listView1.Columns.Add("Kode Pelanggan", 110, HorizontalAlignment.Center);
            listView1.Columns.Add("Jaminan", 95, HorizontalAlignment.Center);
            listView1.Columns.Add("Kode Paket", 110, HorizontalAlignment.Center);
            listView1.Columns.Add("Jumlah", 85, HorizontalAlignment.Center);
        }
        private void LoadDataTransaksi()
        {
            listView1.Items.Clear();

            listOfTransaksi = controller.ReadAll();

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
        private void OnCreateEventHandler(tbl_transaksi transaksi)
        {
            listOfTransaksi.Add(transaksi);

            int noUrut = listView1.Items.Count + 1;

            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(transaksi.kd_transaksi);
            item.SubItems.Add(transaksi.kd_pelanggan);
            item.SubItems.Add(transaksi.jaminan);
            item.SubItems.Add(transaksi.kd_paket);
            item.SubItems.Add(transaksi.jumlah);

            listView1.Items.Add(item);
        }
        private void OnUpdateEventHandler(tbl_transaksi transaksi)
        {
            int index = listView1.SelectedIndices[0];

            ListViewItem itemRow = listView1.Items[index];
            itemRow.SubItems[1].Text = transaksi.kd_transaksi;
            itemRow.SubItems[2].Text = transaksi.kd_pelanggan;
            itemRow.SubItems[4].Text = transaksi.jaminan;
            itemRow.SubItems[5].Text = transaksi.kd_paket;
            itemRow.SubItems[6].Text = transaksi.jumlah;
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            FrmEntryTransaksi frmEntry = new FrmEntryTransaksi("Tambah Data Transaksi", controller);

            frmEntry.OnCreate += OnCreateEventHandler;

            frmEntry.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                tbl_transaksi transaksi = listOfTransaksi[listView1.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FrmEntryTransaksi frmEntry = new FrmEntryTransaksi("Edit Data ", transaksi, controller);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnUpdate += OnUpdateEventHandler;

                // tampilkan form entry mahasiswa
                frmEntry.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data mobil ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    tbl_transaksi transaksi = listOfTransaksi[listView1.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(transaksi);
                    if (result > 0) LoadDataTransaksi();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data mobil belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            listOfTransaksi = controller.ReadByNama(textBox1.Text);

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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
