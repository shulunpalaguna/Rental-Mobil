using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using RentalMobil.Model.Context;
using RentalMobil.Model.Entity;

namespace RentalMobil.Model.Repository
{
    public class tbl_mobilRepo
    {
        private OleDbConnection _conn;
        public tbl_mobilRepo(DbContext cont)
        {
            _conn = cont.Conn;
        }
        public int Create(tbl_mobil mobil)
        {
            int result = 0;
            string sql = @"insert into tbl_mobil (kd_mobil, nopolisi, merekmobil, warnamobil, tahun)
                        values (@kd_mobil, nopolisi, merekmobil, warnamobil, tahun)";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_mobil", mobil.kd_mobil);
                cmd.Parameters.AddWithValue("@nopolisi", mobil.nopolisi);
                cmd.Parameters.AddWithValue("@merekmobil", mobil.merekmobil);
                cmd.Parameters.AddWithValue("@warnamobil", mobil.warnamobil);
                cmd.Parameters.AddWithValue("@tahun", mobil.tahun);
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
        public int Delete(tbl_mobil mobil)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from tbl_mobil
                           where kd_mobil = @kd_mobil";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_mobil", mobil.kd_mobil);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }
        public int Update(tbl_mobil mobil)
        {
            int result = 0;
            string sql = @"update tbl_mobil set nopolisi = @nopolisi, 
                            merekmobil = @merekmobil, warnamobil = @warnamobil, tahun = @tahun 
                            where kd_mobil = @kd_mobil";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nopolisi", mobil.nopolisi);
                cmd.Parameters.AddWithValue("@merekmobil", mobil.merekmobil);
                cmd.Parameters.AddWithValue("@warnamobil", mobil.warnamobil);
                cmd.Parameters.AddWithValue("@tahun", mobil.tahun);
                cmd.Parameters.AddWithValue("@kd_mobil", mobil.kd_mobil);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update Error: {0}", ex.Message);
                }
            }
            return result;
        }
        public List<tbl_mobil> ReadAll()
        {
            var list = new List<tbl_mobil>();
            try
            {
                string sql = @"select kd_mobil, nopolisi, merekmobil, warnamobil, tahun from 
                            tbl_mobil";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var mobil = new tbl_mobil();

                            mobil.kd_mobil = dtr["kd_mobil"].ToString();
                            mobil.nopolisi = dtr["nopolisi"].ToString();
                            mobil.merekmobil = dtr["merekmobil"].ToString();
                            mobil.warnamobil = dtr["warnamobil"].ToString();
                            mobil.tahun = dtr["tahun"].ToString();
                            list.Add(mobil);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }
        public List<tbl_mobil> ReadByNama(string merekmobil)
        {
            List<tbl_mobil> list = new List<tbl_mobil>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select kd_mobil, nopolisi, merekmobil, warnamobil, tahun 
                                from tbl_mobil where merekmobil like @merekmobil order by merekmobil";


                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@merekmobil", "%" + merekmobil + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            tbl_mobil mobil = new tbl_mobil();
                            mobil.kd_mobil = dtr["kd_mobil"].ToString();
                            mobil.nopolisi = dtr["nopolisi"].ToString();
                            mobil.merekmobil = dtr["merekmobil"].ToString();
                            mobil.warnamobil = dtr["warnamobil"].ToString();
                            mobil.tahun = dtr["tahun"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(mobil);
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
