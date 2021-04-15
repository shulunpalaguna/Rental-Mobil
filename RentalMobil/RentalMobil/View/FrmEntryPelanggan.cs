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
    public partial class FrmEntryPelanggan : Form
    {
        public delegate void CreateUpdateEventHandler(tbl_pelanggan pelanggan);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private tbl_pelangganController controller;
        private bool isNewData = true;
        private tbl_pelanggan pelanggan;
        public FrmEntryPelanggan()
        {
            InitializeComponent();
        }
        public FrmEntryPelanggan(string title, tbl_pelangganController controller)
           : this()
        {

            this.Text = title;
            this.controller = controller;
        }


        public FrmEntryPelanggan(string title, tbl_pelanggan obj, tbl_pelangganController controller)
            : this()
        {
            this.Text = title;
            this.controller = controller;

            isNewData = false;
            pelanggan = obj;


            textBox1.Text = pelanggan.kd_pelanggan;
            textBox2.Text = pelanggan.namapelanggan;
            textBox3.Text = pelanggan.alamat;
            textBox4.Text = pelanggan.notlp;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) pelanggan = new tbl_pelanggan();


            pelanggan.kd_pelanggan = textBox1.Text;
            pelanggan.namapelanggan = textBox2.Text;
            pelanggan.alamat = textBox3.Text;
            pelanggan.notlp = textBox4.Text;

            int result = 0;

            if (isNewData)
            {

                result = controller.Create(pelanggan);

                if (result > 0)
                {
                    OnCreate(pelanggan);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                result = controller.Update(pelanggan);

                if (result > 0)
                {
                    OnUpdate(pelanggan);
                    this.Close();
                }
            }
        }
    }
}
