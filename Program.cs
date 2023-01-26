using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BlumBlumShub
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string currentDirectoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            if (!File.Exists($"{currentDirectoryPath}\\DB.db"))
            {
                new DB("Data Source=DB.db;Version=3;").InitializeDatabase();
            }
            Application.Run(new Auth());
            
        }
    }
}
