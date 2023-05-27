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
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Ошибка: Вы должны выбрать получателей сообщения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("У вас новое сообщение!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
