﻿using HSchool.Lib.RegDomain.BL;
using HSchool.Lib.RegDomain.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace HSchool.Winform
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

            Application.Run(new MainForm 
            { 
                WindowState = FormWindowState.Maximized
            });
        }
    }
}
