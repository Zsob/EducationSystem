namespace Education_System
{
    partial class LogIn
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
            this.lbl_StudentNo = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_StudentNo = new System.Windows.Forms.TextBox();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_StudentNo
            // 
            this.lbl_StudentNo.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_StudentNo.Location = new System.Drawing.Point(12, 39);
            this.lbl_StudentNo.Name = "lbl_StudentNo";
            this.lbl_StudentNo.Size = new System.Drawing.Size(76, 37);
            this.lbl_StudentNo.TabIndex = 0;
            this.lbl_StudentNo.Text = "学号：";
            // 
            // lbl_Password
            // 
            this.lbl_Password.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.Location = new System.Drawing.Point(12, 97);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(76, 42);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "密码：";
            // 
            // txt_StudentNo
            // 
            this.txt_StudentNo.Location = new System.Drawing.Point(83, 38);
            this.txt_StudentNo.Name = "txt_StudentNo";
            this.txt_StudentNo.Size = new System.Drawing.Size(202, 25);
            this.txt_StudentNo.TabIndex = 2;
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Location = new System.Drawing.Point(83, 97);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(202, 25);
            this.txt_PassWord.TabIndex = 3;
            this.txt_PassWord.UseSystemPasswordChar = true;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(83, 158);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(86, 32);
            this.btn_LogIn.TabIndex = 4;
            this.btn_LogIn.Text = "登录";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(186, 158);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(86, 32);
            this.btn_SignUp.TabIndex = 5;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 240);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.txt_StudentNo);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_StudentNo);
            this.Name = "LogIn";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StudentNo;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_StudentNo;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_SignUp;
    }
}