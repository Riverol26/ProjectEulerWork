namespace ProjectEulerSolutions
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
            this.RunButton = new System.Windows.Forms.Button();
            this.SolutionOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.RichTextBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RunButton.Location = new System.Drawing.Point(197, 13);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // SolutionOptionsComboBox
            // 
            this.SolutionOptionsComboBox.FormattingEnabled = true;
            this.SolutionOptionsComboBox.Location = new System.Drawing.Point(12, 15);
            this.SolutionOptionsComboBox.Name = "SolutionOptionsComboBox";
            this.SolutionOptionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.SolutionOptionsComboBox.TabIndex = 1;
            this.SolutionOptionsComboBox.Text = "Choose a Solution";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(13, 66);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(52, 13);
            this.QuestionLabel.TabIndex = 2;
            this.QuestionLabel.Text = "Question:";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionTextBox.Location = new System.Drawing.Point(12, 82);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(260, 58);
            this.QuestionTextBox.TabIndex = 3;
            this.QuestionTextBox.Text = "";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(13, 178);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(45, 13);
            this.AnswerLabel.TabIndex = 4;
            this.AnswerLabel.Text = "Answer:";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerTextBox.Location = new System.Drawing.Point(12, 194);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(260, 55);
            this.AnswerTextBox.TabIndex = 5;
            this.AnswerTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.SolutionOptionsComboBox);
            this.Controls.Add(this.RunButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.ComboBox SolutionOptionsComboBox;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.RichTextBox QuestionTextBox;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.RichTextBox AnswerTextBox;
    }
}

