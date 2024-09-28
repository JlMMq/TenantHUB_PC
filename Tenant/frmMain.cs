using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenant
{
    public partial class frmMain : Form
    {
        frmDashboard _frmDash;
        frmInquilinos _frmInqu;
        frmPropietarios _frmProt;
        frmPropiedades _frmProd;
        frmContratos _frmCont;

        private Point mouseOffset;
        private bool isMouseDown;

        int X = 0;
        int Y = 0;
        public frmMain()
        {
            InitializeComponent();
            mdiProp();
        }
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
            //Controls.OfType<MdiClient>().First().BackgroundImage = Tenant.Properties.Resources.back_city_lima;    
        }

        private void btnMaxNor_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxNor.Visible = false;
            btnMaxMax.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxMax.Visible = false;
            btnMaxNor.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (_frmDash == null)
            {
                _frmDash = new frmDashboard();
                _frmDash.FormClosed += frmDashboardClosingEvent;
                _frmDash.MdiParent = this;
                _frmDash.Show();
            }
            else
            {
                _frmDash.Activate();
            }

        }
        private void frmDashboardClosingEvent(object sender, FormClosedEventArgs e)
        {
            _frmDash = null;
        }

        private void btnInqui_Click(object sender, EventArgs e)
        {
            if (_frmInqu == null)
            {
                _frmInqu = new frmInquilinos();
                _frmInqu.MdiParent = this;
                _frmInqu.FormClosed += frmInquilinosClosingEvent;
                _frmInqu.Show();
            }
            else
            {
                _frmInqu.Activate();
            }
        }

        private void frmInquilinosClosingEvent(object sender, FormClosedEventArgs e)
        {
            _frmInqu = null;
        }

        private void btnProp_Click(object sender, EventArgs e)
        {
            if (_frmProt == null)
            {
                _frmProt = new frmPropietarios();
                _frmProt.MdiParent = this;
                _frmProt.FormClosed += frmPropietariosClosingEvent;
                _frmProt.Show();
            }
            else
            {
                _frmProt.Activate();
            }
        }
        private void frmPropietariosClosingEvent(object sender, FormClosedEventArgs e)
        {
            _frmProt = null;
        }

        private void btnPropiedades_Click(object sender, EventArgs e)
        {
            if (_frmProd == null)
            {
                _frmProd = new frmPropiedades();
                _frmProd.MdiParent = this;
                _frmProd.FormClosed += frmPropiedadesClosingEvent;
                _frmProd.Show();
            }
            else
            {
                _frmProd.Activate();
            }
        }

        private void frmPropiedadesClosingEvent(object sender, FormClosedEventArgs e)
        {
            _frmProd = null;
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            if (_frmCont == null)
            {
                _frmCont = new frmContratos();
                _frmCont.MdiParent = this;
                _frmCont.FormClosed += frmContratosClosingEvent;
                _frmCont.Show();
            }
            else
            {
                _frmCont.Activate();
            }
        }
        private void frmContratosClosingEvent(object sender, FormClosedEventArgs e)
        {
            _frmCont = null;
        }

        private void pnlControlBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMaxNor.Visible = false;
                btnMaxMax.Visible = true;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaxMax.Visible = false;
                btnMaxNor.Visible = true;
            }
        }

        private void pnlControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = e.Location;
                isMouseDown = true;
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    btnMaxNor.Visible = false;
                    btnMaxMax.Visible = true;
                    mouseOffset.X -= (Cursor.Position.X - this.Left);
                    mouseOffset.Y -= (Cursor.Position.Y - this.Top);
                }
            }
        }

        private void pnlControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                X = e.X;
                Y = e.Y;
            }
            else
            {
                Left = Left + (e.X - X);
                Top = Top + (e.Y - Y);
            }
        }
    }
}
