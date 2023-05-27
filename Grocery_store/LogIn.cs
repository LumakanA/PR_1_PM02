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
    public partial class LogIn : Form
    {
        public static bool IsButton3Visible { get; private set; }

        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;

            if (text1 == "менеджер" && text2 == "менеджер" ||
                text1 == "продавец" && text2 == "продавец" ||
                text1 == "товаровед" && text2 == "товаровед" ||
                text1 == "кладовщик" && text2 == "кладовщик")
            {
                IsButton3Visible = textBox1.Text == "менеджер" && textBox2.Text == "менеджер";

                MainMenu mainMenu = new MainMenu(this);
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка при вводе логина или пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
        private MainMenu mainMenu;
        public LogIn(MainMenu mainMenu)
        {
            this.mainMenu = mainMenu;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
