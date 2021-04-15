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
    public class tbl_paketsewaController
    {

        private tbl_paketsewaRepo _repo;
        public List<tbl_paketsewa> ReadAll()
        {
            List<tbl_paketsewa> list = new List<tbl_paketsewa>();

            using (DbContext context = new DbContext())
            {
                _repo = new tbl_paketsewaRepo(context);
                list = _repo.ReadAll();
            }

            return list;
        }
        public int Create(tbl_paketsewa paket)
        {
            int result = 0;
            if (string.IsNullOrEmpty(paket.kd_paket))
            {
                MessageBox.Show("kd_paket harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repo = new tbl_paketsewaRepo(context);
                result = _repo.Create(paket);
            }

            if (result == 0)
                MessageBox.Show("Input Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        public int Update(tbl_paketsewa paket)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repo = new tbl_paketsewaRepo(context);
                result = _repo.Update(paket);
            }

            if (result == 0)
                MessageBox.Show("Update Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        public int Delete(tbl_paketsewa paket)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repo = new tbl_paketsewaRepo(context);
                result = _repo.Delete(paket);
            }

            if (result == 0)
                MessageBox.Show("Delete Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
    }
}
