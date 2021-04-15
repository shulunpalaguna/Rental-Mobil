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
    public partial class FrmEntryMobil : Form
    {
        public delegate void CreateUpdateEventHandler(tbl_mobil mobil);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private tbl_mobilController controller;
        private bool isNewData = true;
        private tbl_mobil mobil;
        public FrmEntryMobil()
        {
            InitializeComponent();
        }
        public FrmEntryMobil(string title, tbl_mobilController controller)
            : this()
        {

            this.Text = title;
            this.controller = controller;
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryMobil(string title, tbl_mobil obj, tbl_mobilController controller)
            : this()
        {
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            mobil = obj; // set objek mhs yang akan diedit

            // untuk edit data, tampilkan data lama
            txtKdMobil.Text = mobil.kd_mobil;
            txtNopolisi.Text = mobil.nopolisi;
            txtNamaMobil.Text = mobil.merekmobil;
            txtWarnaMobil.Text = mobil.warnamobil;
            txtTahun.Text = mobil.tahun;
        }

        private void btnSelesai_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (isNewData) mobil = new tbl_mobil();

            // set nilai property objek mahasiswa yg diambil dari TextBox
            mobil.kd_mobil = txtKdMobil.Text;
            mobil.nopolisi = txtNopolisi.Text;
            mobil.merekmobil = txtNamaMobil.Text;
            mobil.warnamobil = txtWarnaMobil.Text;
            mobil.tahun = txtTahun.Text;
            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(mobil);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(mobil); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtKdMobil.Clear();
                    txtNopolisi.Clear();
                    txtNamaMobil.Clear();
                    txtWarnaMobil.Clear();
                    txtTahun.Clear();
                    txtKdMobil.Focus();

                }
            }
            else // edit data, panggil method Update
            {
                result = controller.Update(mobil);

                if (result > 0)
                {
                    OnUpdate(mobil); // panggil event OnUpdate
                    this.Close();
                }
            }
        }
    }
}
