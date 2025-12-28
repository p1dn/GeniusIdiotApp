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
            questionsDataGridView = new DataGridView();
            menuButton = new Button();
            deleteButton = new Button();
            TextColumn = new DataGridViewTextBoxColumn();
            CorrectAnswerColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.AllowUserToAddRows = false;
            questionsDataGridView.AllowUserToDeleteRows = false;
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { TextColumn, CorrectAnswerColumn });
            questionsDataGridView.Location = new Point(12, 12);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.ReadOnly = true;
            questionsDataGridView.Size = new Size(1860, 800);
            questionsDataGridView.TabIndex = 0;
            questionsDataGridView.CellContentClick += questionsDataGridView_CellContentClick;
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menuButton.Location = new Point(12, 864);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(143, 85);
            menuButton.TabIndex = 7;
            menuButton.Text = "Меню";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(1654, 818);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(218, 131);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить вопрос";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // TextColumn
            // 
            TextColumn.FillWeight = 800F;
            TextColumn.HeaderText = "Текст";
            TextColumn.Name = "TextColumn";
            TextColumn.ReadOnly = true;
            TextColumn.Width = 1120;
            // 
            // CorrectAnswerColumn
            // 
            CorrectAnswerColumn.FillWeight = 800F;
            CorrectAnswerColumn.HeaderText = "Ответ";
            CorrectAnswerColumn.Name = "CorrectAnswerColumn";
            CorrectAnswerColumn.ReadOnly = true;
            CorrectAnswerColumn.Width = 700;
            // 
            // DeleteQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1884, 961);
            Controls.Add(deleteButton);
            Controls.Add(menuButton);
            Controls.Add(questionsDataGridView);
            Name = "DeleteQuestionForm";
            Text = "DeleteQuestionForm";
            Load += DeleteQuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView questionsDataGridView;
        private Button menuButton;
        private Button deleteButton;
        private DataGridViewTextBoxColumn TextColumn;
        private DataGridViewTextBoxColumn CorrectAnswerColumn;
    }
}