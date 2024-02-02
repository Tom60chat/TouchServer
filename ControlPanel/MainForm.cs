



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using ToucheServer.Server;

namespace ControlPanel
{
    public partial class MainForm : Form
    {

        private Process run;
        private bool running = false;

        Thread ServerThread;
        Thread EchoThread;

        public MainForm()
        {
            InitializeComponent();
        }

        
        private void OnStartFromContextMenu(object sender, EventArgs e)
        {

        }

        private void OnExpandFromContextMenu(object sender, EventArgs e)
        {

        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.ShowBalloonTip(1000, "TouchServer","TouchServer is Minimized to system tray ! Service is Running in Background.",ToolTipIcon.Info);
            }
        }

        private void OnExitFromContextMenu(object sender, EventArgs e)
        {

        }

        private void OnStopFromContextMenu(object sender, EventArgs e)
        {

        }

        private void OnShowFromContextMenu(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;

        }

        private void OnKeyboardFromContextMenu(object sender, EventArgs e)
        {

        }

        private void OnGamePadFromConextMenu(object sender, EventArgs e)
        {

        }

        private void StartServer(object sender, EventArgs e)
        {
            if (!running)
            {
                try
                {
                    ServerThread = new Thread(new ThreadStart(TsServer.ServerThread));
                    if (checkBoxEchoIP.Checked)
                        EchoThread = new Thread(new ThreadStart(TsServer.EchoThread));
                    else
                        EchoThread = new Thread(() => TsServer.EchoThreadA(new IPv4
                        {
                            s_b1 = Convert.ToByte(txtEchoIP1.Text),
                            s_b2 = Convert.ToByte(txtEchoIP2.Text),
                            s_b3 = Convert.ToByte(txtEchoIP3.Text),
                            s_b4 = Convert.ToByte(txtEchoIP4.Text)
                        }));

                    ServerThread.Start();
                    EchoThread.Start();

                    this.lblStatus.Text = "Server is Running";
                    running = true;

                }
                catch (Exception ex)
                {
                    this.lblStatus.Text = "Failed to Start:" + ex.ToString();
                }
            }
           
        }
        private void StopServer(object sender, EventArgs e)
        {
            if (running)
            {
                try
                {
                    ServerThread.Abort();
                    EchoThread.Abort();

                    this.lblStatus.Text = "Server is NOT Running";
                    running = false;

                }
                catch (Exception ex)
                {
                    this.lblStatus.Text = "Failed to Stop:" + ex.ToString();
                }
            }
           
        }


        private void notufyIconOnClick(object sender, MouseEventArgs e)
        {
           
        }

        private void OnExit(object sender, FormClosedEventArgs e)
        {
            if (running)
            {
                run.Kill();
            }
        }

        private void checkBoxEchoIP_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanelEchoIP.Enabled = !checkBoxEchoIP.Checked;
        }
    }
}
