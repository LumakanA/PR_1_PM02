using System;
using System.Windows.Forms;

namespace Grocery_store
{
    public partial class ListOfEmployees : Form
    {
        public ListOfEmployees()
        {
            InitializeComponent();
        }
        private void ListOfEmployees_Load(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.pR_1DataSet1.Сотрудники);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn();
            MainMenu mainMenu = new MainMenu(loginForm);
            Employees employees = new Employees(mainMenu);
            employees.Show();
            this.Close();
        }
    }
}
