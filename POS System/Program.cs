using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;
using System.Configuration;

namespace POS_System
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

            Database.connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

            Connection.connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

            Global.user = ConfigurationManager.ConnectionStrings["user"].ConnectionString;
            Global.password = ConfigurationManager.ConnectionStrings["password"].ConnectionString;
            Global.database = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            Global.server = ConfigurationManager.ConnectionStrings["server"].ConnectionString;
            Global.port = ConfigurationManager.ConnectionStrings["port"].ConnectionString;

            Application.Run(new frmLogin());

            //bool validate = false;
            //if (validate)
            //{
            //    Application.Run(new frmLogin());
            //}
            //else
            //{
            //    Application.Run(new frmApplication());
            //}



        }
    }
}
