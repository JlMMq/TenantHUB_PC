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
    public partial class frmPropietarios : Form
    {
        public frmPropietarios()
        {
            InitializeComponent();
        }

        private void frmPropietarios_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;

            var borderStyle = this.FormBorderStyle;
            this.FormBorderStyle = FormBorderStyle.None;
            this.FormBorderStyle = borderStyle;
        }
    }
}
