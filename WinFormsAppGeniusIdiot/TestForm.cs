using ClassLibraryGeniusIdiot;
using System.Diagnostics.Metrics;

namespace WinFormsAppGeniusIdiot
{
    public partial class TestForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
        private int questionNumber;
        private readonly string userName;

        public TestForm()
        {
            InitializeComponent();
        }

        public TestForm(string userName) : this()
        {
            this.userName = userName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            questions = QuestionRepository.GetDefaultQuestions();
            user = new User(userName);
            questionNumber = 1;

            showNextQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            int correctAnswer = currentQuestion.CorrectAnswer;

            if (userAnswer == currentQuestion.CorrectAnswer) user.CountOfRightAnswers++;
            questions.Remove(currentQuestion);

            bool endGame = questions.Count == 0;
            if (endGame)
            {
                string showDiagnosis = $"{user.Name}, вот ваш диагноз: {ConsoleView.GetDiagnosis(user.CountOfRightAnswers)}";
                MessageBox.Show(showDiagnosis);
                return;
            }

            showNextQuestion();
        }

        private void showNextQuestion()
        {
            var rnd = new Random();
            int randomIndex = rnd.Next(0, questions.Count);

            currentQuestion = questions[randomIndex];
            questionLabel.Text = currentQuestion.Problem;

            questionNumberLabel.Text = $"Вопрос: {questionNumber++}";
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
