namespace Evaluation_Manager
{
    partial class FrmEvaluation
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
            this.lblActivities = new System.Windows.Forms.Label();
            this.lblMinForSignature = new System.Windows.Forms.Label();
            this.lblMinForGrade = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblBodovi = new System.Windows.Forms.Label();
            this.lblEvaluationDate = new System.Windows.Forms.Label();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.txtActivityDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Location = new System.Drawing.Point(22, 19);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(54, 13);
            this.lblActivities.TabIndex = 0;
            this.lblActivities.Text = "Aktivnost:";
            this.lblActivities.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMinForSignature
            // 
            this.lblMinForSignature.AutoSize = true;
            this.lblMinForSignature.Location = new System.Drawing.Point(354, 19);
            this.lblMinForSignature.Name = "lblMinForSignature";
            this.lblMinForSignature.Size = new System.Drawing.Size(80, 13);
            this.lblMinForSignature.TabIndex = 1;
            this.lblMinForSignature.Text = "Uvjet za potpis:";
            this.lblMinForSignature.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMinForGrade
            // 
            this.lblMinForGrade.AutoSize = true;
            this.lblMinForGrade.Location = new System.Drawing.Point(513, 19);
            this.lblMinForGrade.Name = "lblMinForGrade";
            this.lblMinForGrade.Size = new System.Drawing.Size(84, 13);
            this.lblMinForGrade.TabIndex = 2;
            this.lblMinForGrade.Text = "Uvjet za ocjenu:";
            this.lblMinForGrade.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(245, 301);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(60, 13);
            this.lblTeacher.TabIndex = 3;
            this.lblTeacher.Text = "Ocjenjivač:";
            // 
            // lblBodovi
            // 
            this.lblBodovi.AutoSize = true;
            this.lblBodovi.Location = new System.Drawing.Point(532, 301);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(43, 13);
            this.lblBodovi.TabIndex = 4;
            this.lblBodovi.Text = "Bodovi:";
            this.lblBodovi.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblEvaluationDate
            // 
            this.lblEvaluationDate.AutoSize = true;
            this.lblEvaluationDate.Location = new System.Drawing.Point(381, 301);
            this.lblEvaluationDate.Name = "lblEvaluationDate";
            this.lblEvaluationDate.Size = new System.Drawing.Size(92, 13);
            this.lblEvaluationDate.TabIndex = 5;
            this.lblEvaluationDate.Text = "Datum evaluacije:";
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(357, 35);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.Size = new System.Drawing.Size(100, 20);
            this.txtMinForSignature.TabIndex = 6;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(516, 35);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.Size = new System.Drawing.Size(100, 20);
            this.txtMinForGrade.TabIndex = 7;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(248, 317);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtTeacher.TabIndex = 8;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(384, 317);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.Size = new System.Drawing.Size(100, 20);
            this.txtEvaluationDate.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(439, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(541, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(25, 35);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(121, 21);
            this.cboActivities.TabIndex = 12;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(535, 317);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(88, 20);
            this.numPoints.TabIndex = 13;
            this.numPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(25, 91);
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(591, 182);
            this.txtActivityDescription.TabIndex = 14;
            this.txtActivityDescription.Text = "";
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 397);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.lblEvaluationDate);
            this.Controls.Add(this.lblBodovi);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblMinForGrade);
            this.Controls.Add(this.lblMinForSignature);
            this.Controls.Add(this.lblActivities);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.Label lblMinForSignature;
        private System.Windows.Forms.Label lblMinForGrade;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblBodovi;
        private System.Windows.Forms.Label lblEvaluationDate;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.RichTextBox txtActivityDescription;
    }
}