namespace WinFormsAppGeniusIdiot
{
    partial class UserResultsForm
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
            resultsListDataGridView = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            CountRightAnswersColumn = new DataGridViewTextBoxColumn();
            DiagnoseColumn = new DataGridViewTextBoxColumn();
            menuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)resultsListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsListDataGridView
            // 
            resultsListDataGridView.AllowUserToAddRows = false;
            resultsListDataGridView.AllowUserToDeleteRows = false;
            resultsListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsListDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, CountRightAnswersColumn, DiagnoseColumn });
            resultsListDataGridView.Location = new Point(12, 12);
            resultsListDataGridView.Name = "resultsListDataGridView";
            resultsListDataGridView.ReadOnly = true;
            resultsListDataGridView.Size = new Size(1542, 937);
            resultsListDataGridView.TabIndex = 0;
            resultsListDataGridView.CellContentClick += resultsListDataGridView_CellContentClick;
            // 
            // NameColumn
            // 
            NameColumn.FillWeight = 500F;
            NameColumn.HeaderText = "Имя";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 500;
            // 
            // CountRightAnswersColumn
            // 
            CountRightAnswersColumn.FillWeight = 500F;
            CountRightAnswersColumn.HeaderText = "Кол-во правильных ответов";
            CountRightAnswersColumn.Name = "CountRightAnswersColumn";
            CountRightAnswersColumn.ReadOnly = true;
            CountRightAnswersColumn.Width = 500;
            // 
            // DiagnoseColumn
            // 
            DiagnoseColumn.FillWeight = 500F;
            DiagnoseColumn.HeaderText = "Диагноз";
            DiagnoseColumn.Name = "DiagnoseColumn";
            DiagnoseColumn.ReadOnly = true;
            DiagnoseColumn.Width = 500;
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
            // UserResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1564, 961);
            Controls.Add(menuButton);
            Controls.Add(resultsListDataGridView);
            Name = "UserResultsForm";
            Text = "UserResultsForm";
            Load += UserResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsListDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultsListDataGridView;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn CountRightAnswersColumn;
        private DataGridViewTextBoxColumn DiagnoseColumn;
        private Button menuButton;
    }
}