using System;
using System.Windows.Forms;
using ForskningsArkiv.ConnectionDB;
using ForskningsArkiv.ConnectionDB.SpecifikationsSøgDB;

namespace ForskningsArkiv
{
    public partial class SearchForm : Form
    {
        private DBConnectionstring _db;

        public SearchForm()
        {
            InitializeComponent();
            //DB d = new DB();
            //d.connection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = new VælgBrugerAdmin();
            form1.Show();

            Close();
        }

        private void buttonSøgFri_Click(object sender, EventArgs e)
        {
            //var sagstitelSøgdb = new SagstitelSøgDB();
            //sagstitelSøgdb.SagstitelSøgFritekst(this);
        }

        private void button2Emnetyper_Click(object sender, EventArgs e)
        {
           
          var sagstitelSøgdb = new SagstitelSøgDB();
          sagstitelSøgdb.SagstitelSøgFritekst(this);
          
          
            
            var emnetypeSøgDB = new EmnetypeSøgDB();
            emnetypeSøgDB.SøgSpecifiktEmnetyperFriTeskt(this);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            var emnetypeSøgDBe = new EmnetypeSøgDB();
            emnetypeSøgDBe.FillEmnetypeComboBox(this);
        }
    }
}