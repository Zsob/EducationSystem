namespace Education_System
{
    partial class SignUp
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
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.txt_StudentNo = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_StudentNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(120, 165);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(86, 32);
            this.btn_SignUp.TabIndex = 11;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Location = new System.Drawing.Point(103, 97);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(202, 25);
            this.txt_PassWord.TabIndex = 9;
            this.txt_PassWord.UseSystemPasswordChar = true;
            // 
            // txt_StudentNo
            // 
            this.txt_StudentNo.Location = new System.Drawing.Point(103, 38);
            this.txt_StudentNo.Name = "txt_StudentNo";
            this.txt_StudentNo.Size = new System.Drawing.Size(202, 25);
            this.txt_StudentNo.TabIndex = 8;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.Location = new System.Drawing.Point(32, 97);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(76, 42);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "密码：";
            // 
            // lbl_StudentNo
            // 
            this.lbl_StudentNo.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_StudentNo.Location = new System.Drawing.Point(32, 39);
            this.lbl_StudentNo.Name = "lbl_StudentNo";
            this.lbl_StudentNo.Size = new System.Drawing.Size(76, 37);
            this.lbl_StudentNo.TabIndex = 6;
            this.lbl_StudentNo.Text = "学号：";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 240);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.txt_StudentNo);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_StudentNo);
            this.Name = "SignUp";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.TextBox txt_StudentNo;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_StudentNo;
    }
}