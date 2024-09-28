using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tenant.conf;
using Tenant_BE;
using Tenant_BL;



namespace Tenant
{
    public partial class frmLoad : Form
    {
        jsconfig _jsfile = new jsconfig();
        url_conf urls = new url_conf();
        System_BL _system;

        frmConfig _frmConfig;
        frmMain _frmMain;
        frmDashboard _frmDash;

        public frmLoad()
        {
            InitializeComponent();
        }

        private void frmLoad_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                Thread.Sleep(250);
                lblState1.Invoke((MethodInvoker)delegate { lblState1.Text = "Cargando configuracion..."; });
                urls = _jsfile.ReadConfig();

                Thread.Sleep(250);
                lblState1.Invoke((MethodInvoker)delegate { lblState1.Text = "Configuracion cargada..."; });

                Thread.Sleep(250);

                ConnectService(urls.urlService);

            });



        }

        public void ConnectService(string url)
        {
            lblState1.Invoke((MethodInvoker)delegate { lblState1.Text = "Conectando al servicio web..."; });
            //lblState2.Invoke((MethodInvoker)delegate { lblState2.Visible = false; });
            url = _jsfile.ReadConfig().urlService;
            _system = new System_BL(url);

            Thread.Sleep(1000);

            if (url == null)
            {
                lblState1.Invoke((MethodInvoker)delegate { lblState1.Text = "Reintentando conexion"; });
                lblState2.Invoke((MethodInvoker)delegate
                {
                    lblState2.Visible = true;
                    lblState2.Text = "URL de servicio web no valida.";
                    lblState2.ForeColor = Color.Red;
                });
                linkConfig.Invoke((MethodInvoker)delegate { linkConfig.Visible = true; });
                ReconnectAnimat();
                ConnectService(url);

            }
            if (url == "0")
            {
                lblState1.Invoke((MethodInvoker)delegate { lblState1.Text = "Reintentando conexion"; });
                lblState2.Invoke((MethodInvoker)delegate
                {
                    lblState2.Visible = true;
                    lblState2.Text = "La URL del servicio web no se encuentra configurada.";
                    lblState2.ForeColor = Color.Red;
                });
                linkConfig.Invoke((MethodInvoker)delegate { linkConfig.Visible = true; });
                ReconnectAnimat();
                ConnectService(url);
            }

            if (_system.RunningService(url))
            {

                Invoke(new Action(() =>
                {
                    _frmMain = new frmMain();
                    _frmMain.Show();
                    _frmDash = new frmDashboard();
                    _frmDash.MdiParent = _frmMain;
                    _frmDash.Show();
                    
                    _frmMain.FormClosed += EndApplication;
                    this.Hide();
                }));
            }
            else
            {
                lblState1.Invoke((MethodInvoker)delegate { lblState1.Text = "Reintentando conexion"; });
                lblState2.Invoke((MethodInvoker)delegate
                {
                    lblState2.Visible = true;
                    lblState2.Text = "No se pudo establecer conexion con el servicio web.";
                    lblState2.ForeColor = Color.Red;
                });
                linkConfig.Invoke((MethodInvoker)delegate { linkConfig.Visible = true; });
                ReconnectAnimat();
                ConnectService(url);
            }
        }

        private void EndApplication(object sender , FormClosedEventArgs e)
        {
            this.Close();
        }

        public void ReconnectAnimat()
        {
            Thread.Sleep(1000);
            lblState1.Invoke((MethodInvoker)delegate { lblState1.Text = "Reintentando conexion."; });
            Thread.Sleep(1000);
            lblState1.Invoke((MethodInvoker)delegate { lblState1.Text = "Reintentando conexion.."; });
            Thread.Sleep(1000);
            lblState1.Invoke((MethodInvoker)delegate { lblState1.Text = "Reintentando conexion..."; });
            Thread.Sleep(1000);
        }

        private void frmLoad_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void linkConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frmConfig = new frmConfig();
            _frmConfig.ShowDialog();
        }
    }
}
