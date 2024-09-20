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

        private void pnlNavBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
