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
            pnlCasas = new Panel();
            button1 = new Button();
            pnlProp = new Panel();
            btnProp = new Button();
            pnlInqui = new Panel();
            btnInqui = new Button();
            pnlHome = new Panel();
            btnHome = new Button();
            pnlLogo = new Panel();
            imgLogo = new PictureBox();
            pnlControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            pnlNavBar.SuspendLayout();
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
            pnlControlBox.Size = new Size(1920, 30);
            pnlControlBox.TabIndex = 1;
            // 
            // btnMaxNor
            // 
            btnMaxNor.FlatAppearance.BorderColor = Color.White;
            btnMaxNor.FlatAppearance.BorderSize = 0;
            btnMaxNor.FlatStyle = FlatStyle.Flat;
            btnMaxNor.Image = Properties.Resources.controlMaxNormal_20px;
            btnMaxNor.Location = new Point(1809, 1);
            btnMaxNor.Name = "btnMaxNor";
            btnMaxNor.Size = new Size(56, 29);
            btnMaxNor.TabIndex = 7;
            btnMaxNor.UseVisualStyleBackColor = true;
            btnMaxNor.Click += btnMaxNor_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderColor = Color.White;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = Properties.Resources.controlCerrar_15px;
            btnCerrar.Location = new Point(1864, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(56, 29);
            btnCerrar.TabIndex = 6;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMaxMax
            // 
            btnMaxMax.FlatAppearance.BorderColor = Color.White;
            btnMaxMax.FlatAppearance.BorderSize = 0;
            btnMaxMax.FlatStyle = FlatStyle.Flat;
            btnMaxMax.Image = Properties.Resources.controlMaxMax_20px;
            btnMaxMax.Location = new Point(1808, 1);
            btnMaxMax.Name = "btnMaxMax";
            btnMaxMax.Size = new Size(56, 29);
            btnMaxMax.TabIndex = 5;
            btnMaxMax.UseVisualStyleBackColor = true;
            btnMaxMax.Visible = false;
            btnMaxMax.Click += btnMaxMax_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderColor = Color.White;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.controlMin_20px;
            btnMinimize.Location = new Point(1752, 1);
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
            pnlNavBar.Controls.Add(pnlCasas);
            pnlNavBar.Controls.Add(pnlProp);
            pnlNavBar.Controls.Add(pnlInqui);
            pnlNavBar.Controls.Add(pnlHome);
            pnlNavBar.Controls.Add(pnlLogo);
            pnlNavBar.Dock = DockStyle.Left;
            pnlNavBar.Location = new Point(0, 30);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(261, 1002);
            pnlNavBar.TabIndex = 3;
            // 
            // pnlCasas
            // 
            pnlCasas.Controls.Add(button1);
            pnlCasas.Location = new Point(0, 228);
            pnlCasas.Name = "pnlCasas";
            pnlCasas.Size = new Size(261, 45);
            pnlCasas.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 120, 153);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = Properties.Resources.pngReside_35px;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, -3);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(261, 45);
            button1.TabIndex = 0;
            button1.Text = "             Propiedades";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // pnlProp
            // 
            pnlProp.Controls.Add(btnProp);
            pnlProp.Location = new Point(0, 181);
            pnlProp.Name = "pnlProp";
            pnlProp.Size = new Size(261, 45);
            pnlProp.TabIndex = 3;
            // 
            // btnProp
            // 
            btnProp.BackColor = Color.FromArgb(20, 120, 153);
            btnProp.FlatAppearance.BorderSize = 0;
            btnProp.FlatStyle = FlatStyle.Flat;
            btnProp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProp.ForeColor = SystemColors.ControlLightLight;
            btnProp.Image = Properties.Resources.pngProp_35px1;
            btnProp.ImageAlign = ContentAlignment.MiddleLeft;
            btnProp.Location = new Point(0, -3);
            btnProp.Name = "btnProp";
            btnProp.Padding = new Padding(25, 0, 0, 0);
            btnProp.Size = new Size(261, 45);
            btnProp.TabIndex = 0;
            btnProp.Text = "             Propietarios";
            btnProp.TextAlign = ContentAlignment.MiddleLeft;
            btnProp.UseVisualStyleBackColor = false;
            // 
            // pnlInqui
            // 
            pnlInqui.Controls.Add(btnInqui);
            pnlInqui.Location = new Point(0, 133);
            pnlInqui.Name = "pnlInqui";
            pnlInqui.Size = new Size(261, 45);
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
            btnInqui.Size = new Size(261, 45);
            btnInqui.TabIndex = 0;
            btnInqui.Text = "             Inquilinos";
            btnInqui.TextAlign = ContentAlignment.MiddleLeft;
            btnInqui.UseVisualStyleBackColor = false;
            // 
            // pnlHome
            // 
            pnlHome.Controls.Add(btnHome);
            pnlHome.Location = new Point(0, 87);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(261, 45);
            pnlHome.TabIndex = 1;
            pnlHome.Paint += pnlHome_Paint;
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
            btnHome.Size = new Size(261, 45);
            btnHome.TabIndex = 0;
            btnHome.Text = "             Inicio";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
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
            ClientSize = new Size(1920, 1032);
            Controls.Add(pnlNavBar);
            Controls.Add(pnlControlBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TenantHub";
            pnlControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            pnlNavBar.ResumeLayout(false);
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
        private Button btnProp;
        private Panel pnlCasas;
        private Button button1;
    }
}