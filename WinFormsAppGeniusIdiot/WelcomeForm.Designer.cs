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
            userNameTextBox.Location = new Point(12, 587);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(1857, 118);
            userNameTextBox.TabIndex = 1;
            // 
            // enterNameLabel
            // 
            enterNameLabel.AutoSize = true;
            enterNameLabel.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            enterNameLabel.Location = new Point(642, 476);
            enterNameLabel.Name = "enterNameLabel";
            enterNameLabel.Size = new Size(619, 75);
            enterNameLabel.TabIndex = 2;
            enterNameLabel.Text = "Введите ваше имя";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1881, 964);
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
    }
}