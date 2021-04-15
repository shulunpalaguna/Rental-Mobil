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
    public partial class FrmPelanggan : Form
    {
        private List<tbl_pelanggan> listOfPelanggan = new List<tbl_pelanggan>();
        private tbl_pelangganController controller;
        public FrmPelanggan()
        {
            InitializeComponent();
            controller = new tbl_pelangganController();
            InisialisasiListView();
            LoadDataPelanggan();
        }
        private void InisialisasiListView()
        {
            listView1.View = System.Windows.Forms.View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("No.", 35, HorizontalAlignment.Center);
            listView1.Columns.Add(" Kode Pelanggan", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Nama Pelanggan", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Alamat", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("No Telp", 120, HorizontalAlignment.Center);
        }
        private void LoadDataPelanggan()
        {
            listView1.Items.Clear();

            listOfPelanggan = controller.Readtbl_pelanggan();

            foreach (var pelanggan in listOfPelanggan)
            {
                var noUrut = listView1.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pelanggan.kd_pelanggan);
                item.SubItems.Add(pelanggan.namapelanggan);
                item.SubItems.Add(pelanggan.alamat);
                item.SubItems.Add(pelanggan.notlp);

                listView1.Items.Add(item);
            }
        }
        private void OnCreateEventHandler(tbl_pelanggan pelanggan)
        {
           listOfPelanggan.Add(pelanggan);

            int noUrut = listView1.Items.Count + 1;

            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(pelanggan.kd_pelanggan);
            item.SubItems.Add(pelanggan.namapelanggan);
            item.SubItems.Add(pelanggan.alamat);
            item.SubItems.Add(pelanggan.notlp);

            listView1.Items.Add(item);
        }
        private void OnUpdateEventHandler(tbl_pelanggan pelanggan)
        {
            int index = listView1.SelectedIndices[0];

            ListViewItem itemRow = listView1.Items[index];
            itemRow.SubItems[1].Text = pelanggan.kd_pelanggan;
            itemRow.SubItems[2].Text = pelanggan.namapelanggan;
            itemRow.SubItems[3].Text = pelanggan.alamat;
            itemRow.SubItems[4].Text = pelanggan.notlp;
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            FrmEntryPelanggan frmEntry = new FrmEntryPelanggan("Tambah Data Admin", controller);

            frmEntry.OnCreate += OnCreateEventHandler;

            frmEntry.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                tbl_pelanggan pelanggan = listOfPelanggan[listView1.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FrmEntryPelanggan frmEntry = new FrmEntryPelanggan("Edit Data ", pelanggan, controller);

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
                    tbl_pelanggan pelanggan = listOfPelanggan[listView1.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(pelanggan);
                    if (result > 0) LoadDataPelanggan();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data mobil belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            listOfPelanggan = controller.ReadByNama(txtSearch.Text);

            foreach (var pelanggan in listOfPelanggan)
            {
                var noUrut = listView1.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pelanggan.kd_pelanggan);
                item.SubItems.Add(pelanggan.namapelanggan);
                item.SubItems.Add(pelanggan.alamat);
                item.SubItems.Add(pelanggan.notlp);


                listView1.Items.Add(item);
            }
        }
    }
}
