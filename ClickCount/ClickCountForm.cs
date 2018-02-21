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
            ClickCount.ShowBalloonTip(2000, "Atenção", "APP ativo!", ToolTipIcon.Info);
            MouseHook.Start();
            MouseHook.MouseAction += new EventHandler(Event);
        }

        int clicks = 0;
        private void Event(object sender, EventArgs e)
        {
            clicks++;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            //this.Show();
            //this.WindowState = FormWindowState.Normal;            
            ClickCount.ContextMenuStrip = options;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    this.Hide();
            //}
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClickCount_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void ClickCount_MouseMove(object sender, MouseEventArgs e)
        {
            //ClickCount.Visible = true;
            //ClickCount.ShowBalloonTip(20000, "Total Clicks", clicks.ToString(), ToolTipIcon.Info);
        }

        private void ClickCount_Click(object sender, EventArgs e)
        {
            ClickCount.Visible = true;
            ClickCount.ShowBalloonTip(20000, "Total Clicks", clicks.ToString(), ToolTipIcon.Info);
        }
    }
}
