using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Year_14_CA_SSD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //String location = AppDomain.CurrentDomain.BaseDirectory;
            //int index = location.IndexOf("Bin");
            //String Path = location;
            //if(index > 0)
            //{
            //    Path = location.Remove(index);
            //}
            //AppDomain.CurrentDomain.SetData("DataDirectory", Path);
            string fullPath = AppDomain.CurrentDomain.BaseDirectory;
            Regex rg = new Regex($"\\[^\\]+\\[^\\]$");
            string partToCut = rg.Match(fullPath).Value;
            string shortPath = fullPath.Remove(fullPath.Length - partToCut.Length - 1);
            Globals.connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename =" + shortPath + "\\MyDatabase.mdf;Integrated Security=True;";
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PanelForm());
        }
    }
   
}
