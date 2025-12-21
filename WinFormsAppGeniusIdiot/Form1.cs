using ConsoleApp3;
using System.Diagnostics.Metrics;

namespace WinFormsAppGeniusIdiot
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private User user = new User();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            questions = QuestionRepository.GetDefaultQuestions();
            user.Name = "Unknown";

            showNextQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            int correctAnswer = currentQuestion.CorrectAnswer;

            if (userAnswer == currentQuestion.CorrectAnswer) user.CountOfRightAnswers++;
            questions.Remove(currentQuestion);

            showNextQuestion();
        }

        private void showNextQuestion()
        {
            var rnd = new Random();
            int randomIndex = rnd.Next(0, questions.Count);

            currentQuestion = questions[randomIndex];
            questionLabel.Text = currentQuestion.Problem;
        }

        private void questionNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }

        private void userAnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
