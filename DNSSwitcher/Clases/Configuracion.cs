using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace DNSSwitcher.Clases
{
    class AppConfiguration
    {
        private const string FileName = "dnsConfig.json";
        private static string AppPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string FilePath {
            get { return string.Format("{0}{1}", AppPath, FileName); }
        }
        public string NetworkName { get; set; }
        public string DNS1 { get; set; }
        public string DNS2 { get; set; }

        #region Cosntructores

        public AppConfiguration()
        {
            NetworkName = string.Empty;
            DNS1 = string.Empty;
            DNS2 = string.Empty;
        }

        public AppConfiguration(string networkName, string dns1, string dns2)
        {
            NetworkName = networkName;
            DNS1 = dns1;
            DNS2 = dns2;
        }

        public AppConfiguration(string json)
        {
            JObject jObject = JObject.Parse(json);

            if (jObject.HasValues)
            {
                NetworkName = (string)jObject["NombreRed"];
                DNS1 = (string)jObject["DNS1"];
                DNS2 = (string)jObject["DNS2"];
            }
        }

        #endregion

        #region Métodos Públicos

        public void Save()
        {
            try
            {
                string json = JsonConvert.SerializeObject(this);

                if (!File.Exists(FilePath))
                {
                    using (FileStream f = File.Create(FilePath))
                    {
                        f.Close();
                    }
                }

                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                var frm = new frmInfo(ex.Message);
                frm.ShowDialog();
            }

        }

        #endregion

        #region Métodos Internos

        internal static AppConfiguration Read()
        {
            AppConfiguration conf = null;

            string fcontent = string.Empty;

            try
            {
                if (!File.Exists(FilePath)) { return null; }

                fcontent = File.ReadAllText(FilePath);

                if (fcontent == string.Empty) { return null; }

                conf = new AppConfiguration(fcontent);
            }
            catch (Exception ex)
            {
                var frm = new frmInfo(ex.Message);
                frm.ShowDialog();
            }

            return conf;

        }

        #endregion


    }
}
