using System;
using System.IO;
using System.Windows.Forms;

namespace Grocery_store
{
    public partial class Messages : Form
    {
        private MainMenu mainMenuForm;
        public Messages(MainMenu mainMenuForm)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenuForm;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ошибка: Вы должны ввести текст сообщения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string messageText = textBox1.Text;
                DateTime currentDateTime = DateTime.Now;
                int messageNumber = MessageData.Messages.Count + 1;
                Message message = new Message(messageNumber, messageText, currentDateTime);
                MessageData.Messages.Add(message);
                MessageBox.Show("У вас новое сообщение!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn();
            MainMenu mainMenu = new MainMenu(loginForm);
            Employees employees = new Employees(mainMenu);
            employees.Show();
            this.Close();
        }
        private bool isRadioButtonChecked = false;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                isRadioButtonChecked = !isRadioButtonChecked;

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, isRadioButtonChecked);
                }
            }
        }
        public event Action<string> MessageTextChanged;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string messageText = textBox1.Text;
            MessageTextChanged?.Invoke(messageText);
        }
    }
}
