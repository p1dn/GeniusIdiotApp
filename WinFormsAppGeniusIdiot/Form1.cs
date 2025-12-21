using ConsoleApp3;

namespace WinFormsAppGeniusIdiot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Question> questions = QuestionRepository.GetDefaultQuestions();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

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
