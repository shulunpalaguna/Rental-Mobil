using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using RentalMobil.Model.Entity;
using RentalMobil.Model.Context;
using RentalMobil.Model.Repository;
using System.Windows.Forms;

namespace RentalMobil.Controller
{
    public class tbl_transaksiController
    {
        private tbl_transaksiRepo _repo;
        public List<tbl_transaksi> ReadAll()
        {
            List<tbl_transaksi> tbl_transaksi = new List<tbl_transaksi>();

            using (DbContext context = new DbContext())
            {
                _repo = new tbl_transaksiRepo (context);
                tbl_transaksi = _repo.ReadAll();
            }

            return tbl_transaksi;
        }
        public List<tbl_transaksi> ReadByNama(string jaminan)
        {
            List<tbl_transaksi> list = new List<tbl_transaksi>();

            using (DbContext context = new DbContext())
            {
                _repo = new tbl_transaksiRepo(context);
                list = _repo.ReadByNama(jaminan);
            }

            return list;
        }
        public List<tbl_transaksi> ReadByKDTransaksi(string kd_transaksi)
        {
            List<tbl_transaksi> list = new List<tbl_transaksi>();

            using (DbContext context = new DbContext())
            {
                _repo = new tbl_transaksiRepo(context);
                list = _repo.ReadByKDTransaksi(kd_transaksi);
            }

            return list;
        }
        public List<tbl_transaksi> ReadByKDPelanggan(string kd_pelanggan)
        {
            List<tbl_transaksi> list = new List<tbl_transaksi>();

            using (DbContext context = new DbContext())
            {
                _repo = new tbl_transaksiRepo(context);
                list = _repo.ReadByKDPelanggan(kd_pelanggan);
            }

            return list;
        }
        public int Create(tbl_transaksi transaksi)
        {
            var result = 0;
            if (string.IsNullOrEmpty(transaksi.kd_transaksi))
            {
                MessageBox.Show("kd_transaksi harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repo = new tbl_transaksiRepo(context);
                result = _repo.Create(transaksi);
            }

            if (result == 0)
                MessageBox.Show("Input Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        public int Update(tbl_transaksi transaksi)
        {
            var result = 0;

            using (DbContext context = new DbContext())
            {
                _repo = new tbl_transaksiRepo(context);
                result = _repo.Update(transaksi);
            }

            if (result == 0)
                MessageBox.Show("Update Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        public int Delete(tbl_transaksi transaksi)
        {
            var result = 0;
            using (DbContext context = new DbContext())
            {
                _repo = new tbl_transaksiRepo(context);
                result = _repo.Delete(transaksi);
            }

            if (result == 0)
                MessageBox.Show("Delete Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
    }
}