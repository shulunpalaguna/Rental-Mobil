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
    public partial class FrmEntryPakaetsewa : Form
    {
        public delegate void CreateUpdateEventHandler(tbl_paketsewa paketsewa);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private tbl_paketsewaController controller;
        private bool isNewData = true;
        private tbl_paketsewa paket;

        public FrmEntryPakaetsewa()
        {
            InitializeComponent();
        }

        public FrmEntryPakaetsewa(string title, tbl_paketsewaController controller)
            : this()
        {

            this.Text = title;
            this.controller = controller;
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryPakaetsewa(string title, tbl_paketsewa obj, tbl_paketsewaController controller)
            : this()
        {
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            paket = obj; // set objek mhs yang akan diedit

            // untuk edit data, tampilkan data lama
            txtKdPaket.Text = paket.kd_paket;
            txtKdMobil.Text = paket.kd_mobil;
            txtPaketSewa.Text = paket.paketsewa;
            txtHarga.Text = paket.harga;
        }
        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) paket = new tbl_paketsewa();

            // set nilai property objek mahasiswa yg diambil dari TextBox
            paket.kd_paket = txtKdPaket.Text;
            paket.kd_mobil = txtKdMobil.Text;
            paket.paketsewa = txtPaketSewa.Text;
            paket.harga = txtHarga.Text;
            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(paket);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(paket); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtKdPaket.Clear();
                    txtKdMobil.Clear();
                    txtPaketSewa.Clear();
                    txtHarga.Clear();
                    txtKdPaket.Focus();

                }
            }
            else // edit data, panggil method Update
            {
                result = controller.Update(paket);

                if (result > 0)
                {
                    OnUpdate(paket);
                    this.Close();
                }
            }
        }

        private void FrmEntryPakaetsewa_Load(object sender, EventArgs e)
        {

        }
    }
}

      