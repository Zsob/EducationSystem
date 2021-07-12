namespace Education_System
{
    partial class TeachingEvaluation
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
            this.dgv_Evaluate = new System.Windows.Forms.DataGridView();
            this.gbx_Teaching = new System.Windows.Forms.GroupBox();
            this.gbx_Evaluate = new System.Windows.Forms.GroupBox();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.radioButton_5Point = new System.Windows.Forms.RadioButton();
            this.radioButton_4Point = new System.Windows.Forms.RadioButton();
            this.radioButton_3Point = new System.Windows.Forms.RadioButton();
            this.radioButton_2Point = new System.Windows.Forms.RadioButton();
            this.radioButton_1Point = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Evaluate)).BeginInit();
            this.gbx_Teaching.SuspendLayout();
            this.gbx_Evaluate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Evaluate
            // 
            this.dgv_Evaluate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Evaluate.Location = new System.Drawing.Point(6, 24);
            this.dgv_Evaluate.Name = "dgv_Evaluate";
            this.dgv_Evaluate.RowTemplate.Height = 27;
            this.dgv_Evaluate.Size = new System.Drawing.Size(712, 391);
            this.dgv_Evaluate.TabIndex = 0;
            this.dgv_Evaluate.DoubleClick += new System.EventHandler(this.dgv_Evaluate_DoubleClick);
            // 
            // gbx_Teaching
            // 
            this.gbx_Teaching.Controls.Add(this.dgv_Evaluate);
            this.gbx_Teaching.Location = new System.Drawing.Point(71, 0);
            this.gbx_Teaching.Name = "gbx_Teaching";
            this.gbx_Teaching.Size = new System.Drawing.Size(746, 442);
            this.gbx_Teaching.TabIndex = 1;
            this.gbx_Teaching.TabStop = false;
            // 
            // gbx_Evaluate
            // 
            this.gbx_Evaluate.Controls.Add(this.btn_GoBack);
            this.gbx_Evaluate.Controls.Add(this.gbx_Teaching);
            this.gbx_Evaluate.Controls.Add(this.btn_Submit);
            this.gbx_Evaluate.Controls.Add(this.lbl_Title);
            this.gbx_Evaluate.Controls.Add(this.radioButton_5Point);
            this.gbx_Evaluate.Controls.Add(this.radioButton_4Point);
            this.gbx_Evaluate.Controls.Add(this.radioButton_3Point);
            this.gbx_Evaluate.Controls.Add(this.radioButton_2Point);
            this.gbx_Evaluate.Controls.Add(this.radioButton_1Point);
            this.gbx_Evaluate.Location = new System.Drawing.Point(26, 9);
            this.gbx_Evaluate.Name = "gbx_Evaluate";
            this.gbx_Evaluate.Size = new System.Drawing.Size(746, 442);
            this.gbx_Evaluate.TabIndex = 2;
            this.gbx_Evaluate.TabStop = false;
            this.gbx_Evaluate.Visible = false;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_GoBack.Location = new System.Drawing.Point(440, 367);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(108, 42);
            this.btn_GoBack.TabIndex = 7;
            this.btn_GoBack.Text = "返回";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Submit.Location = new System.Drawing.Point(440, 297);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(108, 42);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.Location = new System.Drawing.Point(45, 113);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(0, 24);
            this.lbl_Title.TabIndex = 5;
            // 
            // radioButton_5Point
            // 
            this.radioButton_5Point.AutoSize = true;
            this.radioButton_5Point.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_5Point.Location = new System.Drawing.Point(45, 381);
            this.radioButton_5Point.Name = "radioButton_5Point";
            this.radioButton_5Point.Size = new System.Drawing.Size(67, 28);
            this.radioButton_5Point.TabIndex = 4;
            this.radioButton_5Point.TabStop = true;
            this.radioButton_5Point.Text = "5分";
            this.radioButton_5Point.UseVisualStyleBackColor = true;
            this.radioButton_5Point.CheckedChanged += new System.EventHandler(this.radioButton_5Point_CheckedChanged);
            // 
            // radioButton_4Point
            // 
            this.radioButton_4Point.AutoSize = true;
            this.radioButton_4Point.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_4Point.Location = new System.Drawing.Point(45, 339);
            this.radioButton_4Point.Name = "radioButton_4Point";
            this.radioButton_4Point.Size = new System.Drawing.Size(67, 28);
            this.radioButton_4Point.TabIndex = 3;
            this.radioButton_4Point.TabStop = true;
            this.radioButton_4Point.Text = "4分";
            this.radioButton_4Point.UseVisualStyleBackColor = true;
            this.radioButton_4Point.CheckedChanged += new System.EventHandler(this.radioButton_4Point_CheckedChanged);
            // 
            // radioButton_3Point
            // 
            this.radioButton_3Point.AutoSize = true;
            this.radioButton_3Point.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_3Point.Location = new System.Drawing.Point(45, 297);
            this.radioButton_3Point.Name = "radioButton_3Point";
            this.radioButton_3Point.Size = new System.Drawing.Size(67, 28);
            this.radioButton_3Point.TabIndex = 2;
            this.radioButton_3Point.TabStop = true;
            this.radioButton_3Point.Text = "3分";
            this.radioButton_3Point.UseVisualStyleBackColor = true;
            this.radioButton_3Point.CheckedChanged += new System.EventHandler(this.radioButton_3Point_CheckedChanged);
            // 
            // radioButton_2Point
            // 
            this.radioButton_2Point.AutoSize = true;
            this.radioButton_2Point.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_2Point.Location = new System.Drawing.Point(45, 255);
            this.radioButton_2Point.Name = "radioButton_2Point";
            this.radioButton_2Point.Size = new System.Drawing.Size(67, 28);
            this.radioButton_2Point.TabIndex = 1;
            this.radioButton_2Point.TabStop = true;
            this.radioButton_2Point.Text = "2分";
            this.radioButton_2Point.UseVisualStyleBackColor = true;
            this.radioButton_2Point.CheckedChanged += new System.EventHandler(this.radioButton_2Point_CheckedChanged);
            // 
            // radioButton_1Point
            // 
            this.radioButton_1Point.AutoSize = true;
            this.radioButton_1Point.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_1Point.Location = new System.Drawing.Point(45, 213);
            this.radioButton_1Point.Name = "radioButton_1Point";
            this.radioButton_1Point.Size = new System.Drawing.Size(67, 28);
            this.radioButton_1Point.TabIndex = 0;
            this.radioButton_1Point.TabStop = true;
            this.radioButton_1Point.Text = "1分";
            this.radioButton_1Point.UseVisualStyleBackColor = true;
            this.radioButton_1Point.CheckedChanged += new System.EventHandler(this.radioButton_1Point_CheckedChanged);
            // 
            // TeachingEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 469);
            this.Controls.Add(this.gbx_Evaluate);
            this.Name = "TeachingEvaluation";
            this.Text = "教学评价";
            this.Load += new System.EventHandler(this.TeachingEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Evaluate)).EndInit();
            this.gbx_Teaching.ResumeLayout(false);
            this.gbx_Evaluate.ResumeLayout(false);
            this.gbx_Evaluate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Evaluate;
        private System.Windows.Forms.GroupBox gbx_Teaching;
        private System.Windows.Forms.GroupBox gbx_Evaluate;
        private System.Windows.Forms.RadioButton radioButton_5Point;
        private System.Windows.Forms.RadioButton radioButton_4Point;
        private System.Windows.Forms.RadioButton radioButton_3Point;
        private System.Windows.Forms.RadioButton radioButton_2Point;
        private System.Windows.Forms.RadioButton radioButton_1Point;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_GoBack;
    }
}