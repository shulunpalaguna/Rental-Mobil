using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalMobil.View;

namespace RentalMobil
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frmlogin = new FrmLogin();

            
            if (frmlogin.ShowDialog() == DialogResult.OK) 
                Application.Run(new FrmUtama());
            else
                Application.Exit(); 
        }
    }
}
