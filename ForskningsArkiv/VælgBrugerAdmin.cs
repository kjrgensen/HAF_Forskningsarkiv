using System;
using System.Windows.Forms;

namespace ForskningsArkiv
{
    public partial class VælgBrugerAdmin : Form
    {
        public VælgBrugerAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();
            Hide();
            searchForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}