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
    public partial class FrmMobil : Form
    {
        private List<tbl_mobil> listOftbl_mobil = new List<tbl_mobil>();
        private tbl_mobilController controller;

        public FrmMobil()
        {
            InitializeComponent();
            controller = new tbl_mobilController();
            InisialisasiListView();
            LoadDatatbl_mobil();
        }

        private void InisialisasiListView()
        {
            listView1.View = System.Windows.Forms.View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("No.", 35, HorizontalAlignment.Center);
            listView1.Columns.Add("Kode Mobil.", 110, HorizontalAlignment.Center);
            listView1.Columns.Add("No Polisi", 110, HorizontalAlignment.Center);
            listView1.Columns.Add("Merek Mobil", 110, HorizontalAlignment.Center);
            listView1.Columns.Add("Warna Mobil", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Tahun", 80, HorizontalAlignment.Center);
        }

        private void LoadDatatbl_mobil()
        {
            listView1.Items.Clear();
            listOftbl_mobil = controller.ReadAll();

           
            foreach (var mobil in listOftbl_mobil)
            {
                var noUrut = listView1.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mobil.kd_mobil);
                item.SubItems.Add(mobil.nopolisi);
                item.SubItems.Add(mobil.merekmobil);
                item.SubItems.Add(mobil.warnamobil);
                item.SubItems.Add(mobil.tahun);

                listView1.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(tbl_mobil mobil)
        {
            listOftbl_mobil.Add(mobil);

            int noUrut = listView1.Items.Count + 1;

            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(mobil.kd_mobil);
            item.SubItems.Add(mobil.nopolisi);
            item.SubItems.Add(mobil.merekmobil);
            item.SubItems.Add(mobil.warnamobil);
            item.SubItems.Add(mobil.tahun);

            listView1.Items.Add(item);
        }

        private void OnUpdateEventHandler(tbl_mobil mobil)
        {
            int index = listView1.SelectedIndices[0];

            ListViewItem itemRow = listView1.Items[index];
            itemRow.SubItems[1].Text = mobil.kd_mobil;
            itemRow.SubItems[2].Text = mobil.nopolisi;
            itemRow.SubItems[3].Text = mobil.merekmobil;
            itemRow.SubItems[2].Text = mobil.warnamobil;
            itemRow.SubItems[3].Text = mobil.tahun;
        }


        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_Click_1(object sender, EventArgs e)
        {
            FrmEntryMobil frmEntry = new FrmEntryMobil("Tambah Data Mobil", controller);

            frmEntry.OnCreate += OnCreateEventHandler;

            frmEntry.ShowDialog();

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                tbl_mobil mobil = listOftbl_mobil[listView1.SelectedIndices[0]];

                FrmEntryMobil frmEntry = new FrmEntryMobil("Edit Data Mobil", mobil, controller);

                frmEntry.OnUpdate += OnUpdateEventHandler;

                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data mobil ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {

                    tbl_mobil mobil = listOftbl_mobil[listView1.SelectedIndices[0]];


                    var result = controller.Delete(mobil);
                    if (result > 0) LoadDatatbl_mobil();
                }
            }
            else
            {
                MessageBox.Show("Data Mobil belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            listOftbl_mobil = controller.ReadByNama(textBox1.Text);

            foreach (var mobil in listOftbl_mobil)
            {
                var noUrut = listView1.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mobil.kd_mobil);
                item.SubItems.Add(mobil.nopolisi);
                item.SubItems.Add(mobil.merekmobil);
                item.SubItems.Add(mobil.warnamobil);
                item.SubItems.Add(mobil.tahun);


                listView1.Items.Add(item);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

