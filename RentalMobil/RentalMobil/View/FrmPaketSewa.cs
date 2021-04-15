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
    public partial class FrmPaketSewa : Form
    {
        private List<tbl_paketsewa> listOfPaketsewa = new List<tbl_paketsewa>();
        private tbl_paketsewaController controller;
        public FrmPaketSewa()
        {
            InitializeComponent();
            controller = new tbl_paketsewaController();
            InisialisasiListView();
            LoadDataPaketSewa();
        }
        private void InisialisasiListView()
        {
            listView1.View = System.Windows.Forms.View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("No.", 36, HorizontalAlignment.Center);
            listView1.Columns.Add("Kode Paket", 127, HorizontalAlignment.Center);
            listView1.Columns.Add("Kode Mobil", 127, HorizontalAlignment.Center);
            listView1.Columns.Add("Paket Sewa", 127, HorizontalAlignment.Center);
            listView1.Columns.Add("Harga Sewa", 128, HorizontalAlignment.Center);
        }

        private void LoadDataPaketSewa()
        {
            listView1.Items.Clear();
            listOfPaketsewa = controller.ReadAll();


            foreach (var paketsewa in listOfPaketsewa)
            {
                var noUrut = listView1.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(paketsewa.kd_paket);
                item.SubItems.Add(paketsewa.kd_mobil);
                item.SubItems.Add(paketsewa.paketsewa);
                item.SubItems.Add(paketsewa.harga);

                listView1.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(tbl_paketsewa paketsewa)
        {
            listOfPaketsewa.Add(paketsewa);

            int noUrut = listView1.Items.Count + 1;

            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(paketsewa.kd_paket);
            item.SubItems.Add(paketsewa.kd_mobil);
            item.SubItems.Add(paketsewa.paketsewa);
            item.SubItems.Add(paketsewa.harga);
            listView1.Items.Add(item);
        }

        private void OnUpdateEventHandler(tbl_paketsewa paketsewa)
        {
            int index = listView1.SelectedIndices[0];

            ListViewItem itemRow = listView1.Items[index];
            itemRow.SubItems[1].Text = paketsewa.kd_paket;
            itemRow.SubItems[2].Text = paketsewa.kd_mobil;
            itemRow.SubItems[3].Text = paketsewa.paketsewa;
            itemRow.SubItems[2].Text = paketsewa.harga;
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Paket ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {

                    tbl_paketsewa paketsewa = listOfPaketsewa[listView1.SelectedIndices[0]];


                    var result = controller.Delete(paketsewa);
                    if (result > 0) LoadDataPaketSewa();
                }
            }
            else
            {
                MessageBox.Show("Data PaketSewa belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                tbl_paketsewa paket = listOfPaketsewa[listView1.SelectedIndices[0]];

                FrmEntryPakaetsewa frmEntry = new FrmEntryPakaetsewa("Edit Data Paket", paket, controller);

                frmEntry.OnUpdate += OnUpdateEventHandler;

                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            FrmEntryPakaetsewa frmEntry = new FrmEntryPakaetsewa("Tambah Data Paket", controller);

            frmEntry.OnCreate += OnCreateEventHandler;

            frmEntry.ShowDialog();
        }
    }
}
