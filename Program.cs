using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataGrafica
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        private static void UpdateConfig(string key, string value)
        {
            try
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configFile.AppSettings.Settings[key].Value = value;
                configFile.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static void Main()
        {
            
            Uri myUri = new Uri("http://server-laptop.mywire.org/");
            var _ip = Dns.GetHostAddresses(myUri.Host)[0];

            UpdateConfig("ip",_ip.ToString());

            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");





            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login());

            
        }
    }
}
