using ClassLibraryGeniusIdiot;
using System.Diagnostics.Metrics;

namespace WinFormsAppGeniusIdiot
{
    public partial class TestForm : Form
    {
        private QuestionRepository questionRepository;
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
        private UserManager userManager;
        private CheckingUserResponsesWinForms checkingUserResponsesWinForm;
        private Random rnd;
        private int questionNumber;
        private int timeLeft;
        private readonly string userName;
        private bool isInProgress;

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
            questionRepository = new QuestionRepository();
            questionRepository.Load();
            questions = QuestionRepository.Questions;
            user = new User(userName);
            checkingUserResponsesWinForm = new CheckingUserResponsesWinForms();
            userManager = new UserManager();
            rnd = new Random();
            userManager.Load();
            questionNumber = 1;
            timerSetting();
            isInProgress = false;
            answerTimer.Interval = 1000;
            answerTimer.Tick += answerTimer_Tick;
            answerTimer.Start();

            showNextQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (checkingUserResponsesWinForm.CheckingUserResponse(userAnswerTextBox.Text))
            {
                int userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
                int correctAnswer = currentQuestion.CorrectAnswer;

                if (userAnswer == currentQuestion.CorrectAnswer) user.CountOfRightAnswers++;

                answerTimer.Stop();
                showNextQuestion();
            }
        }

        private void showNextQuestion()
        {
            questions.Remove(currentQuestion);

            bool endGame = questions.Count == 0;
            if (questions.Count == 1) nextButton.Text = "Завершить";
            if (endGame)
            {
                UserManager.Users.Add(user);
                userManager.Save();
                string showDiagnosis = $"{user.Name}, вот ваш диагноз: {ConsoleView.GetDiagnosis(user.CountOfRightAnswers)}";
                MessageBox.Show(showDiagnosis);
                this.Close();
                return;
            }

            int randomIndex = rnd.Next(0, questions.Count);

            currentQuestion = questions[randomIndex];
            questionLabel.Text = currentQuestion.Problem;

            questionNumberLabel.Text = $"Вопрос: {questionNumber++}";

            timerSetting();

            answerTimer.Start();
        }

        private void questionNumberLabel_Click(object sender, EventArgs e) { }

        private void questionLabel_Click(object sender, EventArgs e) { }

        private void userAnswerTextBox_TextChanged(object sender, EventArgs e) { }

        private void menuButton_Click(object sender, EventArgs e) => this.Close();

        private void answerTimer_Tick(object sender, EventArgs e)
        {
            if (isInProgress)
            {
                isInProgress = false;
                return;
            }
            else if (timeLeft > 1)
            {
                timeLeft--;
                timerLabel.Text = timeLeft.ToString();

                isInProgress = true;
                return;
            }
            else
            {
                answerTimer.Stop();
                MessageBox.Show("Время вышло");
                showNextQuestion();
            }
        }

        private void timerLabel_Click(object sender, EventArgs e) { }

        private void timerSetting()
        {
            timeLeft = 10;
            timerLabel.Text = timeLeft.ToString();
        }
    }
}
