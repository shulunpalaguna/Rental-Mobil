using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMobil.Model.Entity
{
    public class tbl_transaksi
    {
        public string kd_transaksi { get; set; }
        public string kd_pelanggan { get; set; }
        public string kd_admin { get; set; }
        public string jaminan { get; set; }
        public string kd_paket { get; set; }
        public string jumlah{ get; set; }
    }
}
