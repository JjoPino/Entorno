﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Git_Ex1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// //Comentario de modificacion, para Git
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
