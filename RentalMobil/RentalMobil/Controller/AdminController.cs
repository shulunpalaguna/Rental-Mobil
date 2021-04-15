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
    public class AdminController
    {
        
        private tbl_adminRepo _repo;
        public bool IsValidUser(string namaadmin, string password)
        {

            // cek npm yang diinputkan tidak boleh kosong
            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(namaadmin))
            {
                MessageBox.Show("namaadmin harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidUser = false;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repo = new tbl_adminRepo(context);

                // panggil method Create class repository untuk menambahkan data
                isValidUser = _repo.IsValidUser(namaadmin, password);
            }
            return true;
        }
    }
}