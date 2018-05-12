using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Logic
{
    public class Configuracion
    {
        public static string ReadValueFromAppConfig(string key)
        {
             return ConfigurationManager.AppSettings[key];
        }

        public static void SetValueFromAppConfig(string key, string value)
        {
            ConfigurationManager.AppSettings[key] = value;
        }
    }
}
