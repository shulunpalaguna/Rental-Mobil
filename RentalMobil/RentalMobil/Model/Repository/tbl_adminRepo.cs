using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using RentalMobil.Model.Entity;
using RentalMobil.Model.Context;

namespace RentalMobil.Model.Repository
{
    public class tbl_adminRepo
    {
        private OleDbConnection _conn;
        public tbl_adminRepo (DbContext cont)
        {
            _conn = cont.Conn;
        }
        public bool IsValidUser(string namaadmin, string password)
        {
            bool result = false;

            string sql = @"select count(*) as row_count
                           from tbl_admin
                           where namaadmin = @namaadmin and password = @password";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@namaadmin", namaadmin);
                cmd.Parameters.AddWithValue("@password", password);

                // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                using (OleDbDataReader dtr = cmd.ExecuteReader())
                {
                    // panggil method Read untuk mendapatkan baris dari result set
                    if (dtr.Read())
                    {
                        result = Convert.ToInt32(dtr["row_count"]) > 0;
                    }
                }
            }
            return result;
        }
    }
}
