using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApp
{
    public partial class DesktopAppForm : Form
    {
        public ViewModel viewModel;
        public DesktopAppForm()
        {
            InitializeComponent();
        }
        private void control_MouseEnterOrLeave(object sender, EventArgs e)
        {
            Color c = ((Control)sender).BackColor;
            ((Control)sender).BackColor = ((Control)sender).ForeColor;
            ((Control)sender).ForeColor = c;
        }

        #region Win Btn
        int maxSizeFormW = 1400;
        int maxSizeFormH = 700;
        private void pnlWinUpMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                return;
            }
            MenuUpWin.Capture = false;
            Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref message);
        }
        private void btnSizeMinForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnSizeNormOrMaxForm_Click(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                if (((Label)sender).Text == "🗖")
                {
                    this.MaximumSize = new Size(0, 0);
                    this.WindowState = FormWindowState.Maximized;
                    ((Label)sender).Text = "🗗";
                }
                else
                {
                    this.MaximumSize = new Size(maxSizeFormW, maxSizeFormH);
                    this.Size = this.MinimumSize;
                    this.WindowState = FormWindowState.Minimized;
                    this.WindowState = FormWindowState.Normal;
                    ((Label)sender).Text = "🗖";
                }
            }
        }
        private void btnClosForm_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        #endregion

        #region Change Size Form 
        int _LocXForm;
        int _LocYForm;
        private void btnChangeSizeForm_MouseDown(object sender, MouseEventArgs e)
        {
            _LocXForm = e.Location.X;
            _LocYForm = e.Location.Y;
        }
        private void btnChangeSizeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.None)
            {
                Width += e.Location.X - _LocXForm;
                Height += e.Location.Y - _LocYForm;
            }
        }
        #endregion

        private void pnlUserLogin_SizeChanged(object sender, EventArgs e)
        {
            pnlUserLoginMiddleCenter.Location = new Point(
                (pnlUserLogin.Width - pnlUserLoginMiddleCenter.Width) >> 1,
                (pnlUserLogin.Height - pnlUserLoginMiddleCenter.Height) >> 1
                );
        }
    }
}
