namespace WinFormsAppGeniusIdiot
{
    partial class WelcomeForm
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
            welcomeTextLabel = new Label();
            userNameTextBox = new TextBox();
            enterNameLabel = new Label();
            startButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // welcomeTextLabel
            // 
            welcomeTextLabel.AutoSize = true;
            welcomeTextLabel.Font = new Font("Arial", 71.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            welcomeTextLabel.Location = new Point(507, 9);
            welcomeTextLabel.Name = "welcomeTextLabel";
            welcomeTextLabel.Size = new Size(969, 109);
            welcomeTextLabel.TabIndex = 0;
            welcomeTextLabel.Text = "Добро пожаловать!";
            welcomeTextLabel.Click += welcomeTextLabel_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userNameTextBox.Location = new Point(2, 460);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(1857, 118);
            userNameTextBox.TabIndex = 1;
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // enterNameLabel
            // 
            enterNameLabel.AutoSize = true;
            enterNameLabel.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            enterNameLabel.Location = new Point(642, 363);
            enterNameLabel.Name = "enterNameLabel";
            enterNameLabel.Size = new Size(619, 75);
            enterNameLabel.TabIndex = 2;
            enterNameLabel.Text = "Введите ваше имя";
            // 
            // startButton
            // 
            startButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startButton.Location = new Point(795, 601);
            startButton.Name = "startButton";
            startButton.Size = new Size(279, 144);
            startButton.TabIndex = 3;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(12, 864);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(143, 85);
            exitButton.TabIndex = 4;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1884, 961);
            Controls.Add(exitButton);
            Controls.Add(startButton);
            Controls.Add(enterNameLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(welcomeTextLabel);
            Name = "WelcomeForm";
            Text = "Добро пожаловать!";
            Load += WelcomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeTextLabel;
        private TextBox userNameTextBox;
        private Label enterNameLabel;
        private Button startButton;
        private Button exitButton;
    }
}