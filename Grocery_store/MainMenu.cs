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
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            button3.Visible = LogIn.IsButton3Visible;
        }
        private void Оповещения_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
