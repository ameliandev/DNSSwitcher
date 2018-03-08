using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DNSSwitcher
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        public frmInfo(string texto)
        {
            InitializeComponent();

            this.rtInfo.AppendText(texto);
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
