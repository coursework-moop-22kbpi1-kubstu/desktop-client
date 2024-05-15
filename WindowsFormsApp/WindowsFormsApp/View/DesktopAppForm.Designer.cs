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
            this.btnSetting = new System.Windows.Forms.Label();
            this.btnSizeMinForm = new System.Windows.Forms.Label();
            this.btnSizeNormOrMaxForm = new System.Windows.Forms.Label();
            this.btnClosForm = new System.Windows.Forms.Label();
            this.LineUpMenuWin = new System.Windows.Forms.Panel();
            this.LineRight = new System.Windows.Forms.Panel();
            this.LineDown = new System.Windows.Forms.Panel();
            this.MenuUp = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnChangeSizeForm = new System.Windows.Forms.Label();
            this.pnlUserLogin = new System.Windows.Forms.Panel();
            this.pnlUserLoginMiddleCenter = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuUpWin.SuspendLayout();
            this.MenuUp.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUserLogin.SuspendLayout();
            this.pnlUserLoginMiddleCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuUpWin
            // 
            this.MenuUpWin.BackColor = System.Drawing.Color.White;
            this.MenuUpWin.Controls.Add(this.btnSetting);
            this.MenuUpWin.Controls.Add(this.btnSizeMinForm);
            this.MenuUpWin.Controls.Add(this.btnSizeNormOrMaxForm);
            this.MenuUpWin.Controls.Add(this.btnClosForm);
            this.MenuUpWin.Controls.Add(this.LineUpMenuWin);
            this.MenuUpWin.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuUpWin.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.MenuUpWin.ForeColor = System.Drawing.Color.Black;
            this.MenuUpWin.Location = new System.Drawing.Point(429, 0);
            this.MenuUpWin.Name = "MenuUpWin";
            this.MenuUpWin.Size = new System.Drawing.Size(270, 26);
            this.MenuUpWin.TabIndex = 3;
            this.MenuUpWin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlWinUpMenu_MouseDown);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.White;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetting.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.Location = new System.Drawing.Point(150, 0);
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
            this.btnSizeMinForm.Location = new System.Drawing.Point(180, 0);
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
            this.btnSizeNormOrMaxForm.Location = new System.Drawing.Point(210, 0);
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
            this.btnClosForm.Location = new System.Drawing.Point(240, 0);
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
            this.LineUpMenuWin.Size = new System.Drawing.Size(270, 1);
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
            this.MenuUp.Controls.Add(this.Logo);
            this.MenuUp.Controls.Add(this.MenuUpWin);
            this.MenuUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuUp.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.MenuUp.ForeColor = System.Drawing.Color.Black;
            this.MenuUp.Location = new System.Drawing.Point(0, 0);
            this.MenuUp.Name = "MenuUp";
            this.MenuUp.Size = new System.Drawing.Size(699, 26);
            this.MenuUp.TabIndex = 7;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.White;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logo.ForeColor = System.Drawing.Color.Black;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(114, 26);
            this.Logo.TabIndex = 5;
            this.Logo.Text = "SFEMBU";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.btnChangeSizeForm);
            this.pnlContent.Controls.Add(this.pnlUserLogin);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.pnlContent.ForeColor = System.Drawing.Color.Black;
            this.pnlContent.Location = new System.Drawing.Point(0, 26);
            this.pnlContent.MinimumSize = new System.Drawing.Size(200, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(699, 323);
            this.pnlContent.TabIndex = 8;
            // 
            // btnChangeSizeForm
            // 
            this.btnChangeSizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeSizeForm.BackColor = System.Drawing.Color.White;
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
            // pnlUserLogin
            // 
            this.pnlUserLogin.BackColor = System.Drawing.Color.White;
            this.pnlUserLogin.Controls.Add(this.pnlUserLoginMiddleCenter);
            this.pnlUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlUserLogin.Name = "pnlUserLogin";
            this.pnlUserLogin.Size = new System.Drawing.Size(699, 323);
            this.pnlUserLogin.TabIndex = 19;
            this.pnlUserLogin.SizeChanged += new System.EventHandler(this.pnlUserLogin_SizeChanged);
            // 
            // pnlUserLoginMiddleCenter
            // 
            this.pnlUserLoginMiddleCenter.BackColor = System.Drawing.Color.White;
            this.pnlUserLoginMiddleCenter.Controls.Add(this.button1);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.panel2);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.textBox2);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.label2);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.panel1);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.textBox1);
            this.pnlUserLoginMiddleCenter.Controls.Add(this.label1);
            this.pnlUserLoginMiddleCenter.Location = new System.Drawing.Point(134, 64);
            this.pnlUserLoginMiddleCenter.Name = "pnlUserLoginMiddleCenter";
            this.pnlUserLoginMiddleCenter.Size = new System.Drawing.Size(300, 135);
            this.pnlUserLoginMiddleCenter.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(4, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 19);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 1);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(4, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 19);
            this.textBox2.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Font = new System.Drawing.Font("Noto Mono", 8.25F);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(4, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 1);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.button1.Location = new System.Drawing.Point(120, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseEnter += new System.EventHandler(this.control_MouseEnterOrLeave);
            this.button1.MouseLeave += new System.EventHandler(this.control_MouseEnterOrLeave);
            // 
            // DesktopAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.MenuUp);
            this.Controls.Add(this.LineDown);
            this.Controls.Add(this.LineRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 850);
            this.MinimumSize = new System.Drawing.Size(450, 250);
            this.Name = "DesktopAppForm";
            this.Text = "SFEMBU";
            this.MenuUpWin.ResumeLayout(false);
            this.MenuUp.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUserLogin.ResumeLayout(false);
            this.pnlUserLoginMiddleCenter.ResumeLayout(false);
            this.pnlUserLoginMiddleCenter.PerformLayout();
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
        private Panel pnlContent;
        private Label btnChangeSizeForm;
        private Label btnSetting;
        private Panel pnlUserLogin;
        private Label Logo;
        private Panel pnlUserLoginMiddleCenter;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
    }
}

