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
            this.dataGridViewTeachingEvaluation = new System.Windows.Forms.DataGridView();
            this.ColumnSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOperating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachingEvaluation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeachingEvaluation
            // 
            this.dataGridViewTeachingEvaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachingEvaluation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSerialNumber,
            this.ColumnTerm,
            this.ColumnClassification,
            this.ColumnBatch,
            this.ColumnStartTime,
            this.ColumnFinishTime,
            this.ColumnOperating});
            this.dataGridViewTeachingEvaluation.Location = new System.Drawing.Point(28, 12);
            this.dataGridViewTeachingEvaluation.Name = "dataGridViewTeachingEvaluation";
            this.dataGridViewTeachingEvaluation.RowTemplate.Height = 27;
            this.dataGridViewTeachingEvaluation.Size = new System.Drawing.Size(744, 434);
            this.dataGridViewTeachingEvaluation.TabIndex = 0;
            // 
            // ColumnSerialNumber
            // 
            this.ColumnSerialNumber.HeaderText = "序号";
            this.ColumnSerialNumber.Name = "ColumnSerialNumber";
            // 
            // ColumnTerm
            // 
            this.ColumnTerm.HeaderText = "学年学期";
            this.ColumnTerm.Name = "ColumnTerm";
            // 
            // ColumnClassification
            // 
            this.ColumnClassification.HeaderText = "评教分类";
            this.ColumnClassification.Name = "ColumnClassification";
            // 
            // ColumnBatch
            // 
            this.ColumnBatch.HeaderText = "评教批次";
            this.ColumnBatch.Name = "ColumnBatch";
            // 
            // ColumnStartTime
            // 
            this.ColumnStartTime.HeaderText = "开始时间";
            this.ColumnStartTime.Name = "ColumnStartTime";
            // 
            // ColumnFinishTime
            // 
            this.ColumnFinishTime.HeaderText = "结束时间";
            this.ColumnFinishTime.Name = "ColumnFinishTime";
            // 
            // ColumnOperating
            // 
            this.ColumnOperating.HeaderText = "操作";
            this.ColumnOperating.Name = "ColumnOperating";
            // 
            // TeachingEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTeachingEvaluation);
            this.Name = "TeachingEvaluation";
            this.Text = "教学评价";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachingEvaluation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTeachingEvaluation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFinishTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOperating;
    }
}