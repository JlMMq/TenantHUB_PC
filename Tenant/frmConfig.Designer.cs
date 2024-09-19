namespace Tenant
{
    partial class frmConfig
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            pnlTittle = new Panel();
            lblTittle = new Label();
            imgTittle = new PictureBox();
            gbService = new GroupBox();
            btnCheckConnection = new Button();
            txtUrlBacknd = new TextBox();
            label1 = new Label();
            gbUrls = new GroupBox();
            txtFiles = new TextBox();
            label2 = new Label();
            toolTipConnection = new ToolTip(components);
            lblResult = new Label();
            btnSave = new Button();
            btnExit = new Button();
            pnlTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgTittle).BeginInit();
            gbService.SuspendLayout();
            gbUrls.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTittle
            // 
            pnlTittle.BackColor = SystemColors.WindowFrame;
            pnlTittle.Controls.Add(lblTittle);
            pnlTittle.Controls.Add(imgTittle);
            pnlTittle.Dock = DockStyle.Top;
            pnlTittle.Location = new Point(0, 0);
            pnlTittle.Name = "pnlTittle";
            pnlTittle.Size = new Size(584, 60);
            pnlTittle.TabIndex = 0;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.ControlLightLight;
            lblTittle.Location = new Point(62, 11);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(184, 37);
            lblTittle.TabIndex = 1;
            lblTittle.Text = "Configuración";
            // 
            // imgTittle
            // 
            imgTittle.Image = Properties.Resources.pngConfig_35px;
            imgTittle.Location = new Point(22, 14);
            imgTittle.Name = "imgTittle";
            imgTittle.Size = new Size(35, 35);
            imgTittle.TabIndex = 0;
            imgTittle.TabStop = false;
            // 
            // gbService
            // 
            gbService.Controls.Add(btnCheckConnection);
            gbService.Controls.Add(txtUrlBacknd);
            gbService.Controls.Add(label1);
            gbService.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbService.Location = new Point(22, 66);
            gbService.Name = "gbService";
            gbService.Size = new Size(537, 64);
            gbService.TabIndex = 1;
            gbService.TabStop = false;
            gbService.Text = "WEB Service ";
            // 
            // btnCheckConnection
            // 
            btnCheckConnection.BackColor = Color.Transparent;
            btnCheckConnection.BackgroundImage = Properties.Resources.pngConnect_20px;
            btnCheckConnection.BackgroundImageLayout = ImageLayout.Center;
            btnCheckConnection.Cursor = Cursors.Hand;
            btnCheckConnection.FlatAppearance.BorderSize = 0;
            btnCheckConnection.FlatStyle = FlatStyle.Flat;
            btnCheckConnection.Location = new Point(488, 27);
            btnCheckConnection.Name = "btnCheckConnection";
            btnCheckConnection.Size = new Size(29, 27);
            btnCheckConnection.TabIndex = 2;
            toolTipConnection.SetToolTip(btnCheckConnection, "Comprobar conexión");
            btnCheckConnection.UseVisualStyleBackColor = false;
            btnCheckConnection.Click += btnCheckConnection_Click;
            // 
            // txtUrlBacknd
            // 
            txtUrlBacknd.BorderStyle = BorderStyle.FixedSingle;
            txtUrlBacknd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUrlBacknd.Location = new Point(126, 29);
            txtUrlBacknd.Name = "txtUrlBacknd";
            txtUrlBacknd.Size = new Size(356, 23);
            txtUrlBacknd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Dirección URL:";
            // 
            // gbUrls
            // 
            gbUrls.Controls.Add(txtFiles);
            gbUrls.Controls.Add(label2);
            gbUrls.Location = new Point(22, 136);
            gbUrls.Name = "gbUrls";
            gbUrls.Size = new Size(537, 71);
            gbUrls.TabIndex = 2;
            gbUrls.TabStop = false;
            gbUrls.Text = "Archivos";
            // 
            // txtFiles
            // 
            txtFiles.BorderStyle = BorderStyle.FixedSingle;
            txtFiles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiles.Location = new Point(126, 28);
            txtFiles.Name = "txtFiles";
            txtFiles.Size = new Size(356, 23);
            txtFiles.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(23, 24);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 0;
            label2.Text = "Ruta de archivo descarga:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(22, 224);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(51, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "Mensaje";
            lblResult.Visible = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLightLight;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.pngVerificarC_30px;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(346, 224);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(3, 0, 0, 0);
            btnSave.Size = new Size(102, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "      Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlLightLight;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Image = Properties.Resources.pngEliminarC_25px;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(454, 224);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(5, 0, 0, 0);
            btnExit.Size = new Size(105, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "   Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 274);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(lblResult);
            Controls.Add(gbUrls);
            Controls.Add(gbService);
            Controls.Add(pnlTittle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuración";
            Load += frmConfig_Load;
            pnlTittle.ResumeLayout(false);
            pnlTittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgTittle).EndInit();
            gbService.ResumeLayout(false);
            gbService.PerformLayout();
            gbUrls.ResumeLayout(false);
            gbUrls.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTittle;
        private Label lblTittle;
        private PictureBox imgTittle;
        private GroupBox gbService;
        private TextBox txtUrlBacknd;
        private Label label1;
        private GroupBox gbUrls;
        private TextBox txtFiles;
        private Label label2;
        private Button btnCheckConnection;
        private ToolTip toolTipConnection;
        private Label lblResult;
        private Button btnSave;
        private Button btnExit;
    }
}