using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Configuration
{
    internal class ConfigurationFromFile
    {
        private static JObject root;

        static ConfigurationFromFile()
        {

            Environment.SetEnvironmentVariable("env", "qa");

            var env = Environment.GetEnvironmentVariable("Browser");

            root = JObject.Parse(File.ReadAllText($"appsettings.{env}.json"));
        }
    
        public static bool GetHeadlessParametr()
        {
            bool wait_runnsettings = bool.Parse(TestContext.Parameters.Get("ImplicityWait"));
            bool wait_Json = bool.Parse(root[".Browser.Headless"].ToString());
            return wait_runnsettings;
        }

        public static object GetParametr(string parametr)
        {
            object wait_runnsettings =TestContext.Parameters.Get(parametr);
            object wait_Json = root[parametr].ToString() ;
            return wait_runnsettings;
        }


    }

}