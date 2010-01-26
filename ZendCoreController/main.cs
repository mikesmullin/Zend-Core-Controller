using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;

namespace ZendCoreController
{
    public partial class main : Form
    {
        private ServiceController[] services;
        private ServiceController Apache;
        private ServiceController MySQL;

        public main()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.core_ico;
            notifyIcon.Icon = Properties.Resources.core_ico;

            // Poll services
            services = ServiceController.GetServices();            
          
            // Get Apache and MySQL handles
            foreach (ServiceController service in services) {
              switch (service.ServiceName.ToString()) {
                case "ZendCoreApache":
                  Apache = service;
                  break;

                case "MySQL":
                  MySQL = service;
                  break;
              }
            }

            refresh_status();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.txtStatus.Text = 
                "Zend Core Controller v1.0 (February 15, 2009)\r\n"+
                System.Environment.OSVersion.ToString() +"\r\n" +
                "Current Directory: "+ Application.StartupPath +"\r\n";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
          Environment.Exit(0);
        }

        private void toggle_service(ServiceController s)
        {
            try
            {
              if(s.CanStop)
              {
                s.Stop();
              }
              else
              {
                s.Start();
              }                 
            }
            catch(Exception er)
            {
              MessageBox.Show(er.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          refresh_status();
        }

        private void toggle_form(Form f)
        {
            if (f.Visible)
            {
                f.Hide();
            }
            else
            {
                f.Show();
            }            
        }

        private void refresh_status()
        {
          Apache.Refresh();
          if (Apache.Status.ToString() == "Running")
          {
            lblApacheStatus.Visible = true;
            btnApache.Text = "Stop";
          }
          else
          {
            lblApacheStatus.Visible = false;
            btnApache.Text = "Start";
          }

          MySQL.Refresh();
          if (MySQL.Status.ToString() == "Running")
          {
            lblMySQLStatus.Visible = true;
            btnMySQL.Text = "Stop";
          }
          else
          {
            lblMySQLStatus.Visible = false;
            btnMySQL.Text = "Start";
          }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            toggle_form(this);
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            toggle_form(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
          refresh_status();
        }

        private void btnApache_Click(object sender, EventArgs e)
        {
          toggle_service(Apache);
        }

        private void btnMySQL_Click(object sender, EventArgs e)
        {
          toggle_service(MySQL);
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
          refresh_status();
        }

        private void main_Resize(object sender, EventArgs e)
        {
          if (this.WindowState.ToString() == "Minimized")
          {
            this.Hide();
          }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
          this.Hide();
          e.Cancel = true;
        }
    }
}
