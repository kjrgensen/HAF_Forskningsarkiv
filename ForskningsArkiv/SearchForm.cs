using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForskningsArkiv.ConnectionDB;

namespace ForskningsArkiv
{
    public partial class SearchForm : Form
    {
        private DB _db;

        public SearchForm()
        {
            InitializeComponent();
            //DB d = new DB();
           //d.connection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _db = new DB();
            _db.SøgiTabel(this);
        }

   


    }

 
}
