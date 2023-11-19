namespace Lab5Main
{
    public partial class MainForm : Form
    {
        private Checker checker = new Checker(8);

        private string message;
        private string messageBinary;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            message = messageTextBox.Text;

            if (message == "")
            {
                var errorForm = new ErrorForm("Нет текста для шифровки");
                errorForm.ShowDialog();
                return;
            }

            messageBinary = checker.ConvertToBinary(message);
            binaryTextBox.Text = messageBinary;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            messageBinary = binaryTextBox.Text;

            if (messageBinary == "")
            {
                var errorForm = new ErrorForm("Нет текста для проверки");
                errorForm.ShowDialog();
                return;
            }

            if (checker.Check(messageBinary))
            {
                checkStatusLabel.Text = "Проверка пройдена";
            }

            else
            {
                checkStatusLabel.Text = "Проверка не пройдена";
            }
        }
    }
}
