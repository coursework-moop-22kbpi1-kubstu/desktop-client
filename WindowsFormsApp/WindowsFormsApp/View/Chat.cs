using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Model;
using WindowsFormsApp.Model.Entities;
using WindowsFormsApp.Model.EventAndDelegate;

namespace WindowsFormsApp.View
{
    public class Chat
    {
        private View view;
        private ViewModel.ViewModel viewModel;

        private UserChatInfo userChatInfo;

        public Panel panelUserList;
        private Label labelTimeLastNotification;
        private Label labelLastNotification;
        private Label labelName;

        public Panel pnlChat;

        public Chat(View view, ViewModel.ViewModel viewModel, UserChatInfo userChatInfo)
        {
            this.view = view;
            this.viewModel = viewModel;
            this.userChatInfo = userChatInfo;

            CreatePanelMessaging();
            CreatePanelUserLeftMenu();
            userChatInfo.AddNewNotificationEvent += AddNewNotificationEvent;
        }

        private void CreatePanelMessaging()
        {
            pnlChat = new Panel();
            pnlChat.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlChat.BackColor = System.Drawing.Color.Green;
        }
        private void CreatePanelUserLeftMenu()
        {
            panelUserList = new Panel();
            labelTimeLastNotification = new Label();
            labelLastNotification = new Label();
            labelName = new Label();

            System.Drawing.Font font = new System.Drawing.Font("Noto Mono", 8.25F);

            labelTimeLastNotification.AutoSize = false;
            labelTimeLastNotification.Font = font;
            labelTimeLastNotification.Location = new System.Drawing.Point(155, 5);
            labelTimeLastNotification.Size = new System.Drawing.Size(50, 13);
            labelTimeLastNotification.Text = "hh:mmtt";

            labelLastNotification.AutoSize = false;
            labelLastNotification.Font = font;
            labelLastNotification.Location = new System.Drawing.Point(3, 24);
            labelLastNotification.Size = new System.Drawing.Size(195, 26);
            labelLastNotification.Text = "Title - Message";

            labelName.AutoSize = false;
            labelName.Font = font;
            labelName.Location = new System.Drawing.Point(5, 5);
            labelName.Size = new System.Drawing.Size(145, 15);
            labelName.Text = userChatInfo.User.UserName;

            panelUserList.Controls.Add(labelTimeLastNotification);
            panelUserList.Controls.Add(labelLastNotification);
            panelUserList.Controls.Add(labelName);
            panelUserList.Dock = System.Windows.Forms.DockStyle.Top;
            panelUserList.Size = new System.Drawing.Size(210, 60);

            panelUserList.Click += new System.EventHandler(this.OpenChat);
            labelName.Click += new System.EventHandler(this.OpenChat);
            labelTimeLastNotification.Click += new System.EventHandler(this.OpenChat);
            labelLastNotification.Click += new System.EventHandler(this.OpenChat);

            userChatInfo.AddNewNotificationEvent += delegate (object obj, EventNewNotificationData e)
            {
                labelTimeLastNotification.Invoke((MethodInvoker)delegate
                {
                    labelTimeLastNotification.Text = e.newNotification.CreatedAt.ToString("hh:mm:tt"); // "hh:mm:tt"
                });
                labelLastNotification.Invoke((MethodInvoker)delegate
                {
                    labelLastNotification.Text = "[ " + e.newNotification.Title + " ] - " + e.newNotification.Message;
                });
            };
        }
        private void OpenChat(object sender, EventArgs e)
        {
            view.PnlListUser.Controls.Remove(panelUserList);
            view.PnlListUser.Controls.Add(panelUserList);

            view.PnlChat.Controls.Clear();
            view.PnlChat.Controls.Add(pnlChat);
        }
        private void AddNewNotificationEvent(object obj, EventNewNotificationData e)
        {
            Panel pnlMessagingElemTitleMessage = new Panel();
            Panel pnlMessage = new Panel();
            Label labelMessagingTime = new Label();
            Label labelMessagingMessage = new Label();
            Label labelMessagingTitle = new Label();

            labelMessagingTitle.BackColor = System.Drawing.Color.Turquoise;
            //labelMessagingTitle.Dock = System.Windows.Forms.DockStyle.Top;
            labelMessagingTitle.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelMessagingTitle.Text = e.newNotification.Title;

            labelMessagingMessage.BackColor = System.Drawing.Color.Yellow;
            //labelMessagingMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            labelMessagingMessage.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelMessagingMessage.Text = e.newNotification.Message;

            pnlMessagingElemTitleMessage.BackColor = System.Drawing.Color.Wheat;
            pnlMessagingElemTitleMessage.Controls.Add(labelMessagingMessage);
            pnlMessagingElemTitleMessage.Controls.Add(labelMessagingTitle);
            pnlMessagingElemTitleMessage.Dock = System.Windows.Forms.DockStyle.Left;
            pnlMessagingElemTitleMessage.Size = new System.Drawing.Size(488, 55);

            labelMessagingTime.AutoSize = false;
            labelMessagingTime.BackColor = System.Drawing.Color.Tomato;
            labelMessagingTime.Dock = System.Windows.Forms.DockStyle.Left;
            labelMessagingTime.Font = new System.Drawing.Font("Noto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelMessagingTime.Size = new System.Drawing.Size(50, 13);
            labelMessagingTime.Text = e.newNotification.CreatedAt.ToString("hh:mmtt");

            pnlMessage.BackColor = System.Drawing.Color.Wheat;
            pnlMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlMessage.AutoSize = true;
            pnlMessage.Size = new System.Drawing.Size(488, 155);
            pnlMessage.Controls.Add(labelMessagingTime);
            pnlMessage.Controls.Add(pnlMessagingElemTitleMessage);

            pnlChat.Invoke((MethodInvoker)delegate
            {
                pnlChat.Controls.Add(pnlMessage);
            });
        }
    }
}
