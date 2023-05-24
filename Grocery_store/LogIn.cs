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
        public LogIn()
        {

            InitializeComponent();
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;

                if (text1 == "менеджер" && text2 == "менеджер")
                {
                    MainMenu mainmenu = new MainMenu();
                    mainmenu.Show();
                    this.Hide();
                }
                else if (text1 == "продавец" && text2 == "продавец")
                {
                    MainMenu mainmenu = new MainMenu();
                    mainmenu.Show();
                    this.Hide();
                }
                else if (text1 == "товаровед" && text2 == "товаровед")
                {
                    MainMenu mainmenu = new MainMenu();
                    mainmenu.Show();
                    this.Hide();
                }
                else if (text1 == "кладовщик" && text2 == "кладовщик")
                {
                    MainMenu mainmenu = new MainMenu();
                    mainmenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка при вводе логина или пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            CheckButtonVisibility();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CheckButtonVisibility();
        }

        private void CheckButtonVisibility()
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;

            if (text1 == "менеджер" && text2 == "менеджер")
            {
                mainMenu.SetButton3Visibility(true);
            }
            else
            {
                mainMenu.SetButton3Visibility(false);
            }
        }

    }
}
