namespace DNSSwitcher
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblInfo = new System.Windows.Forms.Label();
            this.appNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuNotificacion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsOptEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsOptActivar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOptDesactivar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOptConfigurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOptCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtConnectionName = new System.Windows.Forms.TextBox();
            this.lblInfoConeccion = new System.Windows.Forms.Label();
            this.btnAD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsOptInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCDNS1 = new IPAddressControlLib.IPAddressControl();
            this.txtCDNS2 = new IPAddressControlLib.IPAddressControl();
            this.menuNotificacion.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            resources.ApplyResources(this.lblInfo, "lblInfo");
            this.lblInfo.Name = "lblInfo";
            // 
            // appNotification
            // 
            this.appNotification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.appNotification.ContextMenuStrip = this.menuNotificacion;
            resources.ApplyResources(this.appNotification, "appNotification");
            this.appNotification.Click += new System.EventHandler(this.appNotification_Click);
            // 
            // menuNotificacion
            // 
            this.menuNotificacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOptEstado,
            this.toolStripSeparator1,
            this.tsOptActivar,
            this.tsOptDesactivar,
            this.tsOptConfigurar,
            this.tsOptCerrar});
            this.menuNotificacion.Name = "menuNotificacion";
            resources.ApplyResources(this.menuNotificacion, "menuNotificacion");
            // 
            // tsOptEstado
            // 
            resources.ApplyResources(this.tsOptEstado, "tsOptEstado");
            this.tsOptEstado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tsOptEstado.Image = global::DNSSwitcher.recursos.nInfo;
            this.tsOptEstado.Name = "tsOptEstado";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tsOptActivar
            // 
            this.tsOptActivar.Image = global::DNSSwitcher.recursos.nOk1;
            this.tsOptActivar.Name = "tsOptActivar";
            resources.ApplyResources(this.tsOptActivar, "tsOptActivar");
            this.tsOptActivar.Click += new System.EventHandler(this.tsOptActivar_Click);
            // 
            // tsOptDesactivar
            // 
            this.tsOptDesactivar.Image = global::DNSSwitcher.recursos.nError1;
            this.tsOptDesactivar.Name = "tsOptDesactivar";
            resources.ApplyResources(this.tsOptDesactivar, "tsOptDesactivar");
            this.tsOptDesactivar.Click += new System.EventHandler(this.tsOptDesactivar_Click);
            // 
            // tsOptConfigurar
            // 
            this.tsOptConfigurar.Image = global::DNSSwitcher.recursos.nConf1;
            this.tsOptConfigurar.Name = "tsOptConfigurar";
            resources.ApplyResources(this.tsOptConfigurar, "tsOptConfigurar");
            this.tsOptConfigurar.Click += new System.EventHandler(this.tsOptConfigurar_Click);
            // 
            // tsOptCerrar
            // 
            this.tsOptCerrar.Name = "tsOptCerrar";
            resources.ApplyResources(this.tsOptCerrar, "tsOptCerrar");
            this.tsOptCerrar.Click += new System.EventHandler(this.tsOptCerrar_Click);
            // 
            // txtConnectionName
            // 
            resources.ApplyResources(this.txtConnectionName, "txtConnectionName");
            this.txtConnectionName.Name = "txtConnectionName";
            // 
            // lblInfoConeccion
            // 
            resources.ApplyResources(this.lblInfoConeccion, "lblInfoConeccion");
            this.lblInfoConeccion.Name = "lblInfoConeccion";
            // 
            // btnAD
            // 
            resources.ApplyResources(this.btnAD, "btnAD");
            this.btnAD.Name = "btnAD";
            this.btnAD.UseVisualStyleBackColor = true;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOptInfo});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            // 
            // tsOptInfo
            // 
            this.tsOptInfo.Name = "tsOptInfo";
            resources.ApplyResources(this.tsOptInfo, "tsOptInfo");
            this.tsOptInfo.Click += new System.EventHandler(this.tsOptInfo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::DNSSwitcher.recursos.nSave;
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCDNS1
            // 
            this.txtCDNS1.AllowInternalTab = false;
            this.txtCDNS1.AutoHeight = true;
            this.txtCDNS1.BackColor = System.Drawing.SystemColors.Window;
            this.txtCDNS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCDNS1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtCDNS1, "txtCDNS1");
            this.txtCDNS1.Name = "txtCDNS1";
            this.txtCDNS1.ReadOnly = false;
            // 
            // txtCDNS2
            // 
            this.txtCDNS2.AllowInternalTab = false;
            this.txtCDNS2.AutoHeight = true;
            this.txtCDNS2.BackColor = System.Drawing.SystemColors.Window;
            this.txtCDNS2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCDNS2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtCDNS2, "txtCDNS2");
            this.txtCDNS2.Name = "txtCDNS2";
            this.txtCDNS2.ReadOnly = false;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCDNS2);
            this.Controls.Add(this.txtCDNS1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAD);
            this.Controls.Add(this.lblInfoConeccion);
            this.Controls.Add(this.txtConnectionName);
            this.Controls.Add(this.lblInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Opacity = 0.95D;
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuNotificacion.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.NotifyIcon appNotification;
        private System.Windows.Forms.TextBox txtConnectionName;
        private System.Windows.Forms.Label lblInfoConeccion;
        private System.Windows.Forms.Button btnAD;
        private System.Windows.Forms.ContextMenuStrip menuNotificacion;
        private System.Windows.Forms.ToolStripMenuItem tsOptActivar;
        private System.Windows.Forms.ToolStripMenuItem tsOptDesactivar;
        private System.Windows.Forms.ToolStripMenuItem tsOptConfigurar;
        private System.Windows.Forms.ToolStripMenuItem tsOptEstado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsOptCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsOptInfo;
        private System.Windows.Forms.Button btnGuardar;
        private IPAddressControlLib.IPAddressControl txtCDNS1;
        private IPAddressControlLib.IPAddressControl txtCDNS2;
    }
}

