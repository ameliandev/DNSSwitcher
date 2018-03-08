/*
 * Author: Adrián Melián
 * Date: 17/07/2017
 * Web: www.amelian.eu
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using DNSSwitcher.Clases;
using System.Threading;

namespace DNSSwitcher
{
    public partial class frmMain : Form
    {
        #region Propiedades

        private bool firstTime { get; set; }
        private bool status { get; set; }
        private string log { get; set; }
        private AppConfiguration AppConfiguration { get; set; }
        private Dns Dns { get; set; }
        private AppCulture AppCulture { get; set; }
        #endregion

        #region Constructor

        public frmMain()
        {
            InitializeComponent();

            ConfigureApp();

            if (LoadConfiguration())
            {
                Dns = new Dns();
                ExecuteProcess();
            }

        }

        #endregion

        #region Eventos

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                appNotification.Visible = true;
                this.Hide();
            }
        }

        private void appNotification_Click(object sender, EventArgs e)
        {
            //this.Show();
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            ExecuteProcess();
        }

        private void tsOptActivar_Click(object sender, EventArgs e)
        {
            var dns1 = txtCDNS1.Text.Trim(' ');
            var dns2 = txtCDNS2.Text.Trim(' ');
            var cnnName = txtConnectionName.Text.Trim(' ');

            if (Utils.isValidAddress(dns1)) { Dns.ActivateDNS(0, dns1, cnnName); }
            if (Utils.isValidAddress(dns2)) { Dns.ActivateDNS(1, dns2, cnnName); }

            ExecuteChanges();
        }

        private void tsOptDesactivar_Click(object sender, EventArgs e)
        {
            var dns1 = txtCDNS1.Text.Trim(' ');
            var dns2 = txtCDNS2.Text.Trim(' ');
            var cnnName = txtConnectionName.Text.Trim(' ');

            if (Utils.isValidAddress(dns1)) { Dns.DeactivateDNS(dns1, cnnName); }
            if (Utils.isValidAddress(dns2)) { Dns.DeactivateDNS(dns2, cnnName); }

            ExecuteChanges();
        }

        private void tsOptConfigurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            if (firstTime)
            {
                firstTime = false;
                tsOptConfigurar.Text = AppCulture.GetConfigurationText(firstTime);
                this.Show();
                return;
            }

            if (this.Visible)
            {
                tsOptConfigurar.Text = AppCulture.GetConfigurationText(true);
                this.Hide();
            }
            else
            {
                tsOptConfigurar.Text = AppCulture.GetConfigurationText(false);
                this.Show();
            }
        }

        private void tsOptCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsOptInfo_Click(object sender, EventArgs e)
        {
            var frm = new frmInfo(log);
            frm.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var newConf = new AppConfiguration(txtConnectionName.Text, txtCDNS1.Text, txtCDNS2.Text);
            newConf.Save();
        }

        #endregion

        #region Métodos Privados
        private void ConfigureApp()
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.appNotification.Visible = true;

            AppCulture.AppCultureName = Thread.CurrentThread.CurrentUICulture.Name;

            firstTime = true;
        }
        private void ExecuteProcess()
        {
            var dns1 = txtCDNS1.Text.Trim(' ');
            var dns2 = txtCDNS2.Text.Trim(' ');
            var cnnName = txtConnectionName.Text.Trim(' ');

            var dns1Valida = Utils.isValidAddress(dns1);
            var dns2Valida = Utils.isValidAddress(dns2);

            if (dns1Valida == false && dns2Valida == false) { return; }

            if (Dns.Status)
            {
                if (dns1Valida) { Dns.DeactivateDNS(dns1, cnnName); }
                if (dns2Valida) { Dns.DeactivateDNS(dns2, cnnName); }
            }
            else
            {
                if (dns1Valida) { Dns.ActivateDNS(0, dns1, cnnName); }
                if (dns2Valida) { Dns.ActivateDNS(1, dns2, cnnName); }
            }

            ExecuteChanges();
        }
        private void ExecuteChanges()
        {
            ShowBallongMessage();
            ChangeNotificationIcon();
            ChangeButtonText();
            ChangeInformationText();
        }
        private bool LoadConfiguration()
        {
            AppConfiguration = AppConfiguration.Read();

            if (AppConfiguration == null) { return false; }

            txtConnectionName.Text = AppConfiguration.NetworkName;
            txtCDNS1.Text = Utils.hasNumbers(AppConfiguration.DNS1) ? AppConfiguration.DNS1 : string.Empty;
            txtCDNS2.Text = Utils.hasNumbers(AppConfiguration.DNS2) ? AppConfiguration.DNS2 : string.Empty;

            return true;
        }
        private void ChangeNotificationIcon()
        {
            appNotification.Icon = Dns.Status ? recursos.nOk : recursos.nError;
        }
        private void ChangeButtonText()
        {
            btnAD.Text = AppCulture.GetButtonText(Dns.Status);
            btnAD.ForeColor = Dns.Status ? Color.OrangeRed : Color.ForestGreen;
        }
        private void ChangeInformationText()
        {
            tsOptEstado.Text = AppCulture.GetToolInformationStatusText(Dns.Status);
        }
        private void ShowBallongMessage()
        {
            appNotification.ShowBalloonTip(400, "DNS Switcher", AppCulture.GetBallonMessage(Dns.Status), ToolTipIcon.Info);
        }
        #endregion
    }
}
