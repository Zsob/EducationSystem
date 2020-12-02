namespace Education_System
{
    partial class Form_System
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Acountment = new System.Windows.Forms.TextBox();
            this.bt_Desktop = new System.Windows.Forms.Button();
            this.bt_Grade = new System.Windows.Forms.Button();
            this.bt_Management = new System.Windows.Forms.Button();
            this.bt_ExamRegistration = new System.Windows.Forms.Button();
            this.bt_Practice = new System.Windows.Forms.Button();
            this.bt_Evaluation = new System.Windows.Forms.Button();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.groupBox_Information = new System.Windows.Forms.GroupBox();
            this.lbl_PhoneFill = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_BirthdayFill = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.lbl_GenderFill = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_NameFill = new System.Windows.Forms.Label();
            this.lbl_NoFill = new System.Windows.Forms.Label();
            this.lbl_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.groupBox_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Acountment
            // 
            this.textBox_Acountment.Location = new System.Drawing.Point(324, 47);
            this.textBox_Acountment.Name = "textBox_Acountment";
            this.textBox_Acountment.ReadOnly = true;
            this.textBox_Acountment.Size = new System.Drawing.Size(211, 25);
            this.textBox_Acountment.TabIndex = 0;
            this.textBox_Acountment.Text = "未登录";
            // 
            // bt_Desktop
            // 
            this.bt_Desktop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Desktop.Location = new System.Drawing.Point(363, 154);
            this.bt_Desktop.Name = "bt_Desktop";
            this.bt_Desktop.Size = new System.Drawing.Size(181, 118);
            this.bt_Desktop.TabIndex = 1;
            this.bt_Desktop.Text = "我的桌面";
            this.bt_Desktop.UseVisualStyleBackColor = true;
            this.bt_Desktop.Click += new System.EventHandler(this.bt_Desktop_Click);
            // 
            // bt_Grade
            // 
            this.bt_Grade.Location = new System.Drawing.Point(561, 154);
            this.bt_Grade.Name = "bt_Grade";
            this.bt_Grade.Size = new System.Drawing.Size(181, 118);
            this.bt_Grade.TabIndex = 2;
            this.bt_Grade.Text = "学籍成绩";
            this.bt_Grade.UseVisualStyleBackColor = true;
            this.bt_Grade.Click += new System.EventHandler(this.bt_Grade_Click);
            // 
            // bt_Management
            // 
            this.bt_Management.Location = new System.Drawing.Point(764, 154);
            this.bt_Management.Name = "bt_Management";
            this.bt_Management.Size = new System.Drawing.Size(181, 118);
            this.bt_Management.TabIndex = 3;
            this.bt_Management.Text = "培养管理";
            this.bt_Management.UseVisualStyleBackColor = true;
            this.bt_Management.Click += new System.EventHandler(this.bt_Management_Click);
            // 
            // bt_ExamRegistration
            // 
            this.bt_ExamRegistration.Location = new System.Drawing.Point(363, 319);
            this.bt_ExamRegistration.Name = "bt_ExamRegistration";
            this.bt_ExamRegistration.Size = new System.Drawing.Size(181, 118);
            this.bt_ExamRegistration.TabIndex = 4;
            this.bt_ExamRegistration.Text = "考试报名";
            this.bt_ExamRegistration.UseVisualStyleBackColor = true;
            this.bt_ExamRegistration.Click += new System.EventHandler(this.bt_ExamRegistration_Click);
            // 
            // bt_Practice
            // 
            this.bt_Practice.Location = new System.Drawing.Point(561, 319);
            this.bt_Practice.Name = "bt_Practice";
            this.bt_Practice.Size = new System.Drawing.Size(181, 118);
            this.bt_Practice.TabIndex = 5;
            this.bt_Practice.Text = "实践环节";
            this.bt_Practice.UseVisualStyleBackColor = true;
            this.bt_Practice.Click += new System.EventHandler(this.bt_Practice_Click);
            // 
            // bt_Evaluation
            // 
            this.bt_Evaluation.Location = new System.Drawing.Point(764, 319);
            this.bt_Evaluation.Name = "bt_Evaluation";
            this.bt_Evaluation.Size = new System.Drawing.Size(181, 118);
            this.bt_Evaluation.TabIndex = 6;
            this.bt_Evaluation.Text = "教学评价";
            this.bt_Evaluation.UseVisualStyleBackColor = true;
            this.bt_Evaluation.Click += new System.EventHandler(this.bt_Evaluation_Click);
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(561, 47);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(84, 27);
            this.btn_LogIn.TabIndex = 7;
            this.btn_LogIn.Text = "登录";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(666, 47);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(84, 27);
            this.btn_LogOut.TabIndex = 8;
            this.btn_LogOut.Text = "注销";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // groupBox_Information
            // 
            this.groupBox_Information.Controls.Add(this.lbl_PhoneFill);
            this.groupBox_Information.Controls.Add(this.lbl_Phone);
            this.groupBox_Information.Controls.Add(this.lbl_BirthdayFill);
            this.groupBox_Information.Controls.Add(this.lbl_Birthday);
            this.groupBox_Information.Controls.Add(this.lbl_GenderFill);
            this.groupBox_Information.Controls.Add(this.lbl_Gender);
            this.groupBox_Information.Controls.Add(this.lbl_NameFill);
            this.groupBox_Information.Controls.Add(this.lbl_NoFill);
            this.groupBox_Information.Controls.Add(this.lbl_No);
            this.groupBox_Information.Controls.Add(this.lbl_Name);
            this.groupBox_Information.Location = new System.Drawing.Point(37, 108);
            this.groupBox_Information.Name = "groupBox_Information";
            this.groupBox_Information.Size = new System.Drawing.Size(312, 394);
            this.groupBox_Information.TabIndex = 9;
            this.groupBox_Information.TabStop = false;
            this.groupBox_Information.Text = "个人信息";
            // 
            // lbl_PhoneFill
            // 
            this.lbl_PhoneFill.AutoSize = true;
            this.lbl_PhoneFill.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PhoneFill.Location = new System.Drawing.Point(81, 282);
            this.lbl_PhoneFill.Name = "lbl_PhoneFill";
            this.lbl_PhoneFill.Size = new System.Drawing.Size(0, 20);
            this.lbl_PhoneFill.TabIndex = 9;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Phone.Location = new System.Drawing.Point(6, 282);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(89, 20);
            this.lbl_Phone.TabIndex = 8;
            this.lbl_Phone.Text = "手机号：";
            // 
            // lbl_BirthdayFill
            // 
            this.lbl_BirthdayFill.AutoSize = true;
            this.lbl_BirthdayFill.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_BirthdayFill.Location = new System.Drawing.Point(75, 227);
            this.lbl_BirthdayFill.Name = "lbl_BirthdayFill";
            this.lbl_BirthdayFill.Size = new System.Drawing.Size(0, 20);
            this.lbl_BirthdayFill.TabIndex = 7;
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Birthday.Location = new System.Drawing.Point(6, 227);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(69, 20);
            this.lbl_Birthday.TabIndex = 6;
            this.lbl_Birthday.Text = "生日：";
            // 
            // lbl_GenderFill
            // 
            this.lbl_GenderFill.AutoSize = true;
            this.lbl_GenderFill.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_GenderFill.Location = new System.Drawing.Point(75, 168);
            this.lbl_GenderFill.Name = "lbl_GenderFill";
            this.lbl_GenderFill.Size = new System.Drawing.Size(0, 20);
            this.lbl_GenderFill.TabIndex = 5;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Gender.Location = new System.Drawing.Point(6, 168);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(69, 20);
            this.lbl_Gender.TabIndex = 4;
            this.lbl_Gender.Text = "性别：";
            // 
            // lbl_NameFill
            // 
            this.lbl_NameFill.AutoSize = true;
            this.lbl_NameFill.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_NameFill.Location = new System.Drawing.Point(75, 112);
            this.lbl_NameFill.Name = "lbl_NameFill";
            this.lbl_NameFill.Size = new System.Drawing.Size(0, 20);
            this.lbl_NameFill.TabIndex = 3;
            // 
            // lbl_NoFill
            // 
            this.lbl_NoFill.AutoSize = true;
            this.lbl_NoFill.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_NoFill.Location = new System.Drawing.Point(65, 55);
            this.lbl_NoFill.Name = "lbl_NoFill";
            this.lbl_NoFill.Size = new System.Drawing.Size(0, 20);
            this.lbl_NoFill.TabIndex = 2;
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_No.Location = new System.Drawing.Point(6, 55);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(69, 20);
            this.lbl_No.TabIndex = 1;
            this.lbl_No.Text = "学号：";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Name.Location = new System.Drawing.Point(6, 112);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(69, 20);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "姓名：";
            // 
            // Form_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 620);
            this.Controls.Add(this.groupBox_Information);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.bt_Evaluation);
            this.Controls.Add(this.bt_Practice);
            this.Controls.Add(this.bt_ExamRegistration);
            this.Controls.Add(this.bt_Management);
            this.Controls.Add(this.bt_Grade);
            this.Controls.Add(this.bt_Desktop);
            this.Controls.Add(this.textBox_Acountment);
            this.Name = "Form_System";
            this.Text = "福建中医药大学综合教务管理系统";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_System_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_System_MouseMove);
            this.groupBox_Information.ResumeLayout(false);
            this.groupBox_Information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Acountment;
        private System.Windows.Forms.Button bt_Desktop;
        private System.Windows.Forms.Button bt_Grade;
        private System.Windows.Forms.Button bt_Management;
        private System.Windows.Forms.Button bt_ExamRegistration;
        private System.Windows.Forms.Button bt_Practice;
        private System.Windows.Forms.Button bt_Evaluation;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.GroupBox groupBox_Information;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_NoFill;
        private System.Windows.Forms.Label lbl_NameFill;
        private System.Windows.Forms.Label lbl_PhoneFill;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_BirthdayFill;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Label lbl_GenderFill;
        private System.Windows.Forms.Label lbl_Gender;
    }
}

