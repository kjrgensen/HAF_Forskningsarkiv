using System;
using System.Windows.Forms;
using ForskningsArkiv.ConnectionDB;
using ForskningsArkiv.ConnectionDB.SpecifikationsSøgDB;
using ForskningsArkiv.DatabaseHAF.SøgDB;

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
            //BIGFAT CHANGE
            //if (textBox2Emnetyper.Text.Length>0)
            //{
            var emnetypeSøgDB = new EmnetypeSøgDB();
            emnetypeSøgDB.SøgSpecifiktEmnetyperFriTeskt(this);


            //    var materialetypeSøg = new MaterialetypeSøg();  
            //materialetypeSøg.SøgSpecifiktMaterialetypeFriTeskt(this);



            //if (textBox1Søg.Text.Length>0)
            //{
            //var sagstitelSøgdb = new SagstitelSøgDB();

            //sagstitelSøgdb.SagstitelSøgFritekst(this);
            ////textBox1Søg.Clear();

            //}

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            var emnetypeSøgDBe = new EmnetypeSøgDB();
            emnetypeSøgDBe.FillEmnetypeComboBox(this);


            var matetialetypesøg = new MaterialetypeSøg();
            matetialetypesøg.FillMaterielTypeComboBox(this);
        }

        private void søgMaterialetyper_Click(object sender, EventArgs e)
        {
            var materialesøgDB = new MaterialetypeSøg();
            materialesøgDB.SøgSpecifiktMaterialetypeFriTeskt(this);
        }
    }
}