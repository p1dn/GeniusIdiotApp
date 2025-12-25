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
        private int questionNumber;
        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            questionRepository = new QuestionRepository();
            questionRepository.Load();
            questionNumber = 0;

            changeQuestion();
        }

        private void questionTextLabel_Click(object sender, EventArgs e) { }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (questionNumber == 0) questionNumber = QuestionRepository.Questions.Count - 1;
            else questionNumber -= 1;

            changeQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (questionNumber == QuestionRepository.Questions.Count - 1) questionNumber = 0;
            else questionNumber += 1;

            changeQuestion();
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            QuestionRepository.Questions.RemoveAt(questionNumber);
            questionRepository.Save();
            this.Close();
        }

        private void chooseQuestionLabel_Click(object sender, EventArgs e) { }

        private void changeQuestion() => questionTextLabel.Text = QuestionRepository.Questions[questionNumber].Problem;

        private void menuButton_Click(object sender, EventArgs e) => this.Close();
    }
}
