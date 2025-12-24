using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppGeniusIdiot
{
    public partial class MenuForm : Form
    {
        private readonly string userName;

        public MenuForm()
        {
            InitializeComponent();
        }

        public MenuForm(string userName) : this()
        {
            this.userName = userName;
        }

        private void ChooseLabel_Click(object sender, EventArgs e) { }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {

        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            var test = new TestForm(userName);

            test.FormClosed += (s, args) => this.Close();

            this.Hide();
            test.Show();
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            ChooseLabel.Text = $"{userName}, Выберите вариант";
        }
    }
}
