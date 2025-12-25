namespace WinFormsAppGeniusIdiot
{
    partial class TestForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nextButton = new Button();
            questionLabel = new Label();
            questionNumberLabel = new Label();
            userAnswerTextBox = new TextBox();
            menuButton = new Button();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(1660, 832);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(211, 124);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionLabel.Location = new Point(12, 252);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(364, 56);
            questionLabel.TabIndex = 1;
            questionLabel.Text = "Текст вопроса";
            questionLabel.Click += questionLabel_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionNumberLabel.Location = new Point(12, 9);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(285, 41);
            questionNumberLabel.TabIndex = 2;
            questionNumberLabel.Text = "Номер вопроса";
            questionNumberLabel.Click += questionNumberLabel_Click;
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userAnswerTextBox.Location = new Point(12, 510);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(1859, 118);
            userAnswerTextBox.TabIndex = 3;
            userAnswerTextBox.TextChanged += userAnswerTextBox_TextChanged;
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menuButton.Location = new Point(12, 864);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(143, 85);
            menuButton.TabIndex = 5;
            menuButton.Text = "Меню";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1884, 961);
            Controls.Add(menuButton);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionNumberLabel);
            Controls.Add(questionLabel);
            Controls.Add(nextButton);
            Name = "TestForm";
            Text = "Тест";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label questionLabel;
        private Label questionNumberLabel;
        private TextBox userAnswerTextBox;
        private Button menuButton;
    }
}
