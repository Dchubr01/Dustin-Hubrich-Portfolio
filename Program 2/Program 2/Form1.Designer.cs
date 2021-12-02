namespace Program_2
{
    partial class Form1
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
            this.firstLetterLbl = new System.Windows.Forms.Label();
            this.creditHoursLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.firstLetterTxt = new System.Windows.Forms.TextBox();
            this.creditHoursTxt = new System.Windows.Forms.TextBox();
            this.dateOutputLbl = new System.Windows.Forms.Label();
            this.timeOutputLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstLetterLbl
            // 
            this.firstLetterLbl.AutoSize = true;
            this.firstLetterLbl.Location = new System.Drawing.Point(34, 30);
            this.firstLetterLbl.Name = "firstLetterLbl";
            this.firstLetterLbl.Size = new System.Drawing.Size(149, 13);
            this.firstLetterLbl.TabIndex = 0;
            this.firstLetterLbl.Text = "First Letter of Last Name (UP):";
            // 
            // creditHoursLbl
            // 
            this.creditHoursLbl.AutoSize = true;
            this.creditHoursLbl.Location = new System.Drawing.Point(34, 70);
            this.creditHoursLbl.Name = "creditHoursLbl";
            this.creditHoursLbl.Size = new System.Drawing.Size(110, 13);
            this.creditHoursLbl.TabIndex = 1;
            this.creditHoursLbl.Text = "Credit Hours (Fall \'19):";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(34, 115);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(33, 13);
            this.dateLbl.TabIndex = 3;
            this.dateLbl.Text = "Date:";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(34, 149);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(33, 13);
            this.timeLbl.TabIndex = 5;
            this.timeLbl.Text = "Time:";
            // 
            // firstLetterTxt
            // 
            this.firstLetterTxt.Location = new System.Drawing.Point(189, 27);
            this.firstLetterTxt.Name = "firstLetterTxt";
            this.firstLetterTxt.Size = new System.Drawing.Size(100, 20);
            this.firstLetterTxt.TabIndex = 6;
            // 
            // creditHoursTxt
            // 
            this.creditHoursTxt.Location = new System.Drawing.Point(189, 67);
            this.creditHoursTxt.Name = "creditHoursTxt";
            this.creditHoursTxt.Size = new System.Drawing.Size(100, 20);
            this.creditHoursTxt.TabIndex = 8;
            // 
            // dateOutputLbl
            // 
            this.dateOutputLbl.Location = new System.Drawing.Point(98, 115);
            this.dateOutputLbl.Name = "dateOutputLbl";
            this.dateOutputLbl.Size = new System.Drawing.Size(85, 13);
            this.dateOutputLbl.TabIndex = 9;
            // 
            // timeOutputLbl
            // 
            this.timeOutputLbl.Location = new System.Drawing.Point(98, 149);
            this.timeOutputLbl.Name = "timeOutputLbl";
            this.timeOutputLbl.Size = new System.Drawing.Size(85, 13);
            this.timeOutputLbl.TabIndex = 10;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(108, 188);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 11;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 223);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.timeOutputLbl);
            this.Controls.Add(this.dateOutputLbl);
            this.Controls.Add(this.creditHoursTxt);
            this.Controls.Add(this.firstLetterTxt);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.creditHoursLbl);
            this.Controls.Add(this.firstLetterLbl);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLetterLbl;
        private System.Windows.Forms.Label creditHoursLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.TextBox firstLetterTxt;
        private System.Windows.Forms.TextBox creditHoursTxt;
        private System.Windows.Forms.Label dateOutputLbl;
        private System.Windows.Forms.Label timeOutputLbl;
        private System.Windows.Forms.Button calcBtn;
    }
}

