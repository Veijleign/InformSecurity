using ShifrLab1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifrLab1
{
    static class Program
    {
        static readonly public string dbPath = @"DataBase.txt";
        static public encryptionData encrController;
        static public DBController dbController;
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread] // everything is managed by one thread
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EnterWindow());
        }
    }
}
