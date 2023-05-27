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
    public partial class Employees : Form
    {
        private MainMenu mainMenu;

        public Employees(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.mainMenu.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Вы не указали один из параметров. Регистрация невозможна.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Сотрудник успешно зарегистрирован", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages(mainMenu);
            messages.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListOfEmployees employees = new ListOfEmployees();
            employees.Show();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Вы не указали один из параметров. Удаление невозможно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Сотрудник успешно удален", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox7.Clear();
            }
        }

    }
}
