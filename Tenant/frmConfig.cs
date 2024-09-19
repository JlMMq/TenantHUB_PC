using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tenant.conf;
using Tenant_BE;
using Tenant_BL;

namespace Tenant
{
    public partial class frmConfig : Form
    {
        jsconfig _config = new jsconfig();
        url_conf _urls = new url_conf();
        System_BL _system;
        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            CargarConfiguracion();
        }

        private void CargarConfiguracion()
        {
            _urls = _config.ReadConfig();
            txtUrlBacknd.Text = _urls.urlService.ToString();
            txtFiles.Text = _urls.urlFiles.ToString();
        }

        private async void btnCheckConnection_Click(object sender, EventArgs e)
        {
            string routeConnection = txtUrlBacknd.Text.Trim();
            _system = new System_BL(routeConnection);
            try
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(250);
                    lblResult.Invoke((MethodInvoker)delegate { lblResult.ForeColor = Color.Black; });
                    lblResult.Invoke((MethodInvoker)delegate { lblResult.Text = "Comprobando..."; });
                    lblResult.Invoke((MethodInvoker)delegate { lblResult.Visible = true; });
                    Thread.Sleep(250);

                    if (_system.RunningService(routeConnection))
                    {
                        Thread.Sleep(250);
                        lblResult.Invoke((MethodInvoker)delegate { lblResult.ForeColor = Color.Green; });
                        lblResult.Invoke((MethodInvoker)delegate { lblResult.Text = "Conexión exitosa con el WebService."; });
                    }
                    else
                    {
                        Thread.Sleep(250);
                        lblResult.Invoke((MethodInvoker)delegate { lblResult.ForeColor = Color.Red; });
                        lblResult.Invoke((MethodInvoker)delegate { lblResult.Text = "No se pudo establercer conexión con el WebService."; });
                    }
                    Thread.Sleep(250);
                });
            }catch (Exception ex)
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar los cambios?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flagCampos = false;
            if (txtUrlBacknd.Text.Trim() == String.Empty) flagCampos = true;
            if (txtFiles.Text.Trim() == String.Empty) flagCampos = true;

            if (!flagCampos) { 
                DialogResult result = MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    url_conf newurl_conf = new url_conf
                    {
                        urlService = txtUrlBacknd.Text.Trim(),
                        urlFiles = txtFiles.Text.Trim()    
                    };
                    _config.SaveConfig(newurl_conf);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
