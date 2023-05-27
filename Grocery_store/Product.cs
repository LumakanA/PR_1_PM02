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
    public partial class Product : Form
    {
        private MainMenu mainMenu;

        public Product(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }   
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Вы не указали один из параметров. Регистрация невозможна.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Товар успешно зарегистрирован.", "Уведомление",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox9.Text) || string.IsNullOrEmpty(textBox10.Text) || string.IsNullOrEmpty(textBox11.Text) || string.IsNullOrEmpty(textBox12.Text))
            {
                MessageBox.Show("Вы не указали один из параметров. Удаление невозможна.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Товар успешно удален.", "Уведомление",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.mainMenu.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListOfProducts listOfProductsForm = new ListOfProducts();
            listOfProductsForm.Show();
            this.Hide();
        }
    }
}
