using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Configuration;

namespace RealtimeChartDemo
{
    public class AppSettings
    {
        public static String ReadSetting(String key)
        {
            String result = "Not Found";
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                result = appSettings[key] ?? "Not Found";
                //result = appSettings[key];
            }
            catch (ConfigurationErrorsException cex)
            {
                MessageBox.Show(cex.Message.ToString());
            }

            return result;
        }

        public static void UpdateSettings(String key, String value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] != null)
                {
                    settings[key].Value = value;
                    configFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                }
            }
            catch (ConfigurationErrorsException cex)
            {
                MessageBox.Show(cex.Message.ToString());
            }
        }

        public static int add(int num1, int num2)
        {
            return num1+num2;
        }

    }
}
