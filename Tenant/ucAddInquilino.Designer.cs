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
            label1 = new Label();
            txtNumDoc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)btnABack).BeginInit();
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
            // 
            // txtAddNombres
            // 
            txtAddNombres.BorderStyle = BorderStyle.None;
            txtAddNombres.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddNombres.Location = new Point(31, 210);
            txtAddNombres.Name = "txtAddNombres";
            txtAddNombres.Size = new Size(300, 26);
            txtAddNombres.TabIndex = 12;
            // 
            // lblA3
            // 
            lblA3.AutoSize = true;
            lblA3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA3.ForeColor = SystemColors.ControlDarkDark;
            lblA3.Location = new Point(29, 193);
            lblA3.Name = "lblA3";
            lblA3.Size = new Size(56, 13);
            lblA3.TabIndex = 11;
            lblA3.Text = "Nombres:";
            // 
            // txtAddApellidos
            // 
            txtAddApellidos.BorderStyle = BorderStyle.None;
            txtAddApellidos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddApellidos.Location = new Point(31, 158);
            txtAddApellidos.Name = "txtAddApellidos";
            txtAddApellidos.Size = new Size(300, 26);
            txtAddApellidos.TabIndex = 10;
            // 
            // lblA2
            // 
            lblA2.AutoSize = true;
            lblA2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA2.ForeColor = SystemColors.ControlDarkDark;
            lblA2.Location = new Point(29, 141);
            lblA2.Name = "lblA2";
            lblA2.Size = new Size(58, 13);
            lblA2.TabIndex = 9;
            lblA2.Text = "Apellidos:";
            // 
            // lblA1
            // 
            lblA1.AutoSize = true;
            lblA1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA1.ForeColor = SystemColors.ControlDarkDark;
            lblA1.Location = new Point(28, 114);
            lblA1.Name = "lblA1";
            lblA1.Size = new Size(113, 17);
            lblA1.TabIndex = 8;
            lblA1.Text = "Datos personales:";
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
            lblA4.Location = new Point(31, 252);
            lblA4.Name = "lblA4";
            lblA4.Size = new Size(73, 31);
            lblA4.TabIndex = 13;
            lblA4.Text = "Tipo de documento:";
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.FlatStyle = FlatStyle.Flat;
            cboTipoDoc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.Location = new Point(108, 250);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new Size(223, 33);
            cboTipoDoc.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(31, 298);
            label1.Name = "label1";
            label1.Size = new Size(95, 13);
            label1.TabIndex = 15;
            label1.Text = "Nro. Documento:";
            // 
            // txtNumDoc
            // 
            txtNumDoc.BorderStyle = BorderStyle.None;
            txtNumDoc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumDoc.Location = new Point(31, 314);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(300, 26);
            txtNumDoc.TabIndex = 16;
            // 
            // ucAddInquilino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            Controls.Add(txtNumDoc);
            Controls.Add(label1);
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
            Size = new Size(360, 798);
            Load += ucAddInquilino_Load;
            ((System.ComponentModel.ISupportInitialize)btnABack).EndInit();
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
        private Label label1;
        private TextBox txtNumDoc;
    }
}
