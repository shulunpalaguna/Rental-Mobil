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
    public class tbl_paketsewaRepo
    {
        private OleDbConnection _conn;
        public tbl_paketsewaRepo(DbContext cont)
        {
            _conn = cont.Conn;
        }
        public int Create(tbl_paketsewa paketsewa)
        {
            int result = 0;
            string sql = @"insert into tbl_paketsewa (kd_paket, kd_mobil, paketsewa, harga)
                        values (@kd_paket, kd_mobil, paketsewa, harga)";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_paket", paketsewa.kd_paket);
                cmd.Parameters.AddWithValue("@kd_mobil", paketsewa.kd_mobil);
                cmd.Parameters.AddWithValue("@paketsewa", paketsewa.paketsewa);
                cmd.Parameters.AddWithValue("@harga", paketsewa.harga);

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
        public int Delete(tbl_paketsewa paket)
        {
            int result = 0;
            string sql = @"delete from tbl_paketsewa where kd_paket = @kd_paket";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_paket", paket.kd_paket);
                cmd.Parameters.AddWithValue("@kd_mobil", paket.kd_mobil);
                cmd.Parameters.AddWithValue("@paketsewa", paket.paketsewa);
                cmd.Parameters.AddWithValue("@harga", paket.harga);
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
        public int Update(tbl_paketsewa paket)
        {
            int result = 0;
            string sql = @"update tbl_paketsewa set kd_mobil = @kd_mobil, 
                            paketsewa = @paketsewa, harga = @harga 
                            where kd_paket = @kd_paket";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {

                cmd.Parameters.AddWithValue("@kd_mobil", paket.kd_mobil);
                cmd.Parameters.AddWithValue("@paketsewa", paket.paketsewa);
                cmd.Parameters.AddWithValue("@harga", paket.harga);
                cmd.Parameters.AddWithValue("@kd_paket", paket.kd_paket);
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
        public List<tbl_paketsewa> ReadAll()
        {
            var list = new List<tbl_paketsewa>();
            try
            {
                string sql = @"select kd_paket, kd_mobil, paketsewa, harga from tbl_paketsewa";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var paket = new tbl_paketsewa();

                            paket.kd_paket = dtr["kd_paket"].ToString();
                            paket.kd_mobil = dtr["kd_mobil"].ToString();
                            paket.paketsewa = dtr["paketsewa"].ToString();
                            paket.harga = dtr["harga"].ToString();
                            list.Add(paket);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByD error: {0}", ex.Message);
            }
            return list;
        }
    }
}
