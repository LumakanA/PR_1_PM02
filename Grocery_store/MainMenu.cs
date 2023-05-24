using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_store
{
    public partial class MainMenu : Form
    {
        private LogIn loginForm; // Добавлено поле для хранения ссылки на форму LogIn

        public MainMenu(LogIn loginForm) // Добавлен конструктор, принимающий экземпляр формы LogIn
        {
            InitializeComponent();
            this.loginForm = loginForm; // Сохраняем ссылку на форму LogIn

            this.Load += MainMenu_Load;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (loginForm.IsButton3Visible)
            {
                button3.Visible = true;
            }
            else
            {
                button3.Visible = false;
            }
        }

        private void Оповещения_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn();
            loginForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Hide();
        }

    }
}
