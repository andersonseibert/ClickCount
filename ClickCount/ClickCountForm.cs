using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCount
{
    public partial class ClickCountForm : Form
    {
        public ClickCountForm()
        {
            InitializeComponent();            
            //label1.Text = "Total Clicks ->" + clicks;
            MouseHook.Start();
            MouseHook.MouseAction += new EventHandler(Event);
        }

        int clicks = 0;
        private void Event(object sender, EventArgs e)
        {
            //Console.WriteLine("Left mouse click!");
            clicks++;
            //label1.Text = "Total Clicks ->" + clicks;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            //this.Show();
            //this.WindowState = FormWindowState.Normal;

            ClickCount.Visible = true;
            ClickCount.ShowBalloonTip(20000, "Total Clicks", clicks.ToString(), ToolTipIcon.Info);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    this.Hide();
            //}
        }
    }
}
