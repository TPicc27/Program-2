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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameAnswer = new System.Windows.Forms.TextBox();
            this.creditHoursLabel = new System.Windows.Forms.Label();
            this.creditHourAnswer = new System.Windows.Forms.TextBox();
            this.timeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dateOutput = new System.Windows.Forms.Label();
            this.timeOutput = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 28);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(181, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Write the first letter of your last name.";
            // 
            // lastNameAnswer
            // 
            this.lastNameAnswer.Location = new System.Drawing.Point(15, 44);
            this.lastNameAnswer.Name = "lastNameAnswer";
            this.lastNameAnswer.Size = new System.Drawing.Size(100, 20);
            this.lastNameAnswer.TabIndex = 1;
            // 
            // creditHoursLabel
            // 
            this.creditHoursLabel.AutoSize = true;
            this.creditHoursLabel.Location = new System.Drawing.Point(12, 83);
            this.creditHoursLabel.Name = "creditHoursLabel";
            this.creditHoursLabel.Size = new System.Drawing.Size(198, 13);
            this.creditHoursLabel.TabIndex = 2;
            this.creditHoursLabel.Text = "How many credit hours have you taken?";
            // 
            // creditHourAnswer
            // 
            this.creditHourAnswer.Location = new System.Drawing.Point(15, 99);
            this.creditHourAnswer.Name = "creditHourAnswer";
            this.creditHourAnswer.Size = new System.Drawing.Size(100, 20);
            this.creditHourAnswer.TabIndex = 3;
            // 
            // timeButton
            // 
            this.timeButton.Location = new System.Drawing.Point(3, 173);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(144, 23);
            this.timeButton.TabIndex = 4;
            this.timeButton.Text = "Registration Time";
            this.timeButton.UseVisualStyleBackColor = true;
            this.timeButton.Click += new System.EventHandler(this.timeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(153, 173);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(234, 173);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dateOutput
            // 
            this.dateOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutput.Location = new System.Drawing.Point(314, 41);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(119, 23);
            this.dateOutput.TabIndex = 7;
            this.dateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeOutput
            // 
            this.timeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeOutput.Location = new System.Drawing.Point(314, 96);
            this.timeOutput.Name = "timeOutput";
            this.timeOutput.Size = new System.Drawing.Size(119, 23);
            this.timeOutput.TabIndex = 8;
            this.timeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(311, 28);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(89, 13);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Registration Date";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(311, 83);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(89, 13);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "Registration Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 246);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeOutput);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.timeButton);
            this.Controls.Add(this.creditHourAnswer);
            this.Controls.Add(this.creditHoursLabel);
            this.Controls.Add(this.lastNameAnswer);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameAnswer;
        private System.Windows.Forms.Label creditHoursLabel;
        private System.Windows.Forms.TextBox creditHourAnswer;
        private System.Windows.Forms.Button timeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label timeOutput;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}

