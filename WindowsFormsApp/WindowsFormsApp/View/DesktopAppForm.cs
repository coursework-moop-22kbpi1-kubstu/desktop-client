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

namespace WindowsFormsApp
{
    public partial class DesktopAppForm : Form
    {
        public View.View view;
        public DesktopAppForm()
        {
        }
        public void Init()
        {
            InitializeComponent();

            this.btnUserLogin.Click += new System.EventHandler(view.StartLogin);
            this.btnUserRegistration.Click += new System.EventHandler(view.StartRegistration);

            this.btn0peningRetistrationForm.Click += new System.EventHandler(view.OpenFormRegistration);
            this.btn0peningLoginForm.Click += new System.EventHandler(view.OpenFormLogin);

            //this.btnSetting.Click += new System.EventHandler(view.btnSetting_Click);
            //this.btnRegistrationUserReturnPnlUserLogin.Click += new System.EventHandler(view.button2_Click);

            this.inputEnteringUserLogin.TextChanged += new System.EventHandler(view.inputEnteringUserLogin_TextChanged);
            this.inputEnteringUserPassword.TextChanged += new System.EventHandler(view.inputEnteringUserPassword_TextChanged);
            this.inputRegistrationUserName.TextChanged += new System.EventHandler(view.inputRegistrationUserName_TextChanged);
            this.inputRegistrationUserLogin.TextChanged += new System.EventHandler(view.inputRegistrationUserLogin_TextChanged);
            this.inputRegistrationPassword1.TextChanged += new System.EventHandler(view.inputRegistrationPassword_TextChanged);
            this.inputRegistrationPassword2.TextChanged += new System.EventHandler(view.inputRegistrationPassword_TextChanged);
        }


        private void control_MouseEnterOrLeave(object sender, EventArgs e)
        {
            Color c = ((Control)sender).BackColor;
            ((Control)sender).BackColor = ((Control)sender).ForeColor;
            ((Control)sender).ForeColor = c;
        }

        #region property // свойства


        #endregion

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

        private void LineMainMenuLeftMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.None)
            {
                if (pnlMainMenuLeftMenu.Width + e.X < pnlMainMenuLeftMenu.Width - 90)
                {
                    pnlMainMenuLeftMenu.Width += e.X;
                }
                else
                {
                    pnlMainMenuLeftMenu.Width = pnlMainMenuLeftMenu.Width - 90;
                }
            }
        }

        #region textBoxEventMouseDown
        private void PlaceholderTextDelete_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is TextBox)
            {
                if (((TextBox)sender).ForeColor != Color.Black)
                {
                    ((TextBox)sender).ForeColor = Color.Black;
                    ((TextBox)sender).Text = string.Empty;
                }
            }
        }
        private void PlaceholderTextDeleteForPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is TextBox)
            {
                if (((TextBox)sender).ForeColor != Color.Black)
                {
                    ((TextBox)sender).ForeColor = Color.Black;
                    ((TextBox)sender).Text = string.Empty;
                    ((TextBox)sender).PasswordChar = '*';
                }
            }
        }
        #endregion

        #region Login & Registration _SizeChanged Event
        private void pnlUserLogin_SizeChanged(object sender, EventArgs e)
        {
            pnlUserLoginMiddleCenter.Location = new Point(
                (pnlUserLogin.Width - pnlUserLoginMiddleCenter.Width) >> 1,
                (pnlUserLogin.Height - pnlUserLoginMiddleCenter.Height) >> 1
                );
        }
        private void pnlRegistrationUser_SizeChanged(object sender, EventArgs e)
        {
            pnlUserRegistrationMiddleCenter.Location = new Point(
                (pnlUserRegistration.Width - pnlUserRegistrationMiddleCenter.Width) >> 1,
                (pnlUserRegistration.Height - pnlUserRegistrationMiddleCenter.Height) >> 1
                );
        }
        #endregion
    }
}
