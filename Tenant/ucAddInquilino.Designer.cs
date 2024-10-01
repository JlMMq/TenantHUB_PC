namespace Tenant
{
    partial class ucAddInquilino
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnABack = new PictureBox();
            txtAddNombres = new TextBox();
            lblA3 = new Label();
            txtAddApellidos = new TextBox();
            lblA2 = new Label();
            lblA1 = new Label();
            lblAddTittle = new Label();
            lblA4 = new Label();
            cboTipoDoc = new ComboBox();
            lblA5 = new Label();
            txtNumDoc = new TextBox();
            lblA6 = new Label();
            txtTelefono = new TextBox();
            txtPreTelefono = new TextBox();
            lblA7 = new Label();
            txtDireccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cboTypeInquil = new ComboBox();
            lblA8 = new Label();
            imgFoto = new PictureBox();
            btnAddImage = new Button();
            btnDelImage = new Button();
            lblA9 = new Label();
            txtPdfDirectory = new TextBox();
            btnAddDoc = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)btnABack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFoto).BeginInit();
            SuspendLayout();
            // 
            // btnABack
            // 
            btnABack.BackgroundImageLayout = ImageLayout.None;
            btnABack.Cursor = Cursors.Hand;
            btnABack.Image = Properties.Resources.pngVolver_28px;
            btnABack.Location = new Point(24, 21);
            btnABack.Name = "btnABack";
            btnABack.Size = new Size(27, 27);
            btnABack.SizeMode = PictureBoxSizeMode.StretchImage;
            btnABack.TabIndex = 5;
            btnABack.TabStop = false;
            btnABack.Click += btnABack_Click;
            // 
            // txtAddNombres
            // 
            txtAddNombres.BorderStyle = BorderStyle.None;
            txtAddNombres.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddNombres.Location = new Point(31, 292);
            txtAddNombres.MaxLength = 60;
            txtAddNombres.Name = "txtAddNombres";
            txtAddNombres.Size = new Size(300, 26);
            txtAddNombres.TabIndex = 12;
            // 
            // lblA3
            // 
            lblA3.AutoSize = true;
            lblA3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA3.ForeColor = SystemColors.ControlDarkDark;
            lblA3.Location = new Point(29, 275);
            lblA3.Name = "lblA3";
            lblA3.Size = new Size(56, 13);
            lblA3.TabIndex = 11;
            lblA3.Text = "Nombres:";
            // 
            // txtAddApellidos
            // 
            txtAddApellidos.BorderStyle = BorderStyle.None;
            txtAddApellidos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddApellidos.Location = new Point(31, 240);
            txtAddApellidos.MaxLength = 60;
            txtAddApellidos.Name = "txtAddApellidos";
            txtAddApellidos.Size = new Size(300, 26);
            txtAddApellidos.TabIndex = 10;
            // 
            // lblA2
            // 
            lblA2.AutoSize = true;
            lblA2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA2.ForeColor = SystemColors.ControlDarkDark;
            lblA2.Location = new Point(29, 223);
            lblA2.Name = "lblA2";
            lblA2.Size = new Size(58, 13);
            lblA2.TabIndex = 9;
            lblA2.Text = "Apellidos:";
            // 
            // lblA1
            // 
            lblA1.AutoSize = true;
            lblA1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA1.ForeColor = SystemColors.ControlDarkDark;
            lblA1.Location = new Point(28, 196);
            lblA1.Name = "lblA1";
            lblA1.Size = new Size(123, 20);
            lblA1.TabIndex = 8;
            lblA1.Text = "Datos personales";
            // 
            // lblAddTittle
            // 
            lblAddTittle.AutoSize = true;
            lblAddTittle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddTittle.Location = new Point(22, 64);
            lblAddTittle.Name = "lblAddTittle";
            lblAddTittle.Size = new Size(207, 37);
            lblAddTittle.TabIndex = 7;
            lblAddTittle.Text = "Nuevo Inquilino";
            // 
            // lblA4
            // 
            lblA4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA4.ForeColor = SystemColors.ControlDarkDark;
            lblA4.Location = new Point(31, 334);
            lblA4.Name = "lblA4";
            lblA4.Size = new Size(73, 31);
            lblA4.TabIndex = 13;
            lblA4.Text = "Tipo de documento:";
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDoc.FlatStyle = FlatStyle.Flat;
            cboTipoDoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.Location = new Point(108, 337);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new Size(223, 29);
            cboTipoDoc.TabIndex = 14;
            cboTipoDoc.SelectedIndexChanged += cboTipoDoc_SelectedIndexChanged;
            // 
            // lblA5
            // 
            lblA5.AutoSize = true;
            lblA5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA5.ForeColor = SystemColors.ControlDarkDark;
            lblA5.Location = new Point(31, 380);
            lblA5.Name = "lblA5";
            lblA5.Size = new Size(95, 13);
            lblA5.TabIndex = 15;
            lblA5.Text = "Nro. Documento:";
            // 
            // txtNumDoc
            // 
            txtNumDoc.BorderStyle = BorderStyle.None;
            txtNumDoc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumDoc.Location = new Point(31, 396);
            txtNumDoc.MaxLength = 15;
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(300, 26);
            txtNumDoc.TabIndex = 16;
            txtNumDoc.KeyPress += txtNumDoc_KeyPress;
            // 
            // lblA6
            // 
            lblA6.AutoSize = true;
            lblA6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA6.ForeColor = SystemColors.ControlDarkDark;
            lblA6.Location = new Point(31, 431);
            lblA6.Name = "lblA6";
            lblA6.Size = new Size(120, 13);
            lblA6.TabIndex = 17;
            lblA6.Text = "Nro. Telefono/Celular:";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(83, 447);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(248, 26);
            txtTelefono.TabIndex = 18;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtPreTelefono
            // 
            txtPreTelefono.BorderStyle = BorderStyle.None;
            txtPreTelefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreTelefono.Location = new Point(31, 447);
            txtPreTelefono.MaxLength = 10;
            txtPreTelefono.Name = "txtPreTelefono";
            txtPreTelefono.PlaceholderText = "+00";
            txtPreTelefono.Size = new Size(48, 26);
            txtPreTelefono.TabIndex = 19;
            txtPreTelefono.KeyPress += txtPreTelefono_KeyPress;
            // 
            // lblA7
            // 
            lblA7.AutoSize = true;
            lblA7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA7.ForeColor = SystemColors.ControlDarkDark;
            lblA7.Location = new Point(31, 484);
            lblA7.Name = "lblA7";
            lblA7.Size = new Size(111, 13);
            lblA7.TabIndex = 20;
            lblA7.Text = "Dirección domiciliar:";
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(31, 500);
            txtDireccion.MaxLength = 200;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(300, 26);
            txtDireccion.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(28, 119);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 22;
            label1.Text = "Datos del sistema";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(31, 147);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 23;
            label2.Text = "Tipo de Inquilino:";
            // 
            // cboTypeInquil
            // 
            cboTypeInquil.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTypeInquil.FlatStyle = FlatStyle.Flat;
            cboTypeInquil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTypeInquil.FormattingEnabled = true;
            cboTypeInquil.ImeMode = ImeMode.NoControl;
            cboTypeInquil.Location = new Point(108, 148);
            cboTypeInquil.Name = "cboTypeInquil";
            cboTypeInquil.Size = new Size(223, 29);
            cboTypeInquil.TabIndex = 24;
            // 
            // lblA8
            // 
            lblA8.AutoSize = true;
            lblA8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA8.ForeColor = SystemColors.ControlDarkDark;
            lblA8.Location = new Point(31, 540);
            lblA8.Name = "lblA8";
            lblA8.Size = new Size(130, 13);
            lblA8.TabIndex = 25;
            lblA8.Text = "Agregar foto: (opcional)";
            // 
            // imgFoto
            // 
            imgFoto.BackColor = Color.FromArgb(249, 249, 249);
            imgFoto.BackgroundImage = Properties.Resources.pngImage2_100px;
            imgFoto.BackgroundImageLayout = ImageLayout.Center;
            imgFoto.Location = new Point(83, 565);
            imgFoto.Name = "imgFoto";
            imgFoto.Size = new Size(175, 200);
            imgFoto.SizeMode = PictureBoxSizeMode.CenterImage;
            imgFoto.TabIndex = 26;
            imgFoto.TabStop = false;
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = Color.Transparent;
            btnAddImage.Cursor = Cursors.Hand;
            btnAddImage.FlatAppearance.BorderSize = 0;
            btnAddImage.FlatStyle = FlatStyle.Flat;
            btnAddImage.Image = Properties.Resources.pngAgregar_35px;
            btnAddImage.Location = new Point(258, 566);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(32, 32);
            btnAddImage.TabIndex = 27;
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // btnDelImage
            // 
            btnDelImage.BackColor = Color.Transparent;
            btnDelImage.Cursor = Cursors.Hand;
            btnDelImage.FlatAppearance.BorderSize = 0;
            btnDelImage.FlatStyle = FlatStyle.Flat;
            btnDelImage.Image = Properties.Resources.pngCerrar_35px;
            btnDelImage.Location = new Point(258, 599);
            btnDelImage.Name = "btnDelImage";
            btnDelImage.Size = new Size(32, 32);
            btnDelImage.TabIndex = 28;
            btnDelImage.UseVisualStyleBackColor = false;
            btnDelImage.Click += btnDelImage_Click;
            // 
            // lblA9
            // 
            lblA9.AutoSize = true;
            lblA9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA9.ForeColor = SystemColors.ControlDarkDark;
            lblA9.Location = new Point(31, 777);
            lblA9.Name = "lblA9";
            lblA9.Size = new Size(220, 13);
            lblA9.TabIndex = 29;
            lblA9.Text = "Agregar documento identidad: (opcional)";
            // 
            // txtPdfDirectory
            // 
            txtPdfDirectory.BackColor = SystemColors.ControlLight;
            txtPdfDirectory.BorderStyle = BorderStyle.None;
            txtPdfDirectory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPdfDirectory.Location = new Point(31, 794);
            txtPdfDirectory.Name = "txtPdfDirectory";
            txtPdfDirectory.ReadOnly = true;
            txtPdfDirectory.Size = new Size(259, 26);
            txtPdfDirectory.TabIndex = 33;
            // 
            // btnAddDoc
            // 
            btnAddDoc.BackColor = Color.Transparent;
            btnAddDoc.Cursor = Cursors.Hand;
            btnAddDoc.FlatAppearance.BorderSize = 0;
            btnAddDoc.FlatStyle = FlatStyle.Flat;
            btnAddDoc.Image = Properties.Resources.pngPdf_25px;
            btnAddDoc.Location = new Point(294, 792);
            btnAddDoc.Name = "btnAddDoc";
            btnAddDoc.Size = new Size(25, 29);
            btnAddDoc.TabIndex = 34;
            btnAddDoc.UseVisualStyleBackColor = false;
            btnAddDoc.Click += btnAddDoc_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ControlLight;
            btnSave.Image = Properties.Resources.pngSave_20px;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(139, 888);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(5);
            btnSave.Size = new Size(98, 41);
            btnSave.TabIndex = 35;
            btnSave.Text = "     Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(64, 64, 64);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ControlLight;
            btnCancel.Image = Properties.Resources.pngSalir_20px;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(243, 888);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(5);
            btnCancel.Size = new Size(98, 41);
            btnCancel.TabIndex = 36;
            btnCancel.Text = "     Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ucAddInquilino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(240, 240, 240);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnAddDoc);
            Controls.Add(txtPdfDirectory);
            Controls.Add(lblA9);
            Controls.Add(btnDelImage);
            Controls.Add(btnAddImage);
            Controls.Add(imgFoto);
            Controls.Add(lblA8);
            Controls.Add(cboTypeInquil);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDireccion);
            Controls.Add(lblA7);
            Controls.Add(txtPreTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblA6);
            Controls.Add(txtNumDoc);
            Controls.Add(lblA5);
            Controls.Add(cboTipoDoc);
            Controls.Add(lblA4);
            Controls.Add(txtAddNombres);
            Controls.Add(lblA3);
            Controls.Add(txtAddApellidos);
            Controls.Add(lblA2);
            Controls.Add(lblA1);
            Controls.Add(lblAddTittle);
            Controls.Add(btnABack);
            Name = "ucAddInquilino";
            Size = new Size(360, 946);
            Load += ucAddInquilino_Load;
            ((System.ComponentModel.ISupportInitialize)btnABack).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnABack;
        private TextBox txtAddNombres;
        private Label lblA3;
        private TextBox txtAddApellidos;
        private Label lblA2;
        private Label lblA1;
        private Label lblAddTittle;
        private Label lblA4;
        private ComboBox cboTipoDoc;
        private Label lblA5;
        private TextBox txtNumDoc;
        private Label lblA6;
        private TextBox txtTelefono;
        private TextBox txtPreTelefono;
        private Label lblA7;
        private TextBox txtDireccion;
        private Label label1;
        private Label label2;
        private ComboBox cboTypeInquil;
        private Label lblA8;
        private PictureBox imgFoto;
        private Button btnAddImage;
        private Button btnDelImage;
        private Label lblA9;
        private Button button2;
        private TextBox txtPdfDirectory;
        private Button btnAddDoc;
        private Button btnSave;
        private Button btnCancel;
    }
}
