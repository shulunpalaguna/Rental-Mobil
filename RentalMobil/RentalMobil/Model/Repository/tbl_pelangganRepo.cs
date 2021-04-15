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
    public class tbl_pelangganRepo
    {
        private OleDbConnection _conn;
        public tbl_pelangganRepo(DbContext cont)
        {
            _conn = cont.Conn;
        }
        public int Create(tbl_pelanggan pelanggan)
        {
            int result = 0;
            string sql = @"insert into tbl_pelanggan (kd_pelanggan, namapelanggan, alamat, notlp)
                        values (@kd_pelanggan, namapelanggan, alamat, notlp)";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_pelanggan", pelanggan.kd_pelanggan);
                cmd.Parameters.AddWithValue("@namapelanggan", pelanggan.namapelanggan);
                cmd.Parameters.AddWithValue("@alamat", pelanggan.alamat);
                cmd.Parameters.AddWithValue("@notlp", pelanggan.notlp);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create Error: {0}", ex.Message);
                }
            }
            return result;
        }
        public int Delete(tbl_pelanggan pelanggan)
        {
            int result = 0;
            string sql = @"delete from tbl_pelanggan where kd_pelanggan = @kd_pelanggan";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_pelanggan", pelanggan.kd_pelanggan);
                cmd.Parameters.AddWithValue("@namapelanggan", pelanggan.namapelanggan);
                cmd.Parameters.AddWithValue("@alamat", pelanggan.alamat);
                cmd.Parameters.AddWithValue("@notlp", pelanggan.notlp);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }
        public int Update(tbl_pelanggan pelanggan)
        {
            int result = 0;
            string sql = @"update tbl_pelanggan set namapelanggan = @namapelangggan, 
                            alamat = @alamat, notlp = @notlp 
                            where kd_pelanggan = @kd_pelanggan";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {

                cmd.Parameters.AddWithValue("@namapelanggan", pelanggan.namapelanggan);
                cmd.Parameters.AddWithValue("@alamat", pelanggan.alamat);
                cmd.Parameters.AddWithValue("@notlp", pelanggan.notlp);
                cmd.Parameters.AddWithValue("@kd_pelanggan", pelanggan.kd_pelanggan);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create Error: {0}", ex.Message);
                }
            }
            return result;
        }
        public List<tbl_pelanggan> Readtbl_pelanggan()
        {
            var list = new List<tbl_pelanggan>();
            try
            {
                string sql = @"select kd_pelanggan, namapelanggan, alamat, notlp from tbl_pelanggan 
                             order by namapelanggan";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var pelanggan = new tbl_pelanggan();

                            pelanggan.kd_pelanggan = dtr["kd_pelanggan"].ToString();
                            pelanggan.namapelanggan = dtr["namapelanggan"].ToString();
                            pelanggan.alamat = dtr["alamat"].ToString();
                            pelanggan.notlp = dtr["notlp"].ToString();
                            list.Add(pelanggan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Readtbl_pelanggan error: {0}", ex.Message);
            }
            return list;
        }
        public List<tbl_pelanggan> ReadByNama(string namapelanggan)
        {
            List<tbl_pelanggan> list = new List<tbl_pelanggan>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select kd_pelanggan, namapelanggan, alamat, notlp 
                                from tbl_pelanggan where namapelanggan like @namapelanggan order by namapelanggan";


                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@namapelanggan", "%" + namapelanggan + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            tbl_pelanggan pelanggan = new tbl_pelanggan();
                            pelanggan.kd_pelanggan = dtr["kd_pelanggan"].ToString();
                            pelanggan.namapelanggan = dtr["namapelanggan"].ToString();
                            pelanggan.alamat = dtr["alamat"].ToString();
                            pelanggan.notlp = dtr["notlp"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(pelanggan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }
    }
}
