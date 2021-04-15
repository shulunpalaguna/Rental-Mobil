using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalMobil.Model.Entity;
using RentalMobil.Model.Context;
using RentalMobil.Model.Repository;
using System.Windows.Forms;

namespace RentalMobil.Controller
{
    public class tbl_pelangganController
    {
        private tbl_pelangganRepo _repo;
        public List<tbl_pelanggan> Readtbl_pelanggan()
        {
            List<tbl_pelanggan> tbl_pelanggan = new List<tbl_pelanggan>();

            using (DbContext context = new DbContext())
            {
                _repo = new tbl_pelangganRepo(context);
                tbl_pelanggan = _repo.Readtbl_pelanggan();
            }

            return tbl_pelanggan;
        }
        public List<tbl_pelanggan> ReadByNama(string namapelanggan)
        {
            // membuat objek collection
            List<tbl_pelanggan> list = new List<tbl_pelanggan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repo = new tbl_pelangganRepo(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repo.ReadByNama(namapelanggan);
            }
            return list;
        }
            public int Create(tbl_pelanggan pelanggan)
        {
            var result = 0;
            if (string.IsNullOrEmpty(pelanggan.kd_pelanggan))
            {
                MessageBox.Show("kd_pelanggan harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repo = new tbl_pelangganRepo(context);
                result = _repo.Create(pelanggan);
            }
            if (result > 0)
            {
                MessageBox.Show("Data pelanggan berhasil diInput !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pelanggan gagal diInput !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
        public int Update(tbl_pelanggan pelanggan)
        {
            var result = 0;

            using (DbContext context = new DbContext())
            {
                _repo = new tbl_pelangganRepo(context);
                result = _repo.Update(pelanggan);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pelanggan berhasil diUpdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pelanggan gagal diUpdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
        public int Delete(tbl_pelanggan pelanggan)
        {
            var result = 0;
            using (DbContext context = new DbContext())
            {
                _repo = new tbl_pelangganRepo(context);
                result = _repo.Delete(pelanggan);
            }
            if (result > 0)
            {
                MessageBox.Show("Data mobil berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mobil gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
