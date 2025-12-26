namespace WinFormsAppGeniusIdiot
{
    partial class MenuForm
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
            startTestButton = new Button();
            deleteQuestionButton = new Button();
            addQuestionButton = new Button();
            ChooseLabel = new Label();
            exitButton = new Button();
            menuStrip1 = new MenuStrip();
            дополнительноToolStripMenuItem = new ToolStripMenuItem();
            перезапускToolStripMenuItem = new ToolStripMenuItem();
            списокРезультатовToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // startTestButton
            // 
            startTestButton.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startTestButton.Location = new Point(12, 315);
            startTestButton.Name = "startTestButton";
            startTestButton.Size = new Size(1860, 139);
            startTestButton.TabIndex = 0;
            startTestButton.Text = "Начать Тест";
            startTestButton.UseVisualStyleBackColor = true;
            startTestButton.Click += startTestButton_Click;
            // 
            // deleteQuestionButton
            // 
            deleteQuestionButton.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteQuestionButton.Location = new Point(12, 605);
            deleteQuestionButton.Name = "deleteQuestionButton";
            deleteQuestionButton.Size = new Size(1860, 139);
            deleteQuestionButton.TabIndex = 1;
            deleteQuestionButton.Text = "Удалить Вопрос";
            deleteQuestionButton.UseVisualStyleBackColor = true;
            deleteQuestionButton.Click += deleteQuestionButton_Click;
            // 
            // addQuestionButton
            // 
            addQuestionButton.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addQuestionButton.Location = new Point(12, 460);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(1860, 139);
            addQuestionButton.TabIndex = 2;
            addQuestionButton.Text = "Добавить Вопрос";
            addQuestionButton.UseVisualStyleBackColor = true;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // ChooseLabel
            // 
            ChooseLabel.AutoSize = true;
            ChooseLabel.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChooseLabel.Location = new Point(12, 99);
            ChooseLabel.Name = "ChooseLabel";
            ChooseLabel.Size = new Size(149, 56);
            ChooseLabel.TabIndex = 3;
            ChooseLabel.Text = "Label";
            ChooseLabel.Click += ChooseLabel_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(12, 864);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(143, 85);
            exitButton.TabIndex = 5;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { дополнительноToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1884, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // дополнительноToolStripMenuItem
            // 
            дополнительноToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { перезапускToolStripMenuItem, списокРезультатовToolStripMenuItem });
            дополнительноToolStripMenuItem.Name = "дополнительноToolStripMenuItem";
            дополнительноToolStripMenuItem.Size = new Size(107, 20);
            дополнительноToolStripMenuItem.Text = "Дополнительно";
            // 
            // перезапускToolStripMenuItem
            // 
            перезапускToolStripMenuItem.Name = "перезапускToolStripMenuItem";
            перезапускToolStripMenuItem.Size = new Size(184, 22);
            перезапускToolStripMenuItem.Text = "Перезапуск";
            перезапускToolStripMenuItem.Click += перезапускToolStripMenuItem_Click;
            // 
            // списокРезультатовToolStripMenuItem
            // 
            списокРезультатовToolStripMenuItem.Name = "списокРезультатовToolStripMenuItem";
            списокРезультатовToolStripMenuItem.Size = new Size(184, 22);
            списокРезультатовToolStripMenuItem.Text = "Список Результатов";
            списокРезультатовToolStripMenuItem.Click += списокРезультатовToolStripMenuItem_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1884, 961);
            Controls.Add(exitButton);
            Controls.Add(ChooseLabel);
            Controls.Add(addQuestionButton);
            Controls.Add(deleteQuestionButton);
            Controls.Add(startTestButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startTestButton;
        private Button deleteQuestionButton;
        private Button addQuestionButton;
        private Label ChooseLabel;
        private Button exitButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem дополнительноToolStripMenuItem;
        private ToolStripMenuItem перезапускToolStripMenuItem;
        private ToolStripMenuItem списокРезультатовToolStripMenuItem;
    }
}