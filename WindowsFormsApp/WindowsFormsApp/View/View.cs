using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Model.EventAndDelegate;
using WindowsFormsApp.ViewModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp.View
{
    public class View
    {
        private DesktopAppForm form;
        private ViewModel.ViewModel viewModel;
        private List<Chat> chats;

        public ViewModel.ViewModel ViewModel
        {
            get { return viewModel; }
            set { viewModel = value; }
        }
        public View(DesktopAppForm form)
        {
            this.form = form;
            chats = new List<Chat>();
        }
        public void ErrorMessage(string message) => MessageBox.Show(DateTime.Now.ToString() + "\n" + message);

        public void CloseForm()
        {
            form.Close();
        }

        #region свойства формы
        public Panel PnlUserLogin
        {
            get { return form.pnlUserLogin; }
            set { form.pnlUserLogin = value; }
        }
        public Panel PnlUserRegistration
        {
            get { return form.pnlUserRegistration; }
            set { form.pnlUserRegistration = value; }
        }
        public Panel PnlMainMenu
        {
            get { return form.pnlMainMenu; }
            set { form.pnlMainMenu = value; }
        }
        public Panel PnlChat
        {
            get { return form.panelChat; }
            set { form.panelChat = value; }
        }
        public Panel PnlListUser
        {
            get { return form.panelListUser; }
            set { form.panelListUser = value; }
        }
        public Panel PnlContent
        {
            get { return form.panelContent; }
            set { form.panelContent = value; }
        }
        public TextBox inputEnteringUserLogin
        {
            get { return form.inputEnteringUserLogin; }
            set { form.inputEnteringUserLogin = value; }
        }
        public TextBox inputEnteringUserPassword
        {
            get { return form.inputEnteringUserPassword; }
            set { form.inputEnteringUserPassword = value; }
        }
        #endregion

        #region Switching_____Form
        public void PnlContentClear()
        {
            foreach (Control elem in form.panelContent.Controls)
            {
                if (!elem.Equals(form.btnChangeSizeForm))
                {
                    form.panelContent.Controls.Remove(elem);
                }
            }
        }
        public void SwitchingLoginForm()
        {
            PnlContentClear();
            form.panelContent.Controls.Add(form.pnlUserLogin);
        }
        public void SwitchingRegistrationForm()
        {
            PnlContentClear();
            form.panelContent.Controls.Add(form.pnlUserRegistration);
        }
        public void SwitchingMainForm()
        {
            PnlContentClear();
            form.panelContent.Controls.Add(form.pnlMainMenu);
        }
        public void SwitchingSettingsForm()
        {
            PnlContentClear();
            form.panelContent.Controls.Add(form.pnlMainMenu);
        }
        #endregion

        #region btn_Click_event
        public void StartLogin(object sender, EventArgs e)
        {
            viewModel.LoginAsync();
        }
        public void StartRegistration(object sender, EventArgs e)
        {
            throw new Exception();
            viewModel.SignupAsync();
            form.panelContent.Controls.Remove(form.pnlUserRegistration);
            form.panelContent.Controls.Add(form.pnlUserLogin);
        }
        public void OpenFormLogin(object sender, EventArgs e)
        {
            SwitchingLoginForm();
        }
        public void OpenFormRegistration(object sender, EventArgs e)
        {
            SwitchingRegistrationForm();
        }
        #endregion

        #region input_TextChange_event
        public void inputEnteringUserLogin_TextChanged(object sender, EventArgs e)
        {
            viewModel.UserLogin = form.inputEnteringUserLogin.Text;
        }
        public void inputEnteringUserPassword_TextChanged(object sender, EventArgs e)
        {
            viewModel.UserPassword = form.inputEnteringUserPassword.Text;
        }
        public void inputRegistrationUserName_TextChanged(object sender, EventArgs e)
        {
            viewModel.UserName = form.inputRegistrationUserName.Text;
        }
        public void inputRegistrationUserLogin_TextChanged(object sender, EventArgs e)
        {
            viewModel.UserLogin = form.inputRegistrationUserLogin.Text;
        }
        public void inputRegistrationPassword_TextChanged(object sender, EventArgs e)
        {
            if (form.inputRegistrationPassword1.Text == form.inputRegistrationPassword2.Text)
            {
                form.labelRegistrationMessage.Visible = false;
                form.labelRegistrationMessage.Text = "--//--";
                viewModel.UserPassword = form.inputRegistrationPassword2.Text;
            }
            else
            {
                form.labelRegistrationMessage.Visible = true;
                form.labelRegistrationMessage.Text = "введеные пароли не совпадают";
            }
        }
        #endregion

        #region event of adding a user or notification
        public void EventNewNotification(object sender, EventNewNotificationData e)
        {
            //MessageBox.Show("EventNewNotification\n" + JsonConvert.SerializeObject(sender, Formatting.Indented));
        }
        public void EventNewUser(object sender, EventNewUserData e)
        {
            Chat chat = new Chat(this, viewModel, e.newUserChatInfo);
            chats.Add(chat);

            PnlChat.Invoke((MethodInvoker)delegate
            {
                PnlChat.Controls.Add(chat.pnlChat);
            });
            PnlListUser.Invoke((MethodInvoker)delegate
            {
                PnlListUser.Controls.Add(chat.panelUserList);
            });
        }
        #endregion
    }
}
