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
    public partial class FrmEntryTransaksi : Form
    {
        public delegate void CreateUpdateEventHandler(tbl_transaksi transaksi);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private tbl_transaksiController controller;
        private bool isNewData = true;
        private tbl_transaksi transaksi;
        public FrmEntryTransaksi()
        {
            InitializeComponent();
        }
        public FrmEntryTransaksi(string title, tbl_transaksiController controller)
          : this()
        {

            this.Text = title;
            this.controller = controller;
        }


        public FrmEntryTransaksi(string title, tbl_transaksi obj, tbl_transaksiController controller)
            : this()
        {
            this.Text = title;
            this.controller = controller;

            isNewData = false;
            transaksi = obj;


            transaksi.kd_transaksi = textBox1.Text;
            transaksi.kd_pelanggan = textBox2.Text;
            transaksi.jaminan = textBox4.Text;
            transaksi.kd_paket = textBox5.Text;
            transaksi.jumlah = textBox6.Text;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) transaksi = new tbl_transaksi();


            transaksi.kd_transaksi = textBox1.Text;
            transaksi.kd_pelanggan = textBox2.Text;
            transaksi.jaminan = textBox4.Text;
            transaksi.kd_paket = textBox5.Text;
            transaksi.jumlah = textBox6.Text;

            int result = 0;

            if (isNewData)
            {

                result = controller.Create(transaksi);

                if (result > 0)
                {
                    OnCreate(transaksi);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox1.Focus();
                }

            }
            else
            {
                result = controller.Update(transaksi);

                if (result > 0)
                {
                    OnUpdate(transaksi);
                    this.Close();
                }
            }
        }
    }
}
