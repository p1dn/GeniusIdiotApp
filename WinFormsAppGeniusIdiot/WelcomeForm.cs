using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppGeniusIdiot
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }
        private void WelcomeForm_Load(object sender, EventArgs e) { }

        private void welcomeTextLabel_Click(object sender, EventArgs e) { }

        private void userNameTextBox_TextChanged(object sender, EventArgs e) { }

        private void startButton_Click(object sender, EventArgs e)
        {
            var menu = new MenuForm(userNameTextBox.Text);

            menu.FormClosed += (s, args) => this.Close();

            this.Hide();
            menu.Show();
        }

        private void exitButton_Click(object sender, EventArgs e) => this.Close();
    }
}
