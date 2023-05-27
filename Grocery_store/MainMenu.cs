using System;
using System.Windows.Forms;

namespace Grocery_store
{
    public partial class MainMenu : Form
    {
        private LogIn loginForm;

        public MainMenu(LogIn loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
            this.Load += MainMenu_Load;
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            button3.Visible = LogIn.IsButton3Visible;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.loginForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Product(this).Show();
            this.Hide();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            new Employees(this).Show();
            this.Hide();
        }

        private void Messages_MessageTextChanged(string messageText)
        {
            richTextBox1.AppendText(messageText + Environment.NewLine);
        }

        private void ShowMessagesForm()
        {
            Messages messagesForm = new Messages(this);
            messagesForm.MessageTextChanged += Messages_MessageTextChanged;
            messagesForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshMessagesList();
        }

        public void AddMessageToListBox(string messageText)
        {
            Message message = new Message(MessageData.Messages.Count + 1, messageText, DateTime.Now);
            MessageData.Messages.Insert(0, message);
            RefreshMessagesList();
        }

        private void RefreshMessagesList()
        {
            richTextBox1.Clear();

            for (int i = MessageData.Messages.Count - 1; i >= 0; i--)
            {
                Message message = MessageData.Messages[i];
                string formattedMessage = $"Сообщение #{message.Number} | {message.DateTime:dd.MM.yyyy} | {message.DateTime:HH:mm:ss}{Environment.NewLine}{message.Text}{Environment.NewLine}";
                richTextBox1.AppendText(formattedMessage);
            }
        }
    }
}
