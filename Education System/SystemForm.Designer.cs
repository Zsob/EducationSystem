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
            this.SuspendLayout();
            // 
            // textBox_Acountment
            // 
            this.textBox_Acountment.Location = new System.Drawing.Point(33, 37);
            this.textBox_Acountment.Name = "textBox_Acountment";
            this.textBox_Acountment.ReadOnly = true;
            this.textBox_Acountment.Size = new System.Drawing.Size(211, 25);
            this.textBox_Acountment.TabIndex = 0;
            this.textBox_Acountment.Text = "未登录";
            // 
            // bt_Desktop
            // 
            this.bt_Desktop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Desktop.Location = new System.Drawing.Point(145, 130);
            this.bt_Desktop.Name = "bt_Desktop";
            this.bt_Desktop.Size = new System.Drawing.Size(181, 118);
            this.bt_Desktop.TabIndex = 1;
            this.bt_Desktop.Text = "我的桌面";
            this.bt_Desktop.UseVisualStyleBackColor = true;
            this.bt_Desktop.Click += new System.EventHandler(this.bt_Desktop_Click);
            // 
            // bt_Grade
            // 
            this.bt_Grade.Location = new System.Drawing.Point(427, 130);
            this.bt_Grade.Name = "bt_Grade";
            this.bt_Grade.Size = new System.Drawing.Size(181, 118);
            this.bt_Grade.TabIndex = 2;
            this.bt_Grade.Text = "学籍成绩";
            this.bt_Grade.UseVisualStyleBackColor = true;
            this.bt_Grade.Click += new System.EventHandler(this.bt_Grade_Click);
            // 
            // bt_Management
            // 
            this.bt_Management.Location = new System.Drawing.Point(709, 130);
            this.bt_Management.Name = "bt_Management";
            this.bt_Management.Size = new System.Drawing.Size(181, 118);
            this.bt_Management.TabIndex = 3;
            this.bt_Management.Text = "培养管理";
            this.bt_Management.UseVisualStyleBackColor = true;
            this.bt_Management.Click += new System.EventHandler(this.bt_Management_Click);
            // 
            // bt_ExamRegistration
            // 
            this.bt_ExamRegistration.Location = new System.Drawing.Point(145, 346);
            this.bt_ExamRegistration.Name = "bt_ExamRegistration";
            this.bt_ExamRegistration.Size = new System.Drawing.Size(181, 118);
            this.bt_ExamRegistration.TabIndex = 4;
            this.bt_ExamRegistration.Text = "考试报名";
            this.bt_ExamRegistration.UseVisualStyleBackColor = true;
            this.bt_ExamRegistration.Click += new System.EventHandler(this.bt_ExamRegistration_Click);
            // 
            // bt_Practice
            // 
            this.bt_Practice.Location = new System.Drawing.Point(427, 346);
            this.bt_Practice.Name = "bt_Practice";
            this.bt_Practice.Size = new System.Drawing.Size(181, 118);
            this.bt_Practice.TabIndex = 5;
            this.bt_Practice.Text = "实践环节";
            this.bt_Practice.UseVisualStyleBackColor = true;
            this.bt_Practice.Click += new System.EventHandler(this.bt_Practice_Click);
            // 
            // bt_Evaluation
            // 
            this.bt_Evaluation.Location = new System.Drawing.Point(709, 346);
            this.bt_Evaluation.Name = "bt_Evaluation";
            this.bt_Evaluation.Size = new System.Drawing.Size(181, 118);
            this.bt_Evaluation.TabIndex = 6;
            this.bt_Evaluation.Text = "教学评价";
            this.bt_Evaluation.UseVisualStyleBackColor = true;
            this.bt_Evaluation.Click += new System.EventHandler(this.bt_Evaluation_Click);
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(270, 37);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(84, 27);
            this.btn_LogIn.TabIndex = 7;
            this.btn_LogIn.Text = "登录";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(375, 37);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(84, 27);
            this.btn_LogOut.TabIndex = 8;
            this.btn_LogOut.Text = "注销";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // Form_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 620);
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
    }
}

