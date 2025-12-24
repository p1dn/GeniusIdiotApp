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
    public partial class AddQuestionForm : Form
    {
        private bool firstClick;
        private Question newQuestion;
        private QuestionRepository questionRepository;

        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void enterNewQuestionLabel_Click(object sender, EventArgs e) { }

        private void newUesrsQuestionTextBox_TextChanged(object sender, EventArgs e) { }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            if(firstClick)
            {
                newQuestion.Problem = newUesrsQuestionTextBox.Text;
                enterNewQuestionLabel.Text = "Введите ответ вопроса";
                addQuestionButton.Text = "Добавить вопрос";
                firstClick = false;
            }
            else
            {
                newQuestion.CorrectAnswer = Convert.ToInt32(newUesrsQuestionTextBox.Text);
                QuestionRepository.Questions.Add(newQuestion);
                questionRepository.Save();
                this.Close();
            }
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
            firstClick = true;
            newQuestion = new Question();
            questionRepository = new QuestionRepository();
            questionRepository.Load();
        }
    }
}
