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
            pnlNavBar = new Panel();
            SuspendLayout();
            // 
            // pnlControlBox
            // 
            pnlControlBox.BackColor = Color.FromArgb(64, 64, 64);
            pnlControlBox.Dock = DockStyle.Top;
            pnlControlBox.Location = new Point(0, 0);
            pnlControlBox.Name = "pnlControlBox";
            pnlControlBox.Size = new Size(1920, 30);
            pnlControlBox.TabIndex = 1;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(20, 120, 153);
            pnlNavBar.Dock = DockStyle.Left;
            pnlNavBar.Location = new Point(0, 30);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(237, 1030);
            pnlNavBar.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1060);
            Controls.Add(pnlNavBar);
            Controls.Add(pnlControlBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TenantHub";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlControlBox;
        private Panel pnlNavBar;
    }
}