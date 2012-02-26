﻿using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;

namespace ynetMivzakim
{
    static class Program
    {
        public static bool IsRuntime;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            try
            {
                IsRuntime = true;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception exp)
            {
                MessageBox.Show("Dooh! " + exp.Message, "Dooh! ");
            }
        }
    }
}
