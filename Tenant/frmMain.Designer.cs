namespace Tenant
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlControlBox = new Panel();
            btnMaxNor = new Button();
            btnCerrar = new Button();
            btnMaxMax = new Button();
            btnMinimize = new Button();
            logo = new PictureBox();
            pnlNavBar = new Panel();
            pnlContratos = new Panel();
            btnContratos = new Button();
            pnlCasas = new Panel();
            btnPropiedades = new Button();
            pnlProp = new Panel();
            btnPropietarios = new Button();
            pnlInqui = new Panel();
            btnInqui = new Button();
            pnlHome = new Panel();
            btnHome = new Button();
            pnlLogo = new Panel();
            imgLogo = new PictureBox();
            pnlControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            pnlNavBar.SuspendLayout();
            pnlContratos.SuspendLayout();
            pnlCasas.SuspendLayout();
            pnlProp.SuspendLayout();
            pnlInqui.SuspendLayout();
            pnlHome.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlControlBox
            // 
            pnlControlBox.BackColor = Color.FromArgb(35, 35, 35);
            pnlControlBox.Controls.Add(btnMaxNor);
            pnlControlBox.Controls.Add(btnCerrar);
            pnlControlBox.Controls.Add(btnMaxMax);
            pnlControlBox.Controls.Add(btnMinimize);
            pnlControlBox.Controls.Add(logo);
            pnlControlBox.Dock = DockStyle.Top;
            pnlControlBox.Location = new Point(0, 0);
            pnlControlBox.Name = "pnlControlBox";
            pnlControlBox.Size = new Size(1360, 30);
            pnlControlBox.TabIndex = 1;
            pnlControlBox.DoubleClick += pnlControlBox_DoubleClick;
            pnlControlBox.MouseDown += pnlControlBox_MouseDown;
            pnlControlBox.MouseMove += pnlControlBox_MouseMove;
            // 
            // btnMaxNor
            // 
            btnMaxNor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaxNor.FlatAppearance.BorderColor = Color.White;
            btnMaxNor.FlatAppearance.BorderSize = 0;
            btnMaxNor.FlatStyle = FlatStyle.Flat;
            btnMaxNor.Image = Properties.Resources.controlMaxNormal_20px;
            btnMaxNor.Location = new Point(1249, 1);
            btnMaxNor.Name = "btnMaxNor";
            btnMaxNor.Size = new Size(56, 29);
            btnMaxNor.TabIndex = 7;
            btnMaxNor.UseVisualStyleBackColor = true;
            btnMaxNor.Click += btnMaxNor_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderColor = Color.White;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = Properties.Resources.controlCerrar_15px;
            btnCerrar.Location = new Point(1304, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(56, 29);
            btnCerrar.TabIndex = 6;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMaxMax
            // 
            btnMaxMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaxMax.FlatAppearance.BorderColor = Color.White;
            btnMaxMax.FlatAppearance.BorderSize = 0;
            btnMaxMax.FlatStyle = FlatStyle.Flat;
            btnMaxMax.Image = Properties.Resources.controlMaxMax_20px;
            btnMaxMax.Location = new Point(1249, 1);
            btnMaxMax.Name = "btnMaxMax";
            btnMaxMax.Size = new Size(56, 29);
            btnMaxMax.TabIndex = 5;
            btnMaxMax.UseVisualStyleBackColor = true;
            btnMaxMax.Visible = false;
            btnMaxMax.Click += btnMaxMax_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderColor = Color.White;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.controlMin_20px;
            btnMinimize.Location = new Point(1192, 1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(56, 29);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 4);
            logo.Name = "logo";
            logo.Size = new Size(25, 23);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(20, 120, 153);
            pnlNavBar.Controls.Add(pnlContratos);
            pnlNavBar.Controls.Add(pnlCasas);
            pnlNavBar.Controls.Add(pnlProp);
            pnlNavBar.Controls.Add(pnlInqui);
            pnlNavBar.Controls.Add(pnlHome);
            pnlNavBar.Controls.Add(pnlLogo);
            pnlNavBar.Dock = DockStyle.Left;
            pnlNavBar.Location = new Point(0, 30);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(261, 738);
            pnlNavBar.TabIndex = 3;
            // 
            // pnlContratos
            // 
            pnlContratos.Controls.Add(btnContratos);
            pnlContratos.Location = new Point(0, 315);
            pnlContratos.Name = "pnlContratos";
            pnlContratos.Size = new Size(261, 55);
            pnlContratos.TabIndex = 5;
            // 
            // btnContratos
            // 
            btnContratos.BackColor = Color.FromArgb(20, 120, 153);
            btnContratos.FlatAppearance.BorderSize = 0;
            btnContratos.FlatStyle = FlatStyle.Flat;
            btnContratos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContratos.ForeColor = SystemColors.ControlLightLight;
            btnContratos.Image = Properties.Resources.pngContract_35px;
            btnContratos.ImageAlign = ContentAlignment.MiddleLeft;
            btnContratos.Location = new Point(0, -3);
            btnContratos.Name = "btnContratos";
            btnContratos.Padding = new Padding(25, 0, 0, 0);
            btnContratos.Size = new Size(261, 55);
            btnContratos.TabIndex = 0;
            btnContratos.Text = "             Contratos";
            btnContratos.TextAlign = ContentAlignment.MiddleLeft;
            btnContratos.UseVisualStyleBackColor = false;
            btnContratos.Click += btnContratos_Click;
            // 
            // pnlCasas
            // 
            pnlCasas.Controls.Add(btnPropiedades);
            pnlCasas.Location = new Point(0, 258);
            pnlCasas.Name = "pnlCasas";
            pnlCasas.Size = new Size(261, 55);
            pnlCasas.TabIndex = 4;
            // 
            // btnPropiedades
            // 
            btnPropiedades.BackColor = Color.FromArgb(20, 120, 153);
            btnPropiedades.FlatAppearance.BorderSize = 0;
            btnPropiedades.FlatStyle = FlatStyle.Flat;
            btnPropiedades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPropiedades.ForeColor = SystemColors.ControlLightLight;
            btnPropiedades.Image = Properties.Resources.pngReside_35px;
            btnPropiedades.ImageAlign = ContentAlignment.MiddleLeft;
            btnPropiedades.Location = new Point(0, -3);
            btnPropiedades.Name = "btnPropiedades";
            btnPropiedades.Padding = new Padding(25, 0, 0, 0);
            btnPropiedades.Size = new Size(261, 55);
            btnPropiedades.TabIndex = 0;
            btnPropiedades.Text = "             Propiedades";
            btnPropiedades.TextAlign = ContentAlignment.MiddleLeft;
            btnPropiedades.UseVisualStyleBackColor = false;
            btnPropiedades.Click += btnPropiedades_Click;
            // 
            // pnlProp
            // 
            pnlProp.Controls.Add(btnPropietarios);
            pnlProp.Location = new Point(0, 201);
            pnlProp.Name = "pnlProp";
            pnlProp.Size = new Size(261, 55);
            pnlProp.TabIndex = 3;
            // 
            // btnPropietarios
            // 
            btnPropietarios.BackColor = Color.FromArgb(20, 120, 153);
            btnPropietarios.FlatAppearance.BorderSize = 0;
            btnPropietarios.FlatStyle = FlatStyle.Flat;
            btnPropietarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPropietarios.ForeColor = SystemColors.ControlLightLight;
            btnPropietarios.Image = Properties.Resources.pngProp_35px1;
            btnPropietarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnPropietarios.Location = new Point(0, -3);
            btnPropietarios.Name = "btnPropietarios";
            btnPropietarios.Padding = new Padding(25, 0, 0, 0);
            btnPropietarios.Size = new Size(261, 55);
            btnPropietarios.TabIndex = 0;
            btnPropietarios.Text = "             Propietarios";
            btnPropietarios.TextAlign = ContentAlignment.MiddleLeft;
            btnPropietarios.UseVisualStyleBackColor = false;
            btnPropietarios.Click += btnProp_Click;
            // 
            // pnlInqui
            // 
            pnlInqui.Controls.Add(btnInqui);
            pnlInqui.Location = new Point(0, 144);
            pnlInqui.Name = "pnlInqui";
            pnlInqui.Size = new Size(261, 55);
            pnlInqui.TabIndex = 2;
            // 
            // btnInqui
            // 
            btnInqui.BackColor = Color.FromArgb(20, 120, 153);
            btnInqui.FlatAppearance.BorderSize = 0;
            btnInqui.FlatStyle = FlatStyle.Flat;
            btnInqui.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInqui.ForeColor = SystemColors.ControlLightLight;
            btnInqui.Image = Properties.Resources.pngPeople_35px;
            btnInqui.ImageAlign = ContentAlignment.MiddleLeft;
            btnInqui.Location = new Point(0, -3);
            btnInqui.Name = "btnInqui";
            btnInqui.Padding = new Padding(25, 0, 0, 0);
            btnInqui.Size = new Size(261, 55);
            btnInqui.TabIndex = 0;
            btnInqui.Text = "             Inquilinos";
            btnInqui.TextAlign = ContentAlignment.MiddleLeft;
            btnInqui.UseVisualStyleBackColor = false;
            btnInqui.Click += btnInqui_Click;
            // 
            // pnlHome
            // 
            pnlHome.Controls.Add(btnHome);
            pnlHome.Location = new Point(0, 87);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(261, 55);
            pnlHome.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(20, 120, 153);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ControlLightLight;
            btnHome.Image = Properties.Resources.pnglist_35px;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, -3);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(25, 0, 0, 0);
            btnHome.Size = new Size(261, 55);
            btnHome.TabIndex = 0;
            btnHome.Text = "             Inicio";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(imgLogo);
            pnlLogo.Location = new Point(0, 1);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(261, 80);
            pnlLogo.TabIndex = 0;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.Tenant_logo_rw;
            imgLogo.Location = new Point(11, 13);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(239, 52);
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 768);
            Controls.Add(pnlNavBar);
            Controls.Add(pnlControlBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TenantHub";
            WindowState = FormWindowState.Maximized;
            pnlControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            pnlNavBar.ResumeLayout(false);
            pnlContratos.ResumeLayout(false);
            pnlCasas.ResumeLayout(false);
            pnlProp.ResumeLayout(false);
            pnlInqui.ResumeLayout(false);
            pnlHome.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlControlBox;
        private Panel pnlNavBar;
        private PictureBox logo;
        private Button btnMinimize;
        private Button btnCerrar;
        private Button btnMaxMax;
        private Button btnMaxNor;
        private Panel pnlLogo;
        private PictureBox imgLogo;
        private Panel pnlHome;
        private Button btnHome;
        private Button btnInqui;
        private Panel pnlInqui;
        private Panel pnlProp;
        private Button btnPropietarios;
        private Panel pnlCasas;
        private Button btnPropiedades;
        private Panel pnlContratos;
        private Button btnContratos;
    }
}