namespace Tenant
{
    partial class frmLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoad));
            pictureBox1 = new PictureBox();
            pnl_dwn = new Panel();
            lblState2 = new Label();
            linkConfig = new LinkLabel();
            pictureBox2 = new PictureBox();
            lblState1 = new Label();
            lblVersion = new Label();
            lblv = new Label();
            lblInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_dwn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Tenant_logo_rw;
            pictureBox1.Location = new Point(12, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 53);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnl_dwn
            // 
            pnl_dwn.BackColor = Color.FromArgb(3, 22, 29);
            pnl_dwn.Controls.Add(lblState2);
            pnl_dwn.Controls.Add(linkConfig);
            pnl_dwn.Controls.Add(pictureBox2);
            pnl_dwn.Controls.Add(lblState1);
            pnl_dwn.Controls.Add(lblVersion);
            pnl_dwn.Controls.Add(lblv);
            pnl_dwn.Controls.Add(lblInfo);
            pnl_dwn.Dock = DockStyle.Bottom;
            pnl_dwn.Location = new Point(0, 166);
            pnl_dwn.Name = "pnl_dwn";
            pnl_dwn.Size = new Size(584, 145);
            pnl_dwn.TabIndex = 1;
            // 
            // lblState2
            // 
            lblState2.ForeColor = SystemColors.ControlLight;
            lblState2.Location = new Point(12, 37);
            lblState2.Name = "lblState2";
            lblState2.Size = new Size(521, 20);
            lblState2.TabIndex = 6;
            lblState2.Text = "Reintentando conexion.";
            lblState2.Visible = false;
            // 
            // linkConfig
            // 
            linkConfig.ActiveLinkColor = SystemColors.ControlDark;
            linkConfig.AutoSize = true;
            linkConfig.Cursor = Cursors.Hand;
            linkConfig.LinkColor = Color.White;
            linkConfig.Location = new Point(12, 65);
            linkConfig.Name = "linkConfig";
            linkConfig.Size = new Size(180, 15);
            linkConfig.TabIndex = 5;
            linkConfig.TabStop = true;
            linkConfig.Text = "Modifique la configuración aquí.";
            linkConfig.Visible = false;
            linkConfig.VisitedLinkColor = Color.White;
            linkConfig.LinkClicked += linkConfig_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.line;
            pictureBox2.Location = new Point(-24, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(636, 10);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // lblState1
            // 
            lblState1.ForeColor = SystemColors.ControlLight;
            lblState1.Location = new Point(12, 17);
            lblState1.Name = "lblState1";
            lblState1.Size = new Size(521, 20);
            lblState1.TabIndex = 3;
            lblState1.Text = "Cargando recursos... ";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.ForeColor = SystemColors.ControlLight;
            lblVersion.Location = new Point(534, 121);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(38, 15);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "0.0.1b";
            // 
            // lblv
            // 
            lblv.AutoSize = true;
            lblv.ForeColor = SystemColors.ControlLight;
            lblv.Location = new Point(488, 121);
            lblv.Name = "lblv";
            lblv.Size = new Size(45, 15);
            lblv.TabIndex = 1;
            lblv.Text = "Version";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = SystemColors.ControlLight;
            lblInfo.Location = new Point(12, 121);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(293, 15);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Garyz maldito hombre. Todos los derechos reservados.";
            // 
            // frmLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.back_city_lima;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 311);
            ControlBox = false;
            Controls.Add(pnl_dwn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLoad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TenantHub";
            FormClosed += frmLoad_FormClosed;
            Load += frmLoad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_dwn.ResumeLayout(false);
            pnl_dwn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel pnl_dwn;
        private Label lblInfo;
        private Label lblState1;
        private Label lblVersion;
        private Label lblv;
        private PictureBox pictureBox2;
        private LinkLabel linkConfig;
        private Label lblState2;
    }
}