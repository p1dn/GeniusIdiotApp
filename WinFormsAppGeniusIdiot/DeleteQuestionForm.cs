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
    public partial class DeleteQuestionForm : Form
    {
        private QuestionRepository questionRepository;

        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void questionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            questionRepository = new QuestionRepository();
            questionRepository.Load();

            foreach (var question in QuestionRepository.Questions)
            {
                questionsDataGridView.Rows.Add(question.Problem, question.CorrectAnswer);
            }
        }

        private void menuButton_Click(object sender, EventArgs e) => this.Close();

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = questionsDataGridView.SelectedRows[0].Index;

                QuestionRepository.Questions.RemoveAt(rowIndex);
                questionsDataGridView.Rows.RemoveAt(rowIndex);
                questionRepository.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы должны выбрать ОДНУ строку для удаления");
            }
        }
    }
}
