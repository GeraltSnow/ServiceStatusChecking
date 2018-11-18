using System;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

namespace ServiceStatusChecking
{
    public partial class Form1 : Form
    {
        static string serviceName = "BitLicenseServer_16";
        TimeSpan timeout = TimeSpan.FromMinutes(1);

        public Form1()
        {
            InitializeComponent();
        
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipText = "Запущено отслеживание статуса службы";
            notifyIcon1.ShowBalloonTip(3);

            Thread x = new Thread(CheckServiceStatus);
            x.IsBackground = true;
            x.Start();
        }

        private void RestartServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ServiceController service = new ServiceController(serviceName);
            
            if (service.Status != ServiceControllerStatus.Stopped)
            {                
                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);               
            }
            if (service.Status != ServiceControllerStatus.Running)
            {
                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                notifyIcon1.BalloonTipText = "Служба перезапущена";
                notifyIcon1.ShowBalloonTip(3);
            }
        }

        private void CloseProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ServiceStatusToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            if (ServiceStatusToolStripMenuItem.Text == "Статус: остановлена")
            {
                notifyIcon1.BalloonTipText = "Служба упала!";
                notifyIcon1.ShowBalloonTip(3);
            }
        }

        private void CheckServiceStatus()
        {
            while (true)
            {

                ServiceController service = new ServiceController(serviceName);

                string text = "";
                switch (service.Status)
                {
                    case ServiceControllerStatus.Stopped:
                        text = "Статус: остановлена";
                        break;
                    case ServiceControllerStatus.Running:
                        text = "Статус: работает";
                        break;
                }
                Thread.Sleep(1000);
                Invoke(new Action(() => ServiceStatusToolStripMenuItem.Text = text));
            }
        }
        
    }
}