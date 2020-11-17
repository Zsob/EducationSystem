namespace Education_System
{
    partial class DesktopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlDesktop = new System.Windows.Forms.TabControl();
            this.tabPage_Announce = new System.Windows.Forms.TabPage();
            this.tabPage_Message = new System.Windows.Forms.TabPage();
            this.listBoxMessage = new System.Windows.Forms.ListBox();
            this.tabPage_SecurityQuestion = new System.Windows.Forms.TabPage();
            this.button_ResetImformation = new System.Windows.Forms.Button();
            this.button_SaveImformation = new System.Windows.Forms.Button();
            this.label_Warning = new System.Windows.Forms.Label();
            this.textBox_SecondAnswer = new System.Windows.Forms.TextBox();
            this.textBox_SecondQuestion = new System.Windows.Forms.TextBox();
            this.textBox_FirstAnswer = new System.Windows.Forms.TextBox();
            this.textBox_FirstQuestion = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Answer2 = new System.Windows.Forms.Label();
            this.label_Question2 = new System.Windows.Forms.Label();
            this.label_Answer1 = new System.Windows.Forms.Label();
            this.label_Question1 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Account = new System.Windows.Forms.Label();
            this.textBox_Account = new System.Windows.Forms.TextBox();
            this.tabPage_ChangeCode = new System.Windows.Forms.TabPage();
            this.button_ResetPassword = new System.Windows.Forms.Button();
            this.button_SavePassword = new System.Windows.Forms.Button();
            this.label_ThirdWarning = new System.Windows.Forms.Label();
            this.label_SecondWarning = new System.Windows.Forms.Label();
            this.label_FirstWarning = new System.Windows.Forms.Label();
            this.label_CheekPassword = new System.Windows.Forms.Label();
            this.label_NewPassword = new System.Windows.Forms.Label();
            this.label_OldPassword = new System.Windows.Forms.Label();
            this.label_Accountment = new System.Windows.Forms.Label();
            this.textBox_CheekPassword = new System.Windows.Forms.TextBox();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.textBox_OldPassword = new System.Windows.Forms.TextBox();
            this.textBox_Accounment = new System.Windows.Forms.TextBox();
            this.tabPage_WeeklyCalendar = new System.Windows.Forms.TabPage();
            this.TeachingmonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dgv_Message = new System.Windows.Forms.DataGridView();
            this.tabControlDesktop.SuspendLayout();
            this.tabPage_Announce.SuspendLayout();
            this.tabPage_Message.SuspendLayout();
            this.tabPage_SecurityQuestion.SuspendLayout();
            this.tabPage_ChangeCode.SuspendLayout();
            this.tabPage_WeeklyCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Message)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDesktop
            // 
            this.tabControlDesktop.Controls.Add(this.tabPage_Announce);
            this.tabControlDesktop.Controls.Add(this.tabPage_Message);
            this.tabControlDesktop.Controls.Add(this.tabPage_SecurityQuestion);
            this.tabControlDesktop.Controls.Add(this.tabPage_ChangeCode);
            this.tabControlDesktop.Controls.Add(this.tabPage_WeeklyCalendar);
            this.tabControlDesktop.Location = new System.Drawing.Point(12, 12);
            this.tabControlDesktop.Multiline = true;
            this.tabControlDesktop.Name = "tabControlDesktop";
            this.tabControlDesktop.SelectedIndex = 0;
            this.tabControlDesktop.Size = new System.Drawing.Size(776, 436);
            this.tabControlDesktop.TabIndex = 0;
            // 
            // tabPage_Announce
            // 
            this.tabPage_Announce.Controls.Add(this.dgv_Message);
            this.tabPage_Announce.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Announce.Name = "tabPage_Announce";
            this.tabPage_Announce.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Announce.Size = new System.Drawing.Size(768, 407);
            this.tabPage_Announce.TabIndex = 0;
            this.tabPage_Announce.Text = "已收公告";
            this.tabPage_Announce.UseVisualStyleBackColor = true;
            // 
            // tabPage_Message
            // 
            this.tabPage_Message.Controls.Add(this.listBoxMessage);
            this.tabPage_Message.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Message.Name = "tabPage_Message";
            this.tabPage_Message.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Message.Size = new System.Drawing.Size(768, 407);
            this.tabPage_Message.TabIndex = 1;
            this.tabPage_Message.Text = "已收留言";
            this.tabPage_Message.UseVisualStyleBackColor = true;
            // 
            // listBoxMessage
            // 
            this.listBoxMessage.FormattingEnabled = true;
            this.listBoxMessage.ItemHeight = 15;
            this.listBoxMessage.Location = new System.Drawing.Point(6, 6);
            this.listBoxMessage.Name = "listBoxMessage";
            this.listBoxMessage.Size = new System.Drawing.Size(756, 394);
            this.listBoxMessage.TabIndex = 1;
            // 
            // tabPage_SecurityQuestion
            // 
            this.tabPage_SecurityQuestion.Controls.Add(this.button_ResetImformation);
            this.tabPage_SecurityQuestion.Controls.Add(this.button_SaveImformation);
            this.tabPage_SecurityQuestion.Controls.Add(this.label_Warning);
            this.tabPage_SecurityQuestion.Controls.Add(this.textBox_SecondAnswer);
            this.tabPage_SecurityQuestion.Controls.Add(this.textBox_SecondQuestion);
            this.tabPage_SecurityQuestion.Controls.Add(this.textBox_FirstAnswer);
            this.tabPage_SecurityQuestion.Controls.Add(this.textBox_FirstQuestion);
            this.tabPage_SecurityQuestion.Controls.Add(this.textBox_Name);
            this.tabPage_SecurityQuestion.Controls.Add(this.label_Answer2);
            this.tabPage_SecurityQuestion.Controls.Add(this.label_Question2);
            this.tabPage_SecurityQuestion.Controls.Add(this.label_Answer1);
            this.tabPage_SecurityQuestion.Controls.Add(this.label_Question1);
            this.tabPage_SecurityQuestion.Controls.Add(this.label_Name);
            this.tabPage_SecurityQuestion.Controls.Add(this.label_Account);
            this.tabPage_SecurityQuestion.Controls.Add(this.textBox_Account);
            this.tabPage_SecurityQuestion.Location = new System.Drawing.Point(4, 25);
            this.tabPage_SecurityQuestion.Name = "tabPage_SecurityQuestion";
            this.tabPage_SecurityQuestion.Size = new System.Drawing.Size(768, 407);
            this.tabPage_SecurityQuestion.TabIndex = 2;
            this.tabPage_SecurityQuestion.Text = "设置密保问题";
            this.tabPage_SecurityQuestion.UseVisualStyleBackColor = true;
            // 
            // button_ResetImformation
            // 
            this.button_ResetImformation.Location = new System.Drawing.Point(455, 318);
            this.button_ResetImformation.Name = "button_ResetImformation";
            this.button_ResetImformation.Size = new System.Drawing.Size(90, 31);
            this.button_ResetImformation.TabIndex = 20;
            this.button_ResetImformation.Text = "重置";
            this.button_ResetImformation.UseVisualStyleBackColor = true;
            this.button_ResetImformation.Click += new System.EventHandler(this.button_ResetImformation_Click);
            // 
            // button_SaveImformation
            // 
            this.button_SaveImformation.Location = new System.Drawing.Point(223, 318);
            this.button_SaveImformation.Name = "button_SaveImformation";
            this.button_SaveImformation.Size = new System.Drawing.Size(90, 31);
            this.button_SaveImformation.TabIndex = 19;
            this.button_SaveImformation.Text = "保存";
            this.button_SaveImformation.UseVisualStyleBackColor = true;
            this.button_SaveImformation.Click += new System.EventHandler(this.button_SaveImformation_Click);
            // 
            // label_Warning
            // 
            this.label_Warning.ForeColor = System.Drawing.Color.Red;
            this.label_Warning.Location = new System.Drawing.Point(586, 112);
            this.label_Warning.Name = "label_Warning";
            this.label_Warning.Size = new System.Drawing.Size(110, 25);
            this.label_Warning.TabIndex = 18;
            this.label_Warning.Text = "*必填";
            // 
            // textBox_SecondAnswer
            // 
            this.textBox_SecondAnswer.Location = new System.Drawing.Point(267, 261);
            this.textBox_SecondAnswer.Name = "textBox_SecondAnswer";
            this.textBox_SecondAnswer.Size = new System.Drawing.Size(291, 25);
            this.textBox_SecondAnswer.TabIndex = 16;
            // 
            // textBox_SecondQuestion
            // 
            this.textBox_SecondQuestion.Location = new System.Drawing.Point(267, 223);
            this.textBox_SecondQuestion.Name = "textBox_SecondQuestion";
            this.textBox_SecondQuestion.Size = new System.Drawing.Size(291, 25);
            this.textBox_SecondQuestion.TabIndex = 15;
            // 
            // textBox_FirstAnswer
            // 
            this.textBox_FirstAnswer.Location = new System.Drawing.Point(267, 185);
            this.textBox_FirstAnswer.Name = "textBox_FirstAnswer";
            this.textBox_FirstAnswer.Size = new System.Drawing.Size(291, 25);
            this.textBox_FirstAnswer.TabIndex = 14;
            // 
            // textBox_FirstQuestion
            // 
            this.textBox_FirstQuestion.Location = new System.Drawing.Point(267, 147);
            this.textBox_FirstQuestion.Name = "textBox_FirstQuestion";
            this.textBox_FirstQuestion.Size = new System.Drawing.Size(291, 25);
            this.textBox_FirstQuestion.TabIndex = 13;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(267, 109);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(291, 25);
            this.textBox_Name.TabIndex = 12;
            // 
            // label_Answer2
            // 
            this.label_Answer2.Location = new System.Drawing.Point(110, 261);
            this.label_Answer2.Name = "label_Answer2";
            this.label_Answer2.Size = new System.Drawing.Size(106, 25);
            this.label_Answer2.TabIndex = 11;
            this.label_Answer2.Text = "回答2：";
            // 
            // label_Question2
            // 
            this.label_Question2.Location = new System.Drawing.Point(110, 223);
            this.label_Question2.Name = "label_Question2";
            this.label_Question2.Size = new System.Drawing.Size(122, 25);
            this.label_Question2.TabIndex = 10;
            this.label_Question2.Text = "密码保护问题2：";
            // 
            // label_Answer1
            // 
            this.label_Answer1.Location = new System.Drawing.Point(110, 185);
            this.label_Answer1.Name = "label_Answer1";
            this.label_Answer1.Size = new System.Drawing.Size(106, 25);
            this.label_Answer1.TabIndex = 9;
            this.label_Answer1.Text = "回答1：";
            // 
            // label_Question1
            // 
            this.label_Question1.Location = new System.Drawing.Point(110, 147);
            this.label_Question1.Name = "label_Question1";
            this.label_Question1.Size = new System.Drawing.Size(124, 25);
            this.label_Question1.TabIndex = 8;
            this.label_Question1.Text = "密码保护问题1：";
            // 
            // label_Name
            // 
            this.label_Name.Location = new System.Drawing.Point(110, 109);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(106, 25);
            this.label_Name.TabIndex = 7;
            this.label_Name.Text = "真实名字：";
            // 
            // label_Account
            // 
            this.label_Account.Location = new System.Drawing.Point(110, 71);
            this.label_Account.Name = "label_Account";
            this.label_Account.Size = new System.Drawing.Size(106, 25);
            this.label_Account.TabIndex = 6;
            this.label_Account.Text = "登陆账号：";
            // 
            // textBox_Account
            // 
            this.textBox_Account.Location = new System.Drawing.Point(267, 71);
            this.textBox_Account.Name = "textBox_Account";
            this.textBox_Account.ReadOnly = true;
            this.textBox_Account.Size = new System.Drawing.Size(291, 25);
            this.textBox_Account.TabIndex = 5;
            // 
            // tabPage_ChangeCode
            // 
            this.tabPage_ChangeCode.Controls.Add(this.button_ResetPassword);
            this.tabPage_ChangeCode.Controls.Add(this.button_SavePassword);
            this.tabPage_ChangeCode.Controls.Add(this.label_ThirdWarning);
            this.tabPage_ChangeCode.Controls.Add(this.label_SecondWarning);
            this.tabPage_ChangeCode.Controls.Add(this.label_FirstWarning);
            this.tabPage_ChangeCode.Controls.Add(this.label_CheekPassword);
            this.tabPage_ChangeCode.Controls.Add(this.label_NewPassword);
            this.tabPage_ChangeCode.Controls.Add(this.label_OldPassword);
            this.tabPage_ChangeCode.Controls.Add(this.label_Accountment);
            this.tabPage_ChangeCode.Controls.Add(this.textBox_CheekPassword);
            this.tabPage_ChangeCode.Controls.Add(this.textBox_NewPassword);
            this.tabPage_ChangeCode.Controls.Add(this.textBox_OldPassword);
            this.tabPage_ChangeCode.Controls.Add(this.textBox_Accounment);
            this.tabPage_ChangeCode.Location = new System.Drawing.Point(4, 25);
            this.tabPage_ChangeCode.Name = "tabPage_ChangeCode";
            this.tabPage_ChangeCode.Size = new System.Drawing.Size(768, 407);
            this.tabPage_ChangeCode.TabIndex = 3;
            this.tabPage_ChangeCode.Text = "重新设置密码";
            this.tabPage_ChangeCode.UseVisualStyleBackColor = true;
            // 
            // button_ResetPassword
            // 
            this.button_ResetPassword.Location = new System.Drawing.Point(394, 309);
            this.button_ResetPassword.Name = "button_ResetPassword";
            this.button_ResetPassword.Size = new System.Drawing.Size(77, 32);
            this.button_ResetPassword.TabIndex = 12;
            this.button_ResetPassword.Text = "重置";
            this.button_ResetPassword.UseVisualStyleBackColor = true;
            this.button_ResetPassword.Click += new System.EventHandler(this.button_ResetPassword_Click);
            // 
            // button_SavePassword
            // 
            this.button_SavePassword.Location = new System.Drawing.Point(225, 309);
            this.button_SavePassword.Name = "button_SavePassword";
            this.button_SavePassword.Size = new System.Drawing.Size(77, 32);
            this.button_SavePassword.TabIndex = 11;
            this.button_SavePassword.Text = "保存";
            this.button_SavePassword.UseVisualStyleBackColor = true;
            this.button_SavePassword.Click += new System.EventHandler(this.button_SavePassword_Click);
            // 
            // label_ThirdWarning
            // 
            this.label_ThirdWarning.ForeColor = System.Drawing.Color.Red;
            this.label_ThirdWarning.Location = new System.Drawing.Point(554, 241);
            this.label_ThirdWarning.Name = "label_ThirdWarning";
            this.label_ThirdWarning.Size = new System.Drawing.Size(110, 25);
            this.label_ThirdWarning.TabIndex = 10;
            this.label_ThirdWarning.Text = "*必填";
            // 
            // label_SecondWarning
            // 
            this.label_SecondWarning.ForeColor = System.Drawing.Color.Red;
            this.label_SecondWarning.Location = new System.Drawing.Point(554, 180);
            this.label_SecondWarning.Name = "label_SecondWarning";
            this.label_SecondWarning.Size = new System.Drawing.Size(110, 25);
            this.label_SecondWarning.TabIndex = 9;
            this.label_SecondWarning.Text = "*必填";
            // 
            // label_FirstWarning
            // 
            this.label_FirstWarning.ForeColor = System.Drawing.Color.Red;
            this.label_FirstWarning.Location = new System.Drawing.Point(554, 122);
            this.label_FirstWarning.Name = "label_FirstWarning";
            this.label_FirstWarning.Size = new System.Drawing.Size(110, 25);
            this.label_FirstWarning.TabIndex = 8;
            this.label_FirstWarning.Text = "*必填";
            // 
            // label_CheekPassword
            // 
            this.label_CheekPassword.Location = new System.Drawing.Point(86, 238);
            this.label_CheekPassword.Name = "label_CheekPassword";
            this.label_CheekPassword.Size = new System.Drawing.Size(110, 25);
            this.label_CheekPassword.TabIndex = 7;
            this.label_CheekPassword.Text = "确认新密码：";
            // 
            // label_NewPassword
            // 
            this.label_NewPassword.Location = new System.Drawing.Point(86, 180);
            this.label_NewPassword.Name = "label_NewPassword";
            this.label_NewPassword.Size = new System.Drawing.Size(110, 25);
            this.label_NewPassword.TabIndex = 6;
            this.label_NewPassword.Text = "新密码：";
            // 
            // label_OldPassword
            // 
            this.label_OldPassword.Location = new System.Drawing.Point(86, 122);
            this.label_OldPassword.Name = "label_OldPassword";
            this.label_OldPassword.Size = new System.Drawing.Size(110, 25);
            this.label_OldPassword.TabIndex = 5;
            this.label_OldPassword.Text = "旧密码:";
            // 
            // label_Accountment
            // 
            this.label_Accountment.Location = new System.Drawing.Point(86, 64);
            this.label_Accountment.Name = "label_Accountment";
            this.label_Accountment.Size = new System.Drawing.Size(110, 25);
            this.label_Accountment.TabIndex = 4;
            this.label_Accountment.Text = "登陆账号：";
            // 
            // textBox_CheekPassword
            // 
            this.textBox_CheekPassword.Location = new System.Drawing.Point(239, 238);
            this.textBox_CheekPassword.Name = "textBox_CheekPassword";
            this.textBox_CheekPassword.PasswordChar = '*';
            this.textBox_CheekPassword.Size = new System.Drawing.Size(291, 25);
            this.textBox_CheekPassword.TabIndex = 3;
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Location = new System.Drawing.Point(239, 180);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.PasswordChar = '*';
            this.textBox_NewPassword.Size = new System.Drawing.Size(291, 25);
            this.textBox_NewPassword.TabIndex = 2;
            // 
            // textBox_OldPassword
            // 
            this.textBox_OldPassword.Location = new System.Drawing.Point(239, 122);
            this.textBox_OldPassword.Name = "textBox_OldPassword";
            this.textBox_OldPassword.PasswordChar = '*';
            this.textBox_OldPassword.Size = new System.Drawing.Size(291, 25);
            this.textBox_OldPassword.TabIndex = 1;
            // 
            // textBox_Accounment
            // 
            this.textBox_Accounment.Location = new System.Drawing.Point(239, 64);
            this.textBox_Accounment.Name = "textBox_Accounment";
            this.textBox_Accounment.ReadOnly = true;
            this.textBox_Accounment.Size = new System.Drawing.Size(291, 25);
            this.textBox_Accounment.TabIndex = 0;
            // 
            // tabPage_WeeklyCalendar
            // 
            this.tabPage_WeeklyCalendar.Controls.Add(this.TeachingmonthCalendar);
            this.tabPage_WeeklyCalendar.Location = new System.Drawing.Point(4, 25);
            this.tabPage_WeeklyCalendar.Name = "tabPage_WeeklyCalendar";
            this.tabPage_WeeklyCalendar.Size = new System.Drawing.Size(768, 407);
            this.tabPage_WeeklyCalendar.TabIndex = 4;
            this.tabPage_WeeklyCalendar.Text = "教学周历";
            this.tabPage_WeeklyCalendar.UseVisualStyleBackColor = true;
            // 
            // TeachingmonthCalendar
            // 
            this.TeachingmonthCalendar.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.TeachingmonthCalendar.Location = new System.Drawing.Point(-4, 0);
            this.TeachingmonthCalendar.Name = "TeachingmonthCalendar";
            this.TeachingmonthCalendar.TabIndex = 0;
            // 
            // dgv_Message
            // 
            this.dgv_Message.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Message.Location = new System.Drawing.Point(0, 0);
            this.dgv_Message.Name = "dgv_Message";
            this.dgv_Message.RowTemplate.Height = 27;
            this.dgv_Message.Size = new System.Drawing.Size(768, 404);
            this.dgv_Message.TabIndex = 0;
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 469);
            this.Controls.Add(this.tabControlDesktop);
            this.Name = "DesktopForm";
            this.Text = "我的桌面";
            this.tabControlDesktop.ResumeLayout(false);
            this.tabPage_Announce.ResumeLayout(false);
            this.tabPage_Message.ResumeLayout(false);
            this.tabPage_SecurityQuestion.ResumeLayout(false);
            this.tabPage_SecurityQuestion.PerformLayout();
            this.tabPage_ChangeCode.ResumeLayout(false);
            this.tabPage_ChangeCode.PerformLayout();
            this.tabPage_WeeklyCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Message)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDesktop;
        private System.Windows.Forms.TabPage tabPage_Announce;
        private System.Windows.Forms.TabPage tabPage_Message;
        private System.Windows.Forms.TabPage tabPage_SecurityQuestion;
        private System.Windows.Forms.TabPage tabPage_ChangeCode;
        private System.Windows.Forms.TabPage tabPage_WeeklyCalendar;
        private System.Windows.Forms.Label label_ThirdWarning;
        private System.Windows.Forms.Label label_SecondWarning;
        private System.Windows.Forms.Label label_FirstWarning;
        private System.Windows.Forms.Label label_CheekPassword;
        private System.Windows.Forms.Label label_NewPassword;
        private System.Windows.Forms.Label label_OldPassword;
        private System.Windows.Forms.Label label_Accountment;
        private System.Windows.Forms.TextBox textBox_CheekPassword;
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.TextBox textBox_OldPassword;
        private System.Windows.Forms.TextBox textBox_Accounment;
        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.TextBox textBox_Account;
        private System.Windows.Forms.Label label_Question2;
        private System.Windows.Forms.Label label_Answer1;
        private System.Windows.Forms.Label label_Question1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Answer2;
        private System.Windows.Forms.Label label_Warning;
        private System.Windows.Forms.TextBox textBox_SecondAnswer;
        private System.Windows.Forms.TextBox textBox_SecondQuestion;
        private System.Windows.Forms.TextBox textBox_FirstAnswer;
        private System.Windows.Forms.TextBox textBox_FirstQuestion;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_ResetPassword;
        private System.Windows.Forms.Button button_SavePassword;
        private System.Windows.Forms.Button button_ResetImformation;
        private System.Windows.Forms.Button button_SaveImformation;
        private System.Windows.Forms.ListBox listBoxMessage;
        private System.Windows.Forms.MonthCalendar TeachingmonthCalendar;
        private System.Windows.Forms.DataGridView dgv_Message;
    }
}