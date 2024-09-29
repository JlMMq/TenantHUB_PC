using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenant
{
    public partial class frmInquilinos : Form
    {
        public frmInquilinos()
        {
            InitializeComponent();
        }

        private void frmInquilinos_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;

            var borderStyle = this.FormBorderStyle;
            this.FormBorderStyle = FormBorderStyle.None;
            this.FormBorderStyle = borderStyle;

            //this.lblpnlTotalInquilinos.Parent = this.imgpnl1;

        }

        private void lblTittle_Paint(object sender, PaintEventArgs e)
        {
            Font _font = new Font("Segoe UI", 20);
            Brush _brush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(0, 120);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Inquilinos", _font, _brush, 0, 0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //pnlAdd.Visible = true;
        }

        private void btnABack_Click(object sender, EventArgs e)
        {
            //pnlAdd.Visible = false;
        }

        //private void tbpMain_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    g.SmoothingMode = SmoothingMode.HighQuality;

        //    int radius = 20;

        //    using (GraphicsPath path = new GraphicsPath())
        //    {
        //        Rectangle rect = tbpMain.ClientRectangle;

        //        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Esquina superior izquierda
        //        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90); // Esquina superior derecha
        //        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); // Esquina inferior derecha
        //        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90); // Esquina inferior izquierda
        //        path.CloseFigure();

        //        tbpMain.Region = new Region(path);

        //        // Color y grosor del borde
        //        //using (Pen pen = new Pen(Color.AliceBlue , 2)) 
        //        //{
        //        //    g.DrawPath(pen, path);
        //        //}
        //    }
        //}
    }
}
