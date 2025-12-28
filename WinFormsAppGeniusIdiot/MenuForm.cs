using static System.Net.Mime.MediaTypeNames;

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

        private void addQuestionButton_Click(object sender, EventArgs e) => openNewForm(new AddQuestionForm());

        private void startTestButton_Click(object sender, EventArgs e) => openNewForm(new TestForm(userName));

        private void deleteQuestionButton_Click(object sender, EventArgs e) => openNewForm(new DeleteQuestionForm());

        private void MenuForm_Load(object sender, EventArgs e)
        {
            ChooseLabel.Text = $"{userName}, Выберите вариант";
        }

        private void openNewForm(Form form)
        {
            form.FormClosed += (s, args) => this.Show();

            this.Hide();
            form.Show();
        }

        private void exitButton_Click(object sender, EventArgs e) => this.Close();

        private void перезапускToolStripMenuItem_Click(object sender, EventArgs e) => System.Windows.Forms.Application.Restart();

        private void списокРезультатовToolStripMenuItem_Click(object sender, EventArgs e) => openNewForm(new UserResultsForm());
    }
}
