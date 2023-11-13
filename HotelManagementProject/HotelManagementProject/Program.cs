﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementProject
{
    static class Program
    {
        public static frmLogin loginForm = null;
        public static FrmMain mainForm = null;
        public static frmService serviceForm = null;
        public static frmDevice deviceForm = null;
        public static frmCustomer customerForm = null;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
