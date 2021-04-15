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
    public class tbl_transaksiRepo
    {
        private OleDbConnection _conn;
        public tbl_transaksiRepo(DbContext cont)
        {
            _conn = cont.Conn;
        }
        public int Create(tbl_transaksi transaksi)
        {
            int result = 0;
            string sql = @"insert into tbl_transaksi (kd_transaksi, kd_pelanggan, jaminan, kd_paket, jumlah)
                        values (@kd_transaksi, kd_pelanggan, jaminan, kd_paket, jumlah)";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_transaksi", transaksi.kd_transaksi);
                cmd.Parameters.AddWithValue("@kd_pelanggan", transaksi.kd_pelanggan);
                cmd.Parameters.AddWithValue("jaminan", transaksi.jaminan);
                cmd.Parameters.AddWithValue("kd_paket", transaksi.kd_paket);
                cmd.Parameters.AddWithValue("@jumlah", transaksi.jumlah);

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

        public int Delete(tbl_transaksi transaksi)
        {
            int result = 0;
            string sql = @"delete from tbl_transaksi where kd_transaksi = @kd_transaksi";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_transaksi", transaksi.kd_transaksi);

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
        public int Update(tbl_transaksi transaksi)
        {
            int result = 0;
            string sql = @"update tbl_transaksi set kd_transaksi = @kd_transaksi, 
                            kd_pelanggan = @kd_pelanggan, jaminam = @jaminan, kd_paket = @kd_paket, 
                            where jumlah = @jumlah";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_transaksi", transaksi.kd_transaksi);
                cmd.Parameters.AddWithValue("@kd_pelanggan", transaksi.kd_pelanggan);
                cmd.Parameters.AddWithValue("@jaminan", transaksi.jaminan);
                cmd.Parameters.AddWithValue("@kd_paket", transaksi.kd_paket);
                cmd.Parameters.AddWithValue("@jumlah", transaksi.jumlah);

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

        public List<tbl_transaksi> ReadAll()
        {
            var list = new List<tbl_transaksi>();
            try
            {
                string sql = @"select * from tbl_transaksi";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var transaksi = new tbl_transaksi();

                            transaksi.kd_transaksi = dtr["kd_transaksi"].ToString();
                            transaksi.kd_pelanggan = dtr["kd_pelanggan"].ToString();
                            transaksi.jaminan = dtr["jaminan"].ToString();
                            transaksi.kd_paket = dtr["kd_paket"].ToString();
                            transaksi.jumlah = dtr["jumlah"].ToString();

                            list.Add(transaksi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Readtbl_transaksi error: {0}", ex.Message);
            }
            return list;
        }   
        public List<tbl_transaksi> ReadByNama(string jaminan)
        {
            List<tbl_transaksi> list = new List<tbl_transaksi>();
            try
            {
                string sql = @"select kd_transaksi, kd_pelanggan, jaminan, kd_paket, jumlah 
                                from tbl_transaksi where jaminan like @jaminan order by jaminan";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@jaminan", "%" + jaminan + "%");
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                           
                            tbl_transaksi transaksi = new tbl_transaksi();

                            transaksi.kd_transaksi = dtr["kd_transaksi"].ToString();
                            transaksi.kd_pelanggan = dtr["kd_pelanggan"].ToString();
                            transaksi.jaminan = dtr["jaminan"].ToString();
                            transaksi.kd_paket = dtr["kd_paket"].ToString();
                            transaksi.jumlah = dtr["jumlah"].ToString();

                            list.Add(transaksi);
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
        public List<tbl_transaksi> ReadByKDTransaksi(string kd_transaksi)
        {
            List<tbl_transaksi> list = new List<tbl_transaksi>();
            try
            {
                string sql = @"select kd_transaksi, kd_pelanggan, jaminan, kd_paket, jumlah 
                                from tbl_transaksi where kd_transaksi like @kd_transaksi order by kd_transaksi";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@kd_transaksi", "%" + kd_transaksi + "%");
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {

                            tbl_transaksi transaksi = new tbl_transaksi();

                            transaksi.kd_transaksi = dtr["kd_transaksi"].ToString();
                            transaksi.kd_pelanggan = dtr["kd_pelanggan"].ToString();
                            transaksi.jaminan = dtr["jaminan"].ToString();
                            transaksi.kd_paket = dtr["kd_paket"].ToString();
                            transaksi.jumlah = dtr["jumlah"].ToString();

                            list.Add(transaksi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByKDTransaksi error: {0}", ex.Message);
            }
            return list;
        }
        public List<tbl_transaksi> ReadByKDPelanggan(string kd_pelanggan)
        {
            List<tbl_transaksi> list = new List<tbl_transaksi>();
            try
            {
                string sql = @"select kd_transaksi, kd_pelanggan, jaminan, kd_paket, jumlah 
                                from tbl_transaksi where kd_pelanggan like @kd_pelanggan order by kd_pelanggan";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@kd_pelanggan", "%" + kd_pelanggan + "%");
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {

                            tbl_transaksi transaksi = new tbl_transaksi();

                            transaksi.kd_transaksi = dtr["kd_transaksi"].ToString();
                            transaksi.kd_pelanggan = dtr["kd_pelanggan"].ToString();
                            transaksi.jaminan = dtr["jaminan"].ToString();
                            transaksi.kd_paket = dtr["kd_paket"].ToString();
                            transaksi.jumlah = dtr["jumlah"].ToString();

                            list.Add(transaksi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByKDPelanggan error: {0}", ex.Message);
            }
            return list;
        }
    }
}

