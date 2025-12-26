using ClassLibraryGeniusIdiot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppGeniusIdiot
{
    public partial class UserResultsForm : Form
    {
        private UserManager userManager;

        public UserResultsForm()
        {
            InitializeComponent();
        }

        private void resultsListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserResultsForm_Load(object sender, EventArgs e)
        {
            userManager = new UserManager();
            userManager.Load();

            foreach (var result in UserManager.Users)
            {
                resultsListDataGridView.Rows.Add(result.Name, result.CountOfRightAnswers, ConsoleView.GetDiagnosis(result.CountOfRightAnswers));
            }
        }

        private void menuButton_Click(object sender, EventArgs e) => this.Close();
    }
}
