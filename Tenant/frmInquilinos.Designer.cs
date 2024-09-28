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
            pnlSubMenu = new Panel();
            pnlvline1 = new Panel();
            pnlInfo1 = new Panel();
            lblpnl2 = new Label();
            lblpnli1 = new Label();
            label1 = new Label();
            pnlPestaña = new Panel();
            imgSectionLogo = new PictureBox();
            lblTittle = new Label();
            pnlInfo2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pnlInfo3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pnlSearch = new Panel();
            textBox1 = new TextBox();
            label9 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dtgInquilinos = new DataGridView();
            tbBody = new TableLayoutPanel();
            pnlBody = new Panel();
            pnlSubMenu.SuspendLayout();
            pnlInfo1.SuspendLayout();
            pnlPestaña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgSectionLogo).BeginInit();
            pnlInfo2.SuspendLayout();
            pnlInfo3.SuspendLayout();
            pnlSearch.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInquilinos).BeginInit();
            tbBody.SuspendLayout();
            pnlBody.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSubMenu
            // 
            pnlSubMenu.BackColor = Color.FromArgb(240, 240, 240);
            pnlSubMenu.Controls.Add(pnlvline1);
            pnlSubMenu.Dock = DockStyle.Right;
            pnlSubMenu.Location = new Point(983, 0);
            pnlSubMenu.Name = "pnlSubMenu";
            pnlSubMenu.Size = new Size(361, 729);
            pnlSubMenu.TabIndex = 0;
            // 
            // pnlvline1
            // 
            pnlvline1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlvline1.BackColor = Color.LightGray;
            pnlvline1.Location = new Point(0, 0);
            pnlvline1.Name = "pnlvline1";
            pnlvline1.Size = new Size(1, 1100);
            pnlvline1.TabIndex = 2;
            // 
            // pnlInfo1
            // 
            pnlInfo1.BackColor = Color.FromArgb(242, 167, 27);
            pnlInfo1.Controls.Add(lblpnl2);
            pnlInfo1.Controls.Add(lblpnli1);
            pnlInfo1.Controls.Add(label1);
            pnlInfo1.Location = new Point(3, 3);
            pnlInfo1.MaximumSize = new Size(295, 110);
            pnlInfo1.MinimumSize = new Size(200, 100);
            pnlInfo1.Name = "pnlInfo1";
            pnlInfo1.Size = new Size(222, 110);
            pnlInfo1.TabIndex = 4;
            // 
            // lblpnl2
            // 
            lblpnl2.AutoSize = true;
            lblpnl2.BackColor = Color.Transparent;
            lblpnl2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpnl2.Location = new Point(13, 59);
            lblpnl2.Name = "lblpnl2";
            lblpnl2.Size = new Size(160, 21);
            lblpnl2.TabIndex = 2;
            lblpnl2.Text = "inquilinos registrados";
            // 
            // lblpnli1
            // 
            lblpnli1.AutoSize = true;
            lblpnli1.BackColor = Color.Transparent;
            lblpnli1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpnli1.Location = new Point(13, 14);
            lblpnli1.Name = "lblpnli1";
            lblpnli1.Size = new Size(44, 15);
            lblpnli1.TabIndex = 0;
            lblpnli1.Text = "Existen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(142, 50);
            label1.TabIndex = 1;
            label1.Text = "152438";
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
            pnlInfo2.Controls.Add(label2);
            pnlInfo2.Controls.Add(label3);
            pnlInfo2.Controls.Add(label4);
            pnlInfo2.Location = new Point(231, 3);
            pnlInfo2.MaximumSize = new Size(295, 110);
            pnlInfo2.MinimumSize = new Size(200, 100);
            pnlInfo2.Name = "pnlInfo2";
            pnlInfo2.Size = new Size(222, 110);
            pnlInfo2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 59);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 2;
            label2.Text = "inquilinos domesticos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 14);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "Existen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 18);
            label4.Name = "label4";
            label4.Size = new Size(121, 50);
            label4.TabIndex = 1;
            label4.Text = "15235";
            // 
            // pnlInfo3
            // 
            pnlInfo3.BackColor = Color.SkyBlue;
            pnlInfo3.Controls.Add(label5);
            pnlInfo3.Controls.Add(label6);
            pnlInfo3.Controls.Add(label7);
            pnlInfo3.Location = new Point(459, 3);
            pnlInfo3.MaximumSize = new Size(295, 110);
            pnlInfo3.MinimumSize = new Size(200, 100);
            pnlInfo3.Name = "pnlInfo3";
            pnlInfo3.Size = new Size(224, 110);
            pnlInfo3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 59);
            label5.Name = "label5";
            label5.Size = new Size(164, 21);
            label5.TabIndex = 2;
            label5.Text = "inquilinos comerciales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 14);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 0;
            label6.Text = "Existen";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 18);
            label7.Name = "label7";
            label7.Size = new Size(136, 50);
            label7.TabIndex = 1;
            label7.Text = "189312";
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearch.BackColor = Color.Silver;
            pnlSearch.Controls.Add(textBox1);
            pnlSearch.Controls.Add(label9);
            pnlSearch.Location = new Point(3, 5);
            pnlSearch.MaximumSize = new Size(885, 79);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(680, 79);
            pnlSearch.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(13, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(635, 26);
            textBox1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(11, 14);
            label9.Name = "label9";
            label9.Size = new Size(112, 17);
            label9.TabIndex = 0;
            label9.Text = "Busque inquilinos:";
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
            tableLayoutPanel1.Controls.Add(pnlInfo1, 0, 0);
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
            dtgInquilinos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgInquilinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInquilinos.Location = new Point(3, 213);
            dtgInquilinos.Name = "dtgInquilinos";
            dtgInquilinos.Size = new Size(680, 502);
            dtgInquilinos.TabIndex = 9;
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
            tbBody.Size = new Size(930, 730);
            tbBody.TabIndex = 10;
            // 
            // pnlBody
            // 
            pnlBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBody.BackColor = Color.WhiteSmoke;
            pnlBody.Controls.Add(pnlSearch);
            pnlBody.Controls.Add(dtgInquilinos);
            pnlBody.Controls.Add(tableLayoutPanel1);
            pnlBody.Location = new Point(122, 0);
            pnlBody.Margin = new Padding(7, 0, 7, 7);
            pnlBody.MaximumSize = new Size(885, 1500);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(686, 723);
            pnlBody.TabIndex = 0;
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
            pnlInfo1.ResumeLayout(false);
            pnlInfo1.PerformLayout();
            pnlPestaña.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgSectionLogo).EndInit();
            pnlInfo2.ResumeLayout(false);
            pnlInfo2.PerformLayout();
            pnlInfo3.ResumeLayout(false);
            pnlInfo3.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgInquilinos).EndInit();
            tbBody.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tbpMain;
        private Panel pnlTittle;
        private Label lblpnli1;
        private Panel pnlSubMenu;
        private Panel pnlvline1;
        private Panel pnlInfo1;
        private Label label1;
        private Panel pnlPestaña;
        private Label lblTittle;
        private PictureBox imgSectionLogo;
        private Label lblpnl2;
        private Panel pnlInfo2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel pnlInfo3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel pnlSearch;
        private Label label9;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dtgInquilinos;
        private TableLayoutPanel tbBody;
        private Panel pnlBody;
    }
}