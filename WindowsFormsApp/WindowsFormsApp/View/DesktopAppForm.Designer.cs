using System.Windows.Forms;

namespace WindowsFormsApp
{

    partial class DesktopAppForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopAppForm));
            this.MenuUpWin = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Label();
            this.btnSizeMinForm = new System.Windows.Forms.Label();
            this.btnSizeNormOrMaxForm = new System.Windows.Forms.Label();
            this.btnClosForm = new System.Windows.Forms.Label();
            this.LineUpMenuWin = new System.Windows.Forms.Panel();
            this.LineRight = new System.Windows.Forms.Panel();
            this.LineDown = new System.Windows.Forms.Panel();
            this.MenuUp = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnChangeSizeForm = new System.Windows.Forms.Label();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pnlMainMenuMessege = new System.Windows.Forms.Panel();
            this.panelChat = new System.Windows.Forms.Panel();
            this.pnlMainMenuMassegeInputText = new System.Windows.Forms.Panel();
            this.inputMassegeText = new System.Windows.Forms.TextBox();
            this.btnSendingMessage = new System.Windows.Forms.Button();
            this.LineMainMenuInputMassegeText = new System.Windows.Forms.Panel();
            this.pnlMainMenuLeftMenu = new System.Windows.Forms.Panel();
            this.panelListUser = new System.Windows.Forms.Panel();
            this.pnlMainMenuLeftMenuSearchUser = new System.Windows.Forms.Panel();
            this.labelSerchLoginOrID = new System.Windows.Forms.Label();
            this.inputSerchLoginOrID = new System.Windows.Forms.TextBox();
            this.LineSearchUser = new System.Windows.Forms.Panel();
            this.LineMainMenuLeftMenu = new System.Windows.Forms.Panel();
            this.pnlUserLogin = new System.Windows.Forms.Panel();
            this.labelEnteringStatusCode = new System.Windows.Forms.Label();
            this.pnlUserLoginMiddleCenter = new System.Windows.Forms.Panel();
            this.btn0peningRetistrationForm = new System.Windows.Forms.Button();
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.LineUserLoginMiddleCenter2 = new System.Windows.Forms.Panel();
            this.inputEnteringUserPassword = new System.Windows.Forms.TextBox();
            this.labelEnteringPassword = new System.Windows.Forms.Label();
            this.LineUserLoginMiddleCenter1 = new System.Windows.Forms.Panel();
            this.inputEnteringUserLogin = new System.Windows.Forms.TextBox();
            this.labelEnteringUserName = new System.Windows.Forms.Label();
            this.pnlUserRegistration = new System.Windows.Forms.Panel();
            this.btn0peningLoginForm = new System.Windows.Forms.Button();
            this.pnlUserRegistrationMiddleCenter = new System.Windows.Forms.Panel();
            this.labelRegistrationMessage = new System.Windows.Forms.Label();
            this.LineRegistrationUserMiddleCenter4 = new System.Windows.Forms.Panel();
            this.inputRegistrationPassword2 = new System.Windows.Forms.TextBox();
            this.labelRegistrationPassword2 = new System.Windows.Forms.Label();
            this.LineRegistrationUserMiddleCenter3 = new System.Windows.Forms.Panel();
            this.inputRegistrationPassword1 = new System.Windows.Forms.TextBox();
            this.labelRegistrationPassword1 = new System.Windows.Forms.Label();
            this.btnUserRegistration = new System.Windows.Forms.Button();
            this.LineRegistrationUserMiddleCenter2 = new System.Windows.Forms.Panel();
            this.inputRegistrationUserLogin = new System.Windows.Forms.TextBox();
            this.labelRegistrationLogin = new System.Windows.Forms.Label();
            this.LineRegistrationUserMiddleCenter1 = new System.Windows.Forms.Panel();
            this.inputRegistrationUserName = new System.Windows.Forms.TextBox();
            this.labelRegistrationUserName = new System.Windows.Forms.Label();
            this.MenuUpWin.SuspendLayout();
            this.MenuUp.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.pnlMainMenu.SuspendLayout();
            this.pnlMainMenuMessege.SuspendLayout();
            this.pnlMainMenuMassegeInputText.SuspendLayout();
            this.pnlMainMenuLeftMenu.SuspendLayout();
            this.pnlMainMenuLeftMenuSearchUser.SuspendLayout();
            this.pnlUserLogin.SuspendLayout();
            this.pnlUserLoginMiddleCenter.SuspendLayout();
            this.pnlUserRegistration.SuspendLayout();
            this.pnlUserRegistrationMiddleCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuUpWin
            // 
            this.MenuUpWin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuUpWin.BackColor = System.Drawing.Color.White;
            this.MenuUpWin.Controls.Add(this.Logo);
            this.MenuUpWin.Controls.Add(this.btnSetting);
            this.MenuUpWin.Controls.Add(this.btnSizeMinForm);
            this.MenuUpWin.Controls.Add(this.btnSizeNormOrMaxForm);
            this.MenuUpWin.Controls.Add(this.btnClosForm);
            this.MenuUpWin.Controls.Add(this.LineUpMenuWin);
            this.MenuUpWin.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.MenuUpWin.ForeColor = System.Drawing.Color.Black;
            this.MenuUpWin.Location = new System.Drawing.Point(0, 0);
            this.MenuUpWin.Name = "MenuUpWin";
            this.MenuUpWin.Size = new System.Drawing.Size(699, 26);
            this.MenuUpWin.TabIndex = 3;
            this.MenuUpWin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlWinUpMenu_MouseDown);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.White;
            this.Logo.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logo.ForeColor = System.Drawing.Color.Black;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(114, 25);
            this.Logo.TabIndex = 5;
            this.Logo.Text = "SFEMBU";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.White;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetting.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.Location = new System.Drawing.Point(579, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(30, 25);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "⚙";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetting.MouseEnter += new System.EventHandler(this.control_MouseEnterOrLeave);
            this.btnSetting.MouseLeave += new System.EventHandler(this.control_MouseEnterOrLeave);
            // 
            // btnSizeMinForm
            // 
            this.btnSizeMinForm.BackColor = System.Drawing.Color.White;
            this.btnSizeMinForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSizeMinForm.Font = new System.Drawing.Font("Noto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSizeMinForm.ForeColor = System.Drawing.Color.Black;
            this.btnSizeMinForm.Location = new System.Drawing.Point(609, 0);
            this.btnSizeMinForm.Name = "btnSizeMinForm";
            this.btnSizeMinForm.Size = new System.Drawing.Size(30, 25);
            this.btnSizeMinForm.TabIndex = 4;
            this.btnSizeMinForm.Text = "🗕";
            this.btnSizeMinForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSizeMinForm.Click += new System.EventHandler(this.btnSizeMinForm_Click);
            this.btnSizeMinForm.MouseEnter += new System.EventHandler(this.control_MouseEnterOrLeave);
            this.btnSizeMinForm.MouseLeave += new System.EventHandler(this.control_MouseEnterOrLeave);
            // 
            // btnSizeNormOrMaxForm
            // 
            this.btnSizeNormOrMaxForm.BackColor = System.Drawing.Color.White;
            this.btnSizeNormOrMaxForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSizeNormOrMaxForm.Font = new System.Drawing.Font("Noto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSizeNormOrMaxForm.ForeColor = System.Drawing.Color.Black;
            this.btnSizeNormOrMaxForm.Location = new System.Drawing.Point(639, 0);
            this.btnSizeNormOrMaxForm.Name = "btnSizeNormOrMaxForm";
            this.btnSizeNormOrMaxForm.Size = new System.Drawing.Size(30, 25);
            this.btnSizeNormOrMaxForm.TabIndex = 3;
            this.btnSizeNormOrMaxForm.Text = "🗖";
            this.btnSizeNormOrMaxForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSizeNormOrMaxForm.Click += new System.EventHandler(this.btnSizeNormOrMaxForm_Click);
            this.btnSizeNormOrMaxForm.MouseEnter += new System.EventHandler(this.control_MouseEnterOrLeave);
            this.btnSizeNormOrMaxForm.MouseLeave += new System.EventHandler(this.control_MouseEnterOrLeave);
            // 
            // btnClosForm
            // 
            this.btnClosForm.BackColor = System.Drawing.Color.White;
            this.btnClosForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClosForm.Font = new System.Drawing.Font("Noto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClosForm.ForeColor = System.Drawing.Color.Black;
            this.btnClosForm.Location = new System.Drawing.Point(669, 0);
            this.btnClosForm.Name = "btnClosForm";
            this.btnClosForm.Size = new System.Drawing.Size(30, 25);
            this.btnClosForm.TabIndex = 1;
            this.btnClosForm.Text = "🗙";
            this.btnClosForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClosForm.Click += new System.EventHandler(this.btnClosForm_Click);
            this.btnClosForm.MouseEnter += new System.EventHandler(this.control_MouseEnterOrLeave);
            this.btnClosForm.MouseLeave += new System.EventHandler(this.control_MouseEnterOrLeave);
            // 
            // LineUpMenuWin
            // 
            this.LineUpMenuWin.BackColor = System.Drawing.Color.Black;
            this.LineUpMenuWin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LineUpMenuWin.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.LineUpMenuWin.ForeColor = System.Drawing.Color.White;
            this.LineUpMenuWin.Location = new System.Drawing.Point(0, 25);
            this.LineUpMenuWin.Name = "LineUpMenuWin";
            this.LineUpMenuWin.Size = new System.Drawing.Size(699, 1);
            this.LineUpMenuWin.TabIndex = 0;
            // 
            // LineRight
            // 
            this.LineRight.BackColor = System.Drawing.Color.Black;
            this.LineRight.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LineRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.LineRight.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.LineRight.ForeColor = System.Drawing.Color.White;
            this.LineRight.Location = new System.Drawing.Point(699, 0);
            this.LineRight.Name = "LineRight";
            this.LineRight.Size = new System.Drawing.Size(1, 350);
            this.LineRight.TabIndex = 4;
            // 
            // LineDown
            // 
            this.LineDown.BackColor = System.Drawing.Color.Black;
            this.LineDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LineDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LineDown.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.LineDown.ForeColor = System.Drawing.Color.White;
            this.LineDown.Location = new System.Drawing.Point(0, 349);
            this.LineDown.Name = "LineDown";
            this.LineDown.Size = new System.Drawing.Size(699, 1);
            this.LineDown.TabIndex = 5;
            // 
            // MenuUp
            // 
            this.MenuUp.BackColor = System.Drawing.Color.White;
            this.MenuUp.Controls.Add(this.MenuUpWin);
            this.MenuUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuUp.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.MenuUp.ForeColor = System.Drawing.Color.Black;
            this.MenuUp.Location = new System.Drawing.Point(0, 0);
            this.MenuUp.Name = "MenuUp";
            this.MenuUp.Size = new System.Drawing.Size(699, 26);
            this.MenuUp.TabIndex = 7;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.btnChangeSizeForm);
            this.panelContent.Controls.Add(this.pnlUserLogin);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.panelContent.ForeColor = System.Drawing.Color.Black;
            this.panelContent.Location = new System.Drawing.Point(0, 26);
            this.panelContent.MinimumSize = new System.Drawing.Size(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(699, 323);
            this.panelContent.TabIndex = 8;
            // 
            // btnChangeSizeForm
            // 
            this.btnChangeSizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeSizeForm.BackColor = System.Drawing.Color.Violet;
            this.btnChangeSizeForm.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnChangeSizeForm.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.btnChangeSizeForm.Location = new System.Drawing.Point(675, 299);
            this.btnChangeSizeForm.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeSizeForm.Name = "btnChangeSizeForm";
            this.btnChangeSizeForm.Size = new System.Drawing.Size(24, 24);
            this.btnChangeSizeForm.TabIndex = 18;
            this.btnChangeSizeForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangeSizeForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnChangeSizeForm_MouseDown);
            this.btnChangeSizeForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnChangeSizeForm_MouseMove);
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.Controls.Add(this.pnlMainMenuMessege);
            this.pnlMainMenu.Controls.Add(this.pnlMainMenuLeftMenu);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(699, 323);
            this.pnlMainMenu.TabIndex = 19;
            // 
            // pnlMainMenuMessege
            // 
            this.pnlMainMenuMessege.BackColor = System.Drawing.Color.White;
            this.pnlMainMenuMessege.Controls.Add(this.panelChat);
            this.pnlMainMenuMessege.Controls.Add(this.pnlMainMenuMassegeInputText);
            this.pnlMainMenuMessege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainMenuMessege.Location = new System.Drawing.Point(211, 0);
            this.pnlMainMenuMessege.Name = "pnlMainMenuMessege";
            this.pnlMainMenuMessege.Size = new System.Drawing.Size(488, 323);
            this.pnlMainMenuMessege.TabIndex = 1;
            // 
            // panelChat
            // 
            this.panelChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChat.Location = new System.Drawing.Point(0, 0);
            this.panelChat.Name = "pnlChat";
            this.panelChat.Size = new System.Drawing.Size(488, 296);
            this.panelChat.TabIndex = 9;
            // 
            // pnlMainMenuMassegeInputText
            // 
            this.pnlMainMenuMassegeInputText.Controls.Add(this.inputMassegeText);
            this.pnlMainMenuMassegeInputText.Controls.Add(this.btnSendingMessage);
            this.pnlMainMenuMassegeInputText.Controls.Add(this.LineMainMenuInputMassegeText);
            this.pnlMainMenuMassegeInputText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMainMenuMassegeInputText.Location = new System.Drawing.Point(0, 296);
            this.pnlMainMenuMassegeInputText.Name = "pnlMainMenuMassegeInputText";
            this.pnlMainMenuMassegeInputText.Size = new System.Drawing.Size(488, 27);
            this.pnlMainMenuMassegeInputText.TabIndex = 8;
            // 
            // inputMassegeText
            // 
            this.inputMassegeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputMassegeText.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputMassegeText.ForeColor = System.Drawing.Color.Gray;
            this.inputMassegeText.Location = new System.Drawing.Point(27, 7);
            this.inputMassegeText.Name = "inputMassegeText";
            this.inputMassegeText.Size = new System.Drawing.Size(385, 16);
            this.inputMassegeText.TabIndex = 3;
            this.inputMassegeText.Text = "Сообщение";
            this.inputMassegeText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlaceholderTextDelete_MouseDown);
            // 
            // btnSendingMessage
            // 
            this.btnSendingMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSendingMessage.FlatAppearance.BorderSize = 0;
            this.btnSendingMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendingMessage.Location = new System.Drawing.Point(0, 1);
            this.btnSendingMessage.Name = "btnSendingMessage";
            this.btnSendingMessage.Size = new System.Drawing.Size(27, 26);
            this.btnSendingMessage.TabIndex = 0;
            this.btnSendingMessage.Text = "⮞";
            this.btnSendingMessage.UseVisualStyleBackColor = true;
            this.btnSendingMessage.MouseEnter += new System.EventHandler(this.control_MouseEnterOrLeave);
            this.btnSendingMessage.MouseLeave += new System.EventHandler(this.control_MouseEnterOrLeave);
            // 
            // LineMainMenuInputMassegeText
            // 
            this.LineMainMenuInputMassegeText.BackColor = System.Drawing.Color.Black;
            this.LineMainMenuInputMassegeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LineMainMenuInputMassegeText.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.LineMainMenuInputMassegeText.ForeColor = System.Drawing.Color.White;
            this.LineMainMenuInputMassegeText.Location = new System.Drawing.Point(0, 0);
            this.LineMainMenuInputMassegeText.Name = "LineMainMenuInputMassegeText";
            this.LineMainMenuInputMassegeText.Size = new System.Drawing.Size(488, 1);
            this.LineMainMenuInputMassegeText.TabIndex = 2;
            // 
            // pnlMainMenuLeftMenu
            // 
            this.pnlMainMenuLeftMenu.BackColor = System.Drawing.Color.White;
            this.pnlMainMenuLeftMenu.Controls.Add(this.panelListUser);
            this.pnlMainMenuLeftMenu.Controls.Add(this.pnlMainMenuLeftMenuSearchUser);
            this.pnlMainMenuLeftMenu.Controls.Add(this.LineMainMenuLeftMenu);
            this.pnlMainMenuLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainMenuLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenuLeftMenu.Name = "pnlMainMenuLeftMenu";
            this.pnlMainMenuLeftMenu.Size = new System.Drawing.Size(211, 323);
            this.pnlMainMenuLeftMenu.TabIndex = 0;
            // 
            // panelListUser
            // 
            this.panelListUser.AutoScroll = true;
            this.panelListUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListUser.Location = new System.Drawing.Point(0, 27);
            this.panelListUser.Name = "panelListUser";
            this.panelListUser.Size = new System.Drawing.Size(210, 296);
            this.panelListUser.TabIndex = 3;
            // 
            // pnlMainMenuLeftMenuSearchUser
            // 
            this.pnlMainMenuLeftMenuSearchUser.Controls.Add(this.labelSerchLoginOrID);
            this.pnlMainMenuLeftMenuSearchUser.Controls.Add(this.inputSerchLoginOrID);
            this.pnlMainMenuLeftMenuSearchUser.Controls.Add(this.LineSearchUser);
            this.pnlMainMenuLeftMenuSearchUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainMenuLeftMenuSearchUser.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenuLeftMenuSearchUser.Name = "pnlMainMenuLeftMenuSearchUser";
            this.pnlMainMenuLeftMenuSearchUser.Size = new System.Drawing.Size(210, 27);
            this.pnlMainMenuLeftMenuSearchUser.TabIndex = 2;
            // 
            // labelSerchLoginOrID
            // 
            this.labelSerchLoginOrID.AutoSize = true;
            this.labelSerchLoginOrID.Location = new System.Drawing.Point(3, 7);
            this.labelSerchLoginOrID.Name = "labelSerchLoginOrID";
            this.labelSerchLoginOrID.Size = new System.Drawing.Size(18, 13);
            this.labelSerchLoginOrID.TabIndex = 4;
            this.labelSerchLoginOrID.Text = "🔍︎";
            // 
            // inputSerchLoginOrID
            // 
            this.inputSerchLoginOrID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSerchLoginOrID.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputSerchLoginOrID.ForeColor = System.Drawing.Color.Gray;
            this.inputSerchLoginOrID.Location = new System.Drawing.Point(27, 6);
            this.inputSerchLoginOrID.Name = "inputSerchLoginOrID";
            this.inputSerchLoginOrID.Size = new System.Drawing.Size(180, 16);
            this.inputSerchLoginOrID.TabIndex = 3;
            this.inputSerchLoginOrID.Text = "Поиск";
            this.inputSerchLoginOrID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlaceholderTextDelete_MouseDown);
            // 
            // LineSearchUser
            // 
            this.LineSearchUser.BackColor = System.Drawing.Color.Black;
            this.LineSearchUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LineSearchUser.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.LineSearchUser.ForeColor = System.Drawing.Color.White;
            this.LineSearchUser.Location = new System.Drawing.Point(0, 26);
            this.LineSearchUser.Name = "LineSearchUser";
            this.LineSearchUser.Size = new System.Drawing.Size(210, 1);
            this.LineSearchUser.TabIndex = 2;
            // 
            // LineMainMenuLeftMenu
            // 
            this.LineMainMenuLeftMenu.BackColor = System.Drawing.Color.Black;
            this.LineMainMenuLeftMenu.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LineMainMenuLeftMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.LineMainMenuLeftMenu.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.LineMainMenuLeftMenu.ForeColor = System.Drawing.Color.White;
            this.LineMainMenuLeftMenu.Location = new System.Drawing.Point(210, 0);
            this.LineMainMenuLeftMenu.Name = "LineMainMenuLeftMenu";
            this.LineMainMenuLeftMenu.Size = new System.Drawing.Size(1, 323);
            this.LineMainMenuLeftMenu.TabIndex = 1;
            this.LineMainMenuLeftMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LineMainMenuLeftMenu_MouseMove);
            // 
            // pnlUserLogin
            // 
            this.pnlUserLogin.BackColor = System.Drawing.Color.White;
            this.pnlUserLogin.Controls.Add(this.labelEnteringStatusCode);
            this.pnlUserLogin.Controls.Add(this.pnlUserLoginMiddleCenter);
            this.pnlUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlUserLogin.Name = "pnlUserLogin";
            this.pnlUserLogin.Size = new System.Drawing.Size(699, 323);
            this.pnlUserLogin.TabIndex = 19;
            this.pnlUserLogin.SizeChanged += new System.EventHandler(this.pnlUserLogin_SizeChanged);
            // 
            // labelEnteringStatusCode
            // 
            this.labelEnteringStatusCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEnteringStatusCode.BackColor = System.Drawing.Color.White;
            this.labelEnteringStatusCode.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnteringStatusCode.ForeColor = System.Drawing.Color.Black;
            this.labelEnteringStatusCode.Location = new System.Drawing.Point(3, 285);
            this.labelEnteringStatusCode.Name = "labelEnteringStatusCode";
            this.labelEnteringStatusCode.Size = new System.Drawing.Size(300, 30);
            this.labelEnteringStatusCode.TabIndex = 17;
            this.labelEnteringStatusCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlUserLoginMiddleCenter
            // 
            this.pnlUserLoginMiddleCenter.BackColor = System.Drawing.Color.White;
            this.pnlUserLoginMiddleCenter.Controls.Add(this.btn0peningRetistrationForm);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.btnUserLogin);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.LineUserLoginMiddleCenter2);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.inputEnteringUserPassword);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.labelEnteringPassword);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.LineUserLoginMiddleCenter1);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.inputEnteringUserLogin);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.labelEnteringUserName);
            this.pnlUserLoginMiddleCenter.Location = new System.Drawing.Point(182, 53);
            this.pnlUserLoginMiddleCenter.Name = "pnlUserLoginMiddleCenter";
            this.pnlUserLoginMiddleCenter.Size = new System.Drawing.Size(300, 178);
            this.pnlUserLoginMiddleCenter.TabIndex = 0;
            // 
            // btn0peningRetistrationForm
            // 
            this.btn0peningRetistrationForm.FlatAppearance.BorderSize = 0;
            this.btn0peningRetistrationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0peningRetistrationForm.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.btn0peningRetistrationForm.Location = new System.Drawing.Point(85, 141);
            this.btn0peningRetistrationForm.Name = "btn0peningRetistrationForm";
            this.btn0peningRetistrationForm.Size = new System.Drawing.Size(130, 26);
            this.btn0peningRetistrationForm.TabIndex = 16;
            this.btn0peningRetistrationForm.Text = "Регистрация";
            this.btn0peningRetistrationForm.UseVisualStyleBackColor = true;
            this.btn0peningRetistrationForm.MouseEnter += new System.EventHandler(this.control_MouseEnterOrLeave);
            this.btn0peningRetistrationForm.MouseLeave += new System.EventHandler(this.control_MouseEnterOrLeave);
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.FlatAppearance.BorderSize = 0;
            this.btnUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLogin.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.btnUserLogin.Location = new System.Drawing.Point(120, 109);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(60, 26);
            this.btnUserLogin.TabIndex = 15;
            this.btnUserLogin.Text = "Вход";
            this.btnUserLogin.UseVisualStyleBackColor = true;
            this.btnUserLogin.MouseEnter += new System.EventHandler(this.control_MouseEnterOrLeave);
            this.btnUserLogin.MouseLeave += new System.EventHandler(this.control_MouseEnterOrLeave);
            // 
            // LineUserLoginMiddleCenter2
            // 
            this.LineUserLoginMiddleCenter2.BackColor = System.Drawing.Color.Black;
            this.LineUserLoginMiddleCenter2.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.LineUserLoginMiddleCenter2.ForeColor = System.Drawing.Color.White;
            this.LineUserLoginMiddleCenter2.Location = new System.Drawing.Point(4, 99);
            this.LineUserLoginMiddleCenter2.Name = "LineUserLoginMiddleCenter2";
            this.LineUserLoginMiddleCenter2.Size = new System.Drawing.Size(296, 1);
            this.LineUserLoginMiddleCenter2.TabIndex = 14;
            // 
            // inputEnteringUserPassword
            // 
            this.inputEnteringUserPassword.BackColor = System.Drawing.Color.White;
            this.inputEnteringUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputEnteringUserPassword.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.inputEnteringUserPassword.ForeColor = System.Drawing.Color.Gray;
            this.inputEnteringUserPassword.Location = new System.Drawing.Point(4, 80);
            this.inputEnteringUserPassword.Name = "inputEnteringUserPassword";
            this.inputEnteringUserPassword.Size = new System.Drawing.Size(296, 19);
            this.inputEnteringUserPassword.TabIndex = 13;
            this.inputEnteringUserPassword.Text = "Введите пароль";
            this.inputEnteringUserPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlaceholderTextDeleteForPassword_MouseDown);
            // 
            // labelEnteringPassword
            // 
            this.labelEnteringPassword.BackColor = System.Drawing.Color.White;
            this.labelEnteringPassword.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnteringPassword.ForeColor = System.Drawing.Color.Black;
            this.labelEnteringPassword.Location = new System.Drawing.Point(0, 50);
            this.labelEnteringPassword.Name = "labelEnteringPassword";
            this.labelEnteringPassword.Size = new System.Drawing.Size(300, 30);
            this.labelEnteringPassword.TabIndex = 12;
            this.labelEnteringPassword.Text = "Пароль:";
            this.labelEnteringPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LineUserLoginMiddleCenter1
            // 
            this.LineUserLoginMiddleCenter1.BackColor = System.Drawing.Color.Black;
            this.LineUserLoginMiddleCenter1.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.LineUserLoginMiddleCenter1.ForeColor = System.Drawing.Color.White;
            this.LineUserLoginMiddleCenter1.Location = new System.Drawing.Point(4, 49);
            this.LineUserLoginMiddleCenter1.Name = "LineUserLoginMiddleCenter1";
            this.LineUserLoginMiddleCenter1.Size = new System.Drawing.Size(296, 1);
            this.LineUserLoginMiddleCenter1.TabIndex = 11;
            // 
            // inputEnteringUserLogin
            // 
            this.inputEnteringUserLogin.BackColor = System.Drawing.Color.White;
            this.inputEnteringUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputEnteringUserLogin.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.inputEnteringUserLogin.ForeColor = System.Drawing.Color.Gray;
            this.inputEnteringUserLogin.Location = new System.Drawing.Point(4, 30);
            this.inputEnteringUserLogin.Name = "inputEnteringUserLogin";
            this.inputEnteringUserLogin.Size = new System.Drawing.Size(296, 19);
            this.inputEnteringUserLogin.TabIndex = 8;
            this.inputEnteringUserLogin.Text = "Введите имя";
            this.inputEnteringUserLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlaceholderTextDelete_MouseDown);
            // 
            // labelEnteringUserName
            // 
            this.labelEnteringUserName.BackColor = System.Drawing.Color.White;
            this.labelEnteringUserName.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnteringUserName.ForeColor = System.Drawing.Color.Black;
            this.labelEnteringUserName.Location = new System.Drawing.Point(0, 0);
            this.labelEnteringUserName.Name = "labelEnteringUserName";
            this.labelEnteringUserName.Size = new System.Drawing.Size(300, 30);
            this.labelEnteringUserName.TabIndex = 6;
            this.labelEnteringUserName.Text = "Имя:";
            this.labelEnteringUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlUserRegistration
            // 
            this.pnlUserRegistration.Controls.Add(this.btn0peningLoginForm);
            this.pnlUserRegistration.Controls.Add(this.pnlUserRegistrationMiddleCenter);
            this.pnlUserRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserRegistration.Location = new System.Drawing.Point(0, 0);
            this.pnlUserRegistration.Name = "pnlUserRegistration";
            this.pnlUserRegistration.Size = new System.Drawing.Size(699, 323);
            this.pnlUserRegistration.TabIndex = 19;
            this.pnlUserRegistration.SizeChanged += new System.EventHandler(this.pnlRegistrationUser_SizeChanged);
            // 
            // btn0peningLoginForm
            // 
            this.btn0peningLoginForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn0peningLoginForm.BackgroundImage = global::WindowsFormsApp.Properties.Resources.icons8_go_back_48;
            this.btn0peningLoginForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn0peningLoginForm.FlatAppearance.BorderSize = 0;
            this.btn0peningLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0peningLoginForm.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.btn0peningLoginForm.Location = new System.Drawing.Point(4, 286);
            this.btn0peningLoginForm.Name = "btn0peningLoginForm";
            this.btn0peningLoginForm.Size = new System.Drawing.Size(32, 32);
            this.btn0peningLoginForm.TabIndex = 23;
            this.btn0peningLoginForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn0peningLoginForm.UseVisualStyleBackColor = true;
            // 
            // pnlUserRegistrationMiddleCenter
            // 
            this.pnlUserRegistrationMiddleCenter.AutoScroll = true;
            this.pnlUserRegistrationMiddleCenter.BackColor = System.Drawing.Color.White;
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.labelRegistrationMessage);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.LineRegistrationUserMiddleCenter4);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.inputRegistrationPassword2);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.labelRegistrationPassword2);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.LineRegistrationUserMiddleCenter3);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.inputRegistrationPassword1);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.labelRegistrationPassword1);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.btnUserRegistration);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.LineRegistrationUserMiddleCenter2);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.inputRegistrationUserLogin);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.labelRegistrationLogin);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.LineRegistrationUserMiddleCenter1);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.inputRegistrationUserName);
            this.pnlUserRegistrationMiddleCenter.Controls.Add(this.labelRegistrationUserName);
            this.pnlUserRegistrationMiddleCenter.Location = new System.Drawing.Point(198, 37);
            this.pnlUserRegistrationMiddleCenter.Name = "pnlUserRegistrationMiddleCenter";
            this.pnlUserRegistrationMiddleCenter.Size = new System.Drawing.Size(300, 275);
            this.pnlUserRegistrationMiddleCenter.TabIndex = 1;
            // 
            // labelRegistrationMessage
            // 
            this.labelRegistrationMessage.AutoSize = true;
            this.labelRegistrationMessage.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.labelRegistrationMessage.Location = new System.Drawing.Point(3, 235);
            this.labelRegistrationMessage.Name = "labelRegistrationMessage";
            this.labelRegistrationMessage.Size = new System.Drawing.Size(289, 19);
            this.labelRegistrationMessage.TabIndex = 23;
            this.labelRegistrationMessage.Text = "введеные пароли не совпадают";
            this.labelRegistrationMessage.Visible = false;
            // 
            // LineRegistrationUserMiddleCenter4
            // 
            this.LineRegistrationUserMiddleCenter4.BackColor = System.Drawing.Color.Black;
            this.LineRegistrationUserMiddleCenter4.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.LineRegistrationUserMiddleCenter4.ForeColor = System.Drawing.Color.White;
            this.LineRegistrationUserMiddleCenter4.Location = new System.Drawing.Point(4, 199);
            this.LineRegistrationUserMiddleCenter4.Name = "LineRegistrationUserMiddleCenter4";
            this.LineRegistrationUserMiddleCenter4.Size = new System.Drawing.Size(296, 1);
            this.LineRegistrationUserMiddleCenter4.TabIndex = 22;
            // 
            // inputRegistrationPassword2
            // 
            this.inputRegistrationPassword2.BackColor = System.Drawing.Color.White;
            this.inputRegistrationPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputRegistrationPassword2.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.inputRegistrationPassword2.ForeColor = System.Drawing.Color.Gray;
            this.inputRegistrationPassword2.Location = new System.Drawing.Point(4, 180);
            this.inputRegistrationPassword2.Name = "inputRegistrationPassword2";
            this.inputRegistrationPassword2.Size = new System.Drawing.Size(296, 19);
            this.inputRegistrationPassword2.TabIndex = 21;
            this.inputRegistrationPassword2.Text = "Введите пароль ещё раз";
            this.inputRegistrationPassword2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlaceholderTextDeleteForPassword_MouseDown);
            // 
            // labelRegistrationPassword2
            // 
            this.labelRegistrationPassword2.BackColor = System.Drawing.Color.White;
            this.labelRegistrationPassword2.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationPassword2.ForeColor = System.Drawing.Color.Black;
            this.labelRegistrationPassword2.Location = new System.Drawing.Point(0, 150);
            this.labelRegistrationPassword2.Name = "labelRegistrationPassword2";
            this.labelRegistrationPassword2.Size = new System.Drawing.Size(300, 30);
            this.labelRegistrationPassword2.TabIndex = 20;
            this.labelRegistrationPassword2.Text = "Введите пароль повторно:";
            this.labelRegistrationPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LineRegistrationUserMiddleCenter3
            // 
            this.LineRegistrationUserMiddleCenter3.BackColor = System.Drawing.Color.Black;
            this.LineRegistrationUserMiddleCenter3.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.LineRegistrationUserMiddleCenter3.ForeColor = System.Drawing.Color.White;
            this.LineRegistrationUserMiddleCenter3.Location = new System.Drawing.Point(4, 149);
            this.LineRegistrationUserMiddleCenter3.Name = "LineRegistrationUserMiddleCenter3";
            this.LineRegistrationUserMiddleCenter3.Size = new System.Drawing.Size(296, 1);
            this.LineRegistrationUserMiddleCenter3.TabIndex = 19;
            // 
            // inputRegistrationPassword1
            // 
            this.inputRegistrationPassword1.BackColor = System.Drawing.Color.White;
            this.inputRegistrationPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputRegistrationPassword1.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.inputRegistrationPassword1.ForeColor = System.Drawing.Color.Gray;
            this.inputRegistrationPassword1.Location = new System.Drawing.Point(4, 130);
            this.inputRegistrationPassword1.Name = "inputRegistrationPassword1";
            this.inputRegistrationPassword1.Size = new System.Drawing.Size(296, 19);
            this.inputRegistrationPassword1.TabIndex = 18;
            this.inputRegistrationPassword1.Text = "Введите пароль";
            this.inputRegistrationPassword1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlaceholderTextDeleteForPassword_MouseDown);
            // 
            // labelRegistrationPassword1
            // 
            this.labelRegistrationPassword1.BackColor = System.Drawing.Color.White;
            this.labelRegistrationPassword1.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationPassword1.ForeColor = System.Drawing.Color.Black;
            this.labelRegistrationPassword1.Location = new System.Drawing.Point(0, 100);
            this.labelRegistrationPassword1.Name = "labelRegistrationPassword1";
            this.labelRegistrationPassword1.Size = new System.Drawing.Size(300, 30);
            this.labelRegistrationPassword1.TabIndex = 17;
            this.labelRegistrationPassword1.Text = "Пароль:";
            this.labelRegistrationPassword1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUserRegistration
            // 
            this.btnUserRegistration.FlatAppearance.BorderSize = 0;
            this.btnUserRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserRegistration.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.btnUserRegistration.Location = new System.Drawing.Point(85, 206);
            this.btnUserRegistration.Name = "btnUserRegistration";
            this.btnUserRegistration.Size = new System.Drawing.Size(130, 26);
            this.btnUserRegistration.TabIndex = 16;
            this.btnUserRegistration.Text = "Регистрация";
            this.btnUserRegistration.UseVisualStyleBackColor = true;
            this.btnUserRegistration.MouseEnter += new System.EventHandler(this.control_MouseEnterOrLeave);
            this.btnUserRegistration.MouseLeave += new System.EventHandler(this.control_MouseEnterOrLeave);
            // 
            // LineRegistrationUserMiddleCenter2
            // 
            this.LineRegistrationUserMiddleCenter2.BackColor = System.Drawing.Color.Black;
            this.LineRegistrationUserMiddleCenter2.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.LineRegistrationUserMiddleCenter2.ForeColor = System.Drawing.Color.White;
            this.LineRegistrationUserMiddleCenter2.Location = new System.Drawing.Point(4, 99);
            this.LineRegistrationUserMiddleCenter2.Name = "LineRegistrationUserMiddleCenter2";
            this.LineRegistrationUserMiddleCenter2.Size = new System.Drawing.Size(296, 1);
            this.LineRegistrationUserMiddleCenter2.TabIndex = 14;
            // 
            // inputRegistrationUserLogin
            // 
            this.inputRegistrationUserLogin.BackColor = System.Drawing.Color.White;
            this.inputRegistrationUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputRegistrationUserLogin.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.inputRegistrationUserLogin.ForeColor = System.Drawing.Color.Gray;
            this.inputRegistrationUserLogin.Location = new System.Drawing.Point(4, 80);
            this.inputRegistrationUserLogin.Name = "inputRegistrationUserLogin";
            this.inputRegistrationUserLogin.Size = new System.Drawing.Size(296, 19);
            this.inputRegistrationUserLogin.TabIndex = 13;
            this.inputRegistrationUserLogin.Text = "Введите логин";
            this.inputRegistrationUserLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlaceholderTextDelete_MouseDown);
            // 
            // labelRegistrationLogin
            // 
            this.labelRegistrationLogin.BackColor = System.Drawing.Color.White;
            this.labelRegistrationLogin.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationLogin.ForeColor = System.Drawing.Color.Black;
            this.labelRegistrationLogin.Location = new System.Drawing.Point(0, 50);
            this.labelRegistrationLogin.Name = "labelRegistrationLogin";
            this.labelRegistrationLogin.Size = new System.Drawing.Size(300, 30);
            this.labelRegistrationLogin.TabIndex = 12;
            this.labelRegistrationLogin.Text = "Логин:";
            this.labelRegistrationLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LineRegistrationUserMiddleCenter1
            // 
            this.LineRegistrationUserMiddleCenter1.BackColor = System.Drawing.Color.Black;
            this.LineRegistrationUserMiddleCenter1.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.LineRegistrationUserMiddleCenter1.ForeColor = System.Drawing.Color.White;
            this.LineRegistrationUserMiddleCenter1.Location = new System.Drawing.Point(4, 49);
            this.LineRegistrationUserMiddleCenter1.Name = "LineRegistrationUserMiddleCenter1";
            this.LineRegistrationUserMiddleCenter1.Size = new System.Drawing.Size(296, 1);
            this.LineRegistrationUserMiddleCenter1.TabIndex = 11;
            // 
            // inputRegistrationUserName
            // 
            this.inputRegistrationUserName.BackColor = System.Drawing.Color.White;
            this.inputRegistrationUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputRegistrationUserName.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.inputRegistrationUserName.ForeColor = System.Drawing.Color.Gray;
            this.inputRegistrationUserName.Location = new System.Drawing.Point(4, 30);
            this.inputRegistrationUserName.Name = "inputRegistrationUserName";
            this.inputRegistrationUserName.Size = new System.Drawing.Size(296, 19);
            this.inputRegistrationUserName.TabIndex = 8;
            this.inputRegistrationUserName.Text = "Введите имя";
            this.inputRegistrationUserName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlaceholderTextDelete_MouseDown);
            // 
            // labelRegistrationUserName
            // 
            this.labelRegistrationUserName.BackColor = System.Drawing.Color.White;
            this.labelRegistrationUserName.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationUserName.ForeColor = System.Drawing.Color.Black;
            this.labelRegistrationUserName.Location = new System.Drawing.Point(0, 0);
            this.labelRegistrationUserName.Name = "labelRegistrationUserName";
            this.labelRegistrationUserName.Size = new System.Drawing.Size(300, 30);
            this.labelRegistrationUserName.TabIndex = 6;
            this.labelRegistrationUserName.Text = "Имя:";
            this.labelRegistrationUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DesktopAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.MenuUp);
            this.Controls.Add(this.LineDown);
            this.Controls.Add(this.LineRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 850);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "DesktopAppForm";
            this.Text = "SFEMBU";
            this.MenuUpWin.ResumeLayout(false);
            this.MenuUp.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenuMessege.ResumeLayout(false);
            this.pnlMainMenuMassegeInputText.ResumeLayout(false);
            this.pnlMainMenuMassegeInputText.PerformLayout();
            this.pnlMainMenuLeftMenu.ResumeLayout(false);
            this.pnlMainMenuLeftMenuSearchUser.ResumeLayout(false);
            this.pnlMainMenuLeftMenuSearchUser.PerformLayout();
            this.pnlUserLogin.ResumeLayout(false);
            this.pnlUserLoginMiddleCenter.ResumeLayout(false);
            this.pnlUserLoginMiddleCenter.PerformLayout();
            this.pnlUserRegistration.ResumeLayout(false);
            this.pnlUserRegistrationMiddleCenter.ResumeLayout(false);
            this.pnlUserRegistrationMiddleCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel MenuUpWin;
        private Panel LineUpMenuWin;
        private Label btnSizeNormOrMaxForm;
        private Label btnClosForm;
        private Panel LineRight;
        private Panel LineDown;
        private Label btnSizeMinForm;
        private Panel MenuUp;
        private Label btnSetting;
        private Panel pnlUserLoginMiddleCenter;
        private Label labelEnteringUserName;
        private Label labelEnteringPassword;
        private Panel LineUserLoginMiddleCenter1;
        private Panel LineUserLoginMiddleCenter2;
        private Button btnUserLogin;
        private Button btn0peningRetistrationForm;
        private Panel LineMainMenuLeftMenu;
        private Panel pnlMainMenuLeftMenuSearchUser;
        private TextBox inputSerchLoginOrID;
        private Panel LineSearchUser;
        private Panel pnlUserRegistrationMiddleCenter;
        private Panel LineRegistrationUserMiddleCenter3;
        private Label labelRegistrationPassword1;
        private Button btnUserRegistration;
        private Panel LineRegistrationUserMiddleCenter2;
        private Label labelRegistrationLogin;
        private Panel LineRegistrationUserMiddleCenter1;
        private Label labelRegistrationUserName;
        private Panel LineRegistrationUserMiddleCenter4;
        private Label labelRegistrationPassword2;
        private Button btn0peningLoginForm;
        private Label Logo;
        private Label labelSerchLoginOrID;
        public TextBox inputEnteringUserPassword;
        public TextBox inputEnteringUserLogin;
        private Label labelEnteringStatusCode;
        public Panel pnlMainMenuLeftMenu;
        public Panel pnlUserLogin;
        public Panel panelContent;
        public Panel pnlUserRegistration;
        public TextBox inputRegistrationPassword1;
        public TextBox inputRegistrationUserName;
        public TextBox inputRegistrationPassword2;
        public TextBox inputRegistrationUserLogin;
        public Label labelRegistrationMessage;
        public Panel pnlMainMenu;
        public Label btnChangeSizeForm;
        private Panel pnlMainMenuMessege;
        private Panel pnlMainMenuMassegeInputText;
        private TextBox inputMassegeText;
        private Button btnSendingMessage;
        private Panel LineMainMenuInputMassegeText;
        public Panel panelListUser;
        public Panel panelChat;
    }
}

