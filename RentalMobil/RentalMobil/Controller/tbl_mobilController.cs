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
    public class tbl_mobilController
    {
        private tbl_mobilRepo _repo;
        public List<tbl_mobil> ReadAll()
        {
            // membuat objek collection
            List<tbl_mobil> list = new List<tbl_mobil>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repo = new tbl_mobilRepo(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repo.ReadAll();
            }

            return list;
        }
        public List<tbl_mobil> ReadByNama(string merekmobil)
        {
            // membuat objek collection
            List<tbl_mobil> list = new List<tbl_mobil>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repo = new tbl_mobilRepo(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repo.ReadByNama(merekmobil);
            }

            return list;
        }
        public int Create(tbl_mobil mobil)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(mobil.kd_mobil))
            {
                MessageBox.Show("kd_mobil harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(mobil.nopolisi))
            {
                MessageBox.Show("nopolisi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(mobil.merekmobil))
            {
                MessageBox.Show("merek harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(mobil.warnamobil))
            {
                MessageBox.Show("warna harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(mobil.tahun))
            {
                MessageBox.Show("tahun harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repo = new tbl_mobilRepo(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repo.Create(mobil);
            }

            if (result > 0)
            {
                MessageBox.Show("Data mobil berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mobil gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(tbl_mobil mobil)
        {
            int result = 0;

            if (string.IsNullOrEmpty(mobil.kd_mobil))
            {
                MessageBox.Show("kd_mobil harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(mobil.nopolisi))
            {
                MessageBox.Show("nopolisi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(mobil.merekmobil))
            {
                MessageBox.Show("merek harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(mobil.warnamobil))
            {
                MessageBox.Show("warna harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(mobil.tahun))
            {
                MessageBox.Show("tahun harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repo = new tbl_mobilRepo(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repo.Update(mobil);
            }

            if (result > 0)
            {
                MessageBox.Show("Data mobil berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mobil gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(tbl_mobil mobil)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(mobil.kd_mobil))
            {
                MessageBox.Show("kd_mobil harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repo = new tbl_mobilRepo(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repo.Delete(mobil);
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
