namespace WinFormsAppGeniusIdiot
{
    partial class AddQuestionForm
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
            addQuestionButton = new Button();
            newUesrsQuestionTextBox = new TextBox();
            enterNewQuestionLabel = new Label();
            SuspendLayout();
            // 
            // addQuestionButton
            // 
            addQuestionButton.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addQuestionButton.Location = new Point(1600, 801);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(272, 148);
            addQuestionButton.TabIndex = 0;
            addQuestionButton.Text = "Далее";
            addQuestionButton.UseVisualStyleBackColor = true;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // newUesrsQuestionTextBox
            // 
            newUesrsQuestionTextBox.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            newUesrsQuestionTextBox.Location = new Point(12, 498);
            newUesrsQuestionTextBox.Name = "newUesrsQuestionTextBox";
            newUesrsQuestionTextBox.Size = new Size(1860, 63);
            newUesrsQuestionTextBox.TabIndex = 1;
            newUesrsQuestionTextBox.TextChanged += newUesrsQuestionTextBox_TextChanged;
            // 
            // enterNewQuestionLabel
            // 
            enterNewQuestionLabel.AutoSize = true;
            enterNewQuestionLabel.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            enterNewQuestionLabel.Location = new Point(12, 416);
            enterNewQuestionLabel.Name = "enterNewQuestionLabel";
            enterNewQuestionLabel.Size = new Size(573, 56);
            enterNewQuestionLabel.TabIndex = 2;
            enterNewQuestionLabel.Text = "Введите текст вопроса";
            enterNewQuestionLabel.Click += enterNewQuestionLabel_Click;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1884, 961);
            Controls.Add(enterNewQuestionLabel);
            Controls.Add(newUesrsQuestionTextBox);
            Controls.Add(addQuestionButton);
            Name = "AddQuestionForm";
            Text = "AddQuestionForm";
            Load += AddQuestionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addQuestionButton;
        private TextBox newUesrsQuestionTextBox;
        private Label enterNewQuestionLabel;
    }
}