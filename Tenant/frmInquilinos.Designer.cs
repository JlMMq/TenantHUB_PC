namespace Tenant
{
    partial class frmInquilinos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInquilinos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlSubMenu = new Panel();
            pnlvline1 = new Panel();
            btnEliminar = new Button();
            lblpnl1_2 = new Label();
            lblpnli1_1 = new Label();
            lblpnlTotalInquilinos = new Label();
            pnlbackInfo1 = new Panel();
            pnlPestaña = new Panel();
            imgSectionLogo = new PictureBox();
            lblTittle = new Label();
            pnlInfo2 = new Panel();
            lblpnl2_2 = new Label();
            lblpnl2_1 = new Label();
            lblpnlDomesticos = new Label();
            pnlInfo3 = new Panel();
            lblpnl3_2 = new Label();
            lblpnl3_1 = new Label();
            lblpnlComerciales = new Label();
            pnlSearch = new Panel();
            imgSearch = new PictureBox();
            textBox1 = new TextBox();
            label9 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dtgInquilinos = new DataGridView();
            int_codInq = new DataGridViewTextBoxColumn();
            str_nroDocmt = new DataGridViewTextBoxColumn();
            str_apenom = new DataGridViewTextBoxColumn();
            str_tipo = new DataGridViewTextBoxColumn();
            tbBody = new TableLayoutPanel();
            pnlBody = new Panel();
            pnlControl = new Panel();
            btnAgregar = new Button();
            pnlSubMenu.SuspendLayout();
            pnlbackInfo1.SuspendLayout();
            pnlPestaña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgSectionLogo).BeginInit();
            pnlInfo2.SuspendLayout();
            pnlInfo3.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgSearch).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInquilinos).BeginInit();
            tbBody.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlControl.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSubMenu
            // 
            pnlSubMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlSubMenu.BackColor = Color.FromArgb(240, 240, 240);
            pnlSubMenu.Controls.Add(pnlvline1);
            pnlSubMenu.Location = new Point(985, 0);
            pnlSubMenu.MaximumSize = new Size(400, 1080);
            pnlSubMenu.MinimumSize = new Size(360, 729);
            pnlSubMenu.Name = "pnlSubMenu";
            pnlSubMenu.Size = new Size(360, 730);
            pnlSubMenu.TabIndex = 0;
            // 
            // pnlvline1
            // 
            pnlvline1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlvline1.BackColor = Color.LightGray;
            pnlvline1.Location = new Point(0, 0);
            pnlvline1.Name = "pnlvline1";
            pnlvline1.Size = new Size(1, 1101);
            pnlvline1.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(224, 80, 44);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Image = Properties.Resources.pngBorrar_20px;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(410, 6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 33);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "    Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lblpnl1_2
            // 
            lblpnl1_2.AutoSize = true;
            lblpnl1_2.BackColor = Color.Transparent;
            lblpnl1_2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpnl1_2.Location = new Point(13, 59);
            lblpnl1_2.Name = "lblpnl1_2";
            lblpnl1_2.Size = new Size(160, 21);
            lblpnl1_2.TabIndex = 2;
            lblpnl1_2.Text = "inquilinos registrados";
            // 
            // lblpnli1_1
            // 
            lblpnli1_1.AutoSize = true;
            lblpnli1_1.BackColor = Color.Transparent;
            lblpnli1_1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpnli1_1.Location = new Point(13, 14);
            lblpnli1_1.Name = "lblpnli1_1";
            lblpnli1_1.Size = new Size(44, 15);
            lblpnli1_1.TabIndex = 0;
            lblpnli1_1.Text = "Existen";
            // 
            // lblpnlTotalInquilinos
            // 
            lblpnlTotalInquilinos.AutoSize = true;
            lblpnlTotalInquilinos.BackColor = Color.Transparent;
            lblpnlTotalInquilinos.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpnlTotalInquilinos.Location = new Point(3, 18);
            lblpnlTotalInquilinos.Name = "lblpnlTotalInquilinos";
            lblpnlTotalInquilinos.Size = new Size(163, 50);
            lblpnlTotalInquilinos.TabIndex = 1;
            lblpnlTotalInquilinos.Text = "1524385";
            // 
            // pnlbackInfo1
            // 
            pnlbackInfo1.BackColor = Color.FromArgb(242, 167, 27);
            pnlbackInfo1.BackgroundImage = (Image)resources.GetObject("pnlbackInfo1.BackgroundImage");
            pnlbackInfo1.BackgroundImageLayout = ImageLayout.Stretch;
            pnlbackInfo1.Controls.Add(lblpnl1_2);
            pnlbackInfo1.Controls.Add(lblpnli1_1);
            pnlbackInfo1.Controls.Add(lblpnlTotalInquilinos);
            pnlbackInfo1.Location = new Point(3, 3);
            pnlbackInfo1.MaximumSize = new Size(295, 110);
            pnlbackInfo1.MinimumSize = new Size(200, 100);
            pnlbackInfo1.Name = "pnlbackInfo1";
            pnlbackInfo1.Size = new Size(222, 110);
            pnlbackInfo1.TabIndex = 4;
            // 
            // pnlPestaña
            // 
            pnlPestaña.BackColor = Color.Black;
            pnlPestaña.Controls.Add(imgSectionLogo);
            pnlPestaña.Controls.Add(lblTittle);
            pnlPestaña.Location = new Point(0, 0);
            pnlPestaña.Name = "pnlPestaña";
            pnlPestaña.Size = new Size(45, 230);
            pnlPestaña.TabIndex = 6;
            // 
            // imgSectionLogo
            // 
            imgSectionLogo.Image = Properties.Resources.pngPeople_35px;
            imgSectionLogo.Location = new Point(10, 193);
            imgSectionLogo.Name = "imgSectionLogo";
            imgSectionLogo.Size = new Size(25, 25);
            imgSectionLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgSectionLogo.TabIndex = 8;
            imgSectionLogo.TabStop = false;
            // 
            // lblTittle
            // 
            lblTittle.BackColor = Color.Transparent;
            lblTittle.ForeColor = SystemColors.ControlLightLight;
            lblTittle.Location = new Point(3, 63);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(40, 120);
            lblTittle.TabIndex = 7;
            lblTittle.Paint += lblTittle_Paint;
            // 
            // pnlInfo2
            // 
            pnlInfo2.BackColor = Color.YellowGreen;
            pnlInfo2.BackgroundImage = Properties.Resources.pnlbckImgInquilino_2;
            pnlInfo2.Controls.Add(lblpnl2_2);
            pnlInfo2.Controls.Add(lblpnl2_1);
            pnlInfo2.Controls.Add(lblpnlDomesticos);
            pnlInfo2.Location = new Point(231, 3);
            pnlInfo2.MaximumSize = new Size(295, 110);
            pnlInfo2.MinimumSize = new Size(200, 100);
            pnlInfo2.Name = "pnlInfo2";
            pnlInfo2.Size = new Size(222, 110);
            pnlInfo2.TabIndex = 5;
            // 
            // lblpnl2_2
            // 
            lblpnl2_2.AutoSize = true;
            lblpnl2_2.BackColor = Color.Transparent;
            lblpnl2_2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpnl2_2.Location = new Point(13, 59);
            lblpnl2_2.Name = "lblpnl2_2";
            lblpnl2_2.Size = new Size(161, 21);
            lblpnl2_2.TabIndex = 2;
            lblpnl2_2.Text = "inquilinos domesticos";
            // 
            // lblpnl2_1
            // 
            lblpnl2_1.AutoSize = true;
            lblpnl2_1.BackColor = Color.Transparent;
            lblpnl2_1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpnl2_1.Location = new Point(13, 14);
            lblpnl2_1.Name = "lblpnl2_1";
            lblpnl2_1.Size = new Size(44, 15);
            lblpnl2_1.TabIndex = 0;
            lblpnl2_1.Text = "Existen";
            // 
            // lblpnlDomesticos
            // 
            lblpnlDomesticos.AutoSize = true;
            lblpnlDomesticos.BackColor = Color.Transparent;
            lblpnlDomesticos.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpnlDomesticos.Location = new Point(3, 18);
            lblpnlDomesticos.Name = "lblpnlDomesticos";
            lblpnlDomesticos.Size = new Size(121, 50);
            lblpnlDomesticos.TabIndex = 1;
            lblpnlDomesticos.Text = "15235";
            // 
            // pnlInfo3
            // 
            pnlInfo3.BackColor = Color.SkyBlue;
            pnlInfo3.BackgroundImage = Properties.Resources.pnlbckImgInquilino_3;
            pnlInfo3.Controls.Add(lblpnl3_2);
            pnlInfo3.Controls.Add(lblpnl3_1);
            pnlInfo3.Controls.Add(lblpnlComerciales);
            pnlInfo3.Location = new Point(459, 3);
            pnlInfo3.MaximumSize = new Size(295, 110);
            pnlInfo3.MinimumSize = new Size(200, 100);
            pnlInfo3.Name = "pnlInfo3";
            pnlInfo3.Size = new Size(224, 110);
            pnlInfo3.TabIndex = 6;
            // 
            // lblpnl3_2
            // 
            lblpnl3_2.AutoSize = true;
            lblpnl3_2.BackColor = Color.Transparent;
            lblpnl3_2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpnl3_2.Location = new Point(13, 59);
            lblpnl3_2.Name = "lblpnl3_2";
            lblpnl3_2.Size = new Size(164, 21);
            lblpnl3_2.TabIndex = 2;
            lblpnl3_2.Text = "inquilinos comerciales";
            // 
            // lblpnl3_1
            // 
            lblpnl3_1.AutoSize = true;
            lblpnl3_1.BackColor = Color.Transparent;
            lblpnl3_1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpnl3_1.Location = new Point(13, 14);
            lblpnl3_1.Name = "lblpnl3_1";
            lblpnl3_1.Size = new Size(44, 15);
            lblpnl3_1.TabIndex = 0;
            lblpnl3_1.Text = "Existen";
            // 
            // lblpnlComerciales
            // 
            lblpnlComerciales.AutoSize = true;
            lblpnlComerciales.BackColor = Color.Transparent;
            lblpnlComerciales.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpnlComerciales.Location = new Point(3, 18);
            lblpnlComerciales.Name = "lblpnlComerciales";
            lblpnlComerciales.Size = new Size(136, 50);
            lblpnlComerciales.TabIndex = 1;
            lblpnlComerciales.Text = "189312";
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearch.BackColor = Color.SlateGray;
            pnlSearch.Controls.Add(imgSearch);
            pnlSearch.Controls.Add(textBox1);
            pnlSearch.Controls.Add(label9);
            pnlSearch.Location = new Point(3, 5);
            pnlSearch.MaximumSize = new Size(885, 79);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(680, 79);
            pnlSearch.TabIndex = 5;
            // 
            // imgSearch
            // 
            imgSearch.BackColor = SystemColors.Window;
            imgSearch.BackgroundImageLayout = ImageLayout.Center;
            imgSearch.Image = Properties.Resources.pngLupa_100px;
            imgSearch.Location = new Point(642, 35);
            imgSearch.Name = "imgSearch";
            imgSearch.Size = new Size(26, 26);
            imgSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            imgSearch.TabIndex = 2;
            imgSearch.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(13, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(629, 26);
            textBox1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(11, 14);
            label9.Name = "label9";
            label9.Size = new Size(108, 17);
            label9.TabIndex = 0;
            label9.Text = "Buscar inquilinos:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(pnlInfo3, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlInfo2, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlbackInfo1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 87);
            tableLayoutPanel1.MaximumSize = new Size(890, 120);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(686, 120);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // dtgInquilinos
            // 
            dtgInquilinos.AllowUserToAddRows = false;
            dtgInquilinos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dtgInquilinos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgInquilinos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgInquilinos.BackgroundColor = SystemColors.Menu;
            dtgInquilinos.BorderStyle = BorderStyle.None;
            dtgInquilinos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(176, 190, 197);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.Padding = new Padding(7);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(176, 190, 197);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgInquilinos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgInquilinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInquilinos.Columns.AddRange(new DataGridViewColumn[] { int_codInq, str_nroDocmt, str_apenom, str_tipo });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtgInquilinos.DefaultCellStyle = dataGridViewCellStyle4;
            dtgInquilinos.EnableHeadersVisualStyles = false;
            dtgInquilinos.GridColor = Color.White;
            dtgInquilinos.Location = new Point(3, 250);
            dtgInquilinos.Name = "dtgInquilinos";
            dtgInquilinos.ReadOnly = true;
            dtgInquilinos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgInquilinos.RowHeadersVisible = false;
            dtgInquilinos.Size = new Size(680, 460);
            dtgInquilinos.TabIndex = 9;
            // 
            // int_codInq
            // 
            int_codInq.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Padding = new Padding(10);
            int_codInq.DefaultCellStyle = dataGridViewCellStyle3;
            int_codInq.HeaderText = "Codigo";
            int_codInq.Name = "int_codInq";
            int_codInq.ReadOnly = true;
            int_codInq.Width = 89;
            // 
            // str_nroDocmt
            // 
            str_nroDocmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            str_nroDocmt.HeaderText = "Nro. Documento";
            str_nroDocmt.Name = "str_nroDocmt";
            str_nroDocmt.ReadOnly = true;
            str_nroDocmt.Width = 143;
            // 
            // str_apenom
            // 
            str_apenom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            str_apenom.HeaderText = "Apellidos y nombres";
            str_apenom.Name = "str_apenom";
            str_apenom.ReadOnly = true;
            // 
            // str_tipo
            // 
            str_tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            str_tipo.HeaderText = "Tipo";
            str_tipo.Name = "str_tipo";
            str_tipo.ReadOnly = true;
            str_tipo.Width = 72;
            // 
            // tbBody
            // 
            tbBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbBody.ColumnCount = 3;
            tbBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbBody.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 700F));
            tbBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbBody.Controls.Add(pnlBody, 1, 0);
            tbBody.Location = new Point(47, 0);
            tbBody.Name = "tbBody";
            tbBody.RowCount = 1;
            tbBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbBody.Size = new Size(932, 730);
            tbBody.TabIndex = 10;
            // 
            // pnlBody
            // 
            pnlBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBody.BackColor = Color.WhiteSmoke;
            pnlBody.Controls.Add(pnlControl);
            pnlBody.Controls.Add(pnlSearch);
            pnlBody.Controls.Add(dtgInquilinos);
            pnlBody.Controls.Add(tableLayoutPanel1);
            pnlBody.Location = new Point(123, 0);
            pnlBody.Margin = new Padding(7, 0, 7, 7);
            pnlBody.MaximumSize = new Size(885, 1500);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(686, 723);
            pnlBody.TabIndex = 0;
            // 
            // pnlControl
            // 
            pnlControl.BackColor = SystemColors.Menu;
            pnlControl.Controls.Add(btnEliminar);
            pnlControl.Controls.Add(btnAgregar);
            pnlControl.Location = new Point(3, 206);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(680, 44);
            pnlControl.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Image = Properties.Resources.pngAdd_20px;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(516, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(161, 34);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "    Agregar inquilinos";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmInquilinos
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1344, 729);
            Controls.Add(tbBody);
            Controls.Add(pnlPestaña);
            Controls.Add(pnlSubMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInquilinos";
            Text = "Inquilinos";
            Load += frmInquilinos_Load;
            pnlSubMenu.ResumeLayout(false);
            pnlbackInfo1.ResumeLayout(false);
            pnlbackInfo1.PerformLayout();
            pnlPestaña.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgSectionLogo).EndInit();
            pnlInfo2.ResumeLayout(false);
            pnlInfo2.PerformLayout();
            pnlInfo3.ResumeLayout(false);
            pnlInfo3.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgSearch).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgInquilinos).EndInit();
            tbBody.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tbpMain;
        private Panel pnlTittle;
        private Label lblpnli1_1;
        private Panel pnlSubMenu;
        private Panel pnlvline1;
        private Panel pnlbackInfo1;
        private Label lblpnlTotalInquilinos;
        private Panel pnlPestaña;
        private Label lblTittle;
        private PictureBox imgSectionLogo;
        private Label lblpnl1_2;
        private Panel pnlInfo2;
        private Label lblpnl2_2;
        private Label lblpnl2_1;
        private Label lblpnlDomesticos;
        private Panel pnlInfo3;
        private Label lblpnl3_2;
        private Label lblpnl3_1;
        private Label lblpnlComerciales;
        private Panel pnlSearch;
        private Label label9;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dtgInquilinos;
        private TableLayoutPanel tbBody;
        private Panel pnlBody;
        private DataGridViewTextBoxColumn int_codInq;
        private DataGridViewTextBoxColumn str_nroDocmt;
        private DataGridViewTextBoxColumn str_apenom;
        private DataGridViewTextBoxColumn str_tipo;
        private PictureBox imgSearch;
        private Button btnEliminar;
        private Button btnAgregar;
        private Panel pnlControl;
    }
}