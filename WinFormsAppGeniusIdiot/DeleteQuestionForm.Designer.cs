namespace WinFormsAppGeniusIdiot
{
    partial class DeleteQuestionForm
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
            questionTextLabel = new Label();
            deleteQuestionButton = new Button();
            chooseQuestionLabel = new Label();
            previousButton = new Button();
            nextButton = new Button();
            menuButton = new Button();
            SuspendLayout();
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionTextLabel.Location = new Point(12, 207);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(284, 44);
            questionTextLabel.TabIndex = 0;
            questionTextLabel.Text = "Текст вопроса";
            questionTextLabel.Click += questionTextLabel_Click;
            // 
            // deleteQuestionButton
            // 
            deleteQuestionButton.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteQuestionButton.Location = new Point(1600, 801);
            deleteQuestionButton.Name = "deleteQuestionButton";
            deleteQuestionButton.Size = new Size(272, 148);
            deleteQuestionButton.TabIndex = 1;
            deleteQuestionButton.Text = "Удалить вопрос";
            deleteQuestionButton.UseVisualStyleBackColor = true;
            deleteQuestionButton.Click += deleteQuestionButton_Click;
            // 
            // chooseQuestionLabel
            // 
            chooseQuestionLabel.AutoSize = true;
            chooseQuestionLabel.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chooseQuestionLabel.Location = new Point(723, 9);
            chooseQuestionLabel.Name = "chooseQuestionLabel";
            chooseQuestionLabel.Size = new Size(450, 56);
            chooseQuestionLabel.TabIndex = 2;
            chooseQuestionLabel.Text = "Выберите вопрос";
            chooseQuestionLabel.Click += chooseQuestionLabel_Click;
            // 
            // previousButton
            // 
            previousButton.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            previousButton.Location = new Point(12, 362);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(236, 124);
            previousButton.TabIndex = 3;
            previousButton.Text = "Предыдущий";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(1636, 362);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(236, 124);
            nextButton.TabIndex = 4;
            nextButton.Text = "Следующий";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menuButton.Location = new Point(12, 864);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(143, 85);
            menuButton.TabIndex = 6;
            menuButton.Text = "Меню";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // DeleteQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1884, 961);
            Controls.Add(menuButton);
            Controls.Add(nextButton);
            Controls.Add(previousButton);
            Controls.Add(chooseQuestionLabel);
            Controls.Add(deleteQuestionButton);
            Controls.Add(questionTextLabel);
            Name = "DeleteQuestionForm";
            Text = "DeleteQuestionForm";
            Load += DeleteQuestionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionTextLabel;
        private Button deleteQuestionButton;
        private Label chooseQuestionLabel;
        private Button previousButton;
        private Button nextButton;
        private Button menuButton;
    }
}