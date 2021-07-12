namespace Education_System
{
    partial class MessageReply
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_content = new System.Windows.Forms.Label();
            this.lbl_reply = new System.Windows.Forms.Label();
            this.txt_reply = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.Location = new System.Drawing.Point(31, 29);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(87, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "标题：";
            // 
            // lbl_content
            // 
            this.lbl_content.AutoSize = true;
            this.lbl_content.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_content.Location = new System.Drawing.Point(31, 66);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(87, 25);
            this.lbl_content.TabIndex = 1;
            this.lbl_content.Text = "内容：";
            // 
            // lbl_reply
            // 
            this.lbl_reply.AutoSize = true;
            this.lbl_reply.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_reply.Location = new System.Drawing.Point(31, 147);
            this.lbl_reply.Name = "lbl_reply";
            this.lbl_reply.Size = new System.Drawing.Size(87, 25);
            this.lbl_reply.TabIndex = 2;
            this.lbl_reply.Text = "回复：";
            // 
            // txt_reply
            // 
            this.txt_reply.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_reply.Location = new System.Drawing.Point(36, 187);
            this.txt_reply.Multiline = true;
            this.txt_reply.Name = "txt_reply";
            this.txt_reply.Size = new System.Drawing.Size(900, 257);
            this.txt_reply.TabIndex = 3;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Submit.Location = new System.Drawing.Point(423, 459);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(143, 43);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // MessageReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 514);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_reply);
            this.Controls.Add(this.lbl_reply);
            this.Controls.Add(this.lbl_content);
            this.Controls.Add(this.lbl_title);
            this.Name = "MessageReply";
            this.Text = "消息回复";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.Label lbl_reply;
        private System.Windows.Forms.TextBox txt_reply;
        private System.Windows.Forms.Button btn_Submit;
    }
}