using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DNSSwitcher.Clases
{
    class Dns
    {
        #region Propiedades

        public bool Status { get; set; }
        private int Indice { get; set; }
        private string IPv4 { get; set; }
        private string NetworkName { get; set; }
        private string StrActivate
        {
            get
            {
                return string.Format("interface ipv4 add dnsserver \"RedTrabajo\" address={0} index={1}", IPv4, Indice);
            }
        }
        private string StrDeactivate
        {
            get
            {
                return string.Format("interface ipv4 delete dnsserver \"{0}\" address={1}", NetworkName, IPv4);
            }
        }
        #endregion

        private enum Actions
        {
            Activate, Deactivate
        }

        public void ActivateDNS(int index, string address, string cnnName)
        {
            IPv4 = address.Trim(' ');
            NetworkName = cnnName.Trim(' ');
            Indice = index;

            StartProcess(Actions.Activate);
        }

        public void DeactivateDNS(string address, string cnnName)
        {
            IPv4 = address.Trim(' ');
            NetworkName = cnnName.Trim(' ');

            StartProcess(Actions.Deactivate);

        }

        private void StartProcess(Dns.Actions accion)
        {
            if (IPv4 == string.Empty) { throw new Exception("Address direction can't be empty"); }
            if (NetworkName == string.Empty) { throw new Exception("Connection name can't be empty"); }

            try
            {
                switch (accion)
                {
                    case Actions.Activate:
                        RunProcess(StrActivate);
                        Status = true;
                        break;
                    case Actions.Deactivate:
                        RunProcess(StrDeactivate);
                        Status = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void RunProcess(string arguments)
        {
            string output = string.Empty;

            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo("netsh", arguments);

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                procStartInfo.Verb = "runas";

                // Starts the process
                using (Process p = Process.Start(procStartInfo))
                {
                    // Reads the output to a string
                    output = p.StandardOutput.ReadToEnd();

                    // Waits for the process to exit must come *after* StandardOutput is "empty"
                    // so that we don't deadlock because the intermediate kernel pipe is full.
                    p.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                var message = output + Environment.NewLine + ex.Message;
                throw new Exception(message);
            }
        }
    }
}
