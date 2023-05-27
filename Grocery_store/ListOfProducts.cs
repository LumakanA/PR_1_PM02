using System;
using System.Windows.Forms;

namespace Grocery_store
{
    public partial class ListOfProducts : Form
    {
        public ListOfProducts()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn();
            MainMenu mainMenu = new MainMenu(loginForm);
            Product productForm = new Product(mainMenu);
            productForm.Show();
            this.Close();
        }
        private void List_of_products_Load(object sender, EventArgs e)
        {
            this.товарTableAdapter.Fill(this.pR_1DataSet.Товар);
        }
    }
}
