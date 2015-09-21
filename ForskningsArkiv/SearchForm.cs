using System;
using System.Threading;
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
            var sagstitelSøgdb = new SagstitelSøgDB();
            var MeterialetypeSøg = new MaterialetypeSøg();
            var PeriodetypeSøg = new PeriodetyperSøgDB();
            var Emnetypesøg = new EmnetypeSøgDB();
            var årstalOprettetafsluttet = new ÅrstalOpretAfslutSagSøgDB();

            var KontaktpersonsøgFri = new KontaktpersonSøgDB();

            //Thread t1 = new Thread(() => sagstitelSøgdb.SagstitelSøgFritekst(this));
       
            //if (textBoxKontaktperson.Text.Length == 0 )
            //{
                sagstitelSøgdb.SagstitelSøgFritekst(this);
            //}
            //else
            //{
                
            //    KontaktpersonsøgFri.KontaktpersonSøg(this);
            //}


            //else if (comboEmnetyper.SelectedItem == null & PeriodeTPComboBox.SelectedItem == null)
            //{

            //    MeterialetypeSøg.SøgSpecifiktMaterialetypeFriTeskt(this);

            //}

            //else if (MatriealetypeBox.SelectedItem == null & PeriodeTPComboBox.SelectedItem == null)
            //{

            //    Emnetypesøg.SøgSpecifiktEmnetyperFriTeskt(this);
            //}

            //else if (MatriealetypeBox.SelectedItem == null & comboEmnetyper.SelectedItem == null)
            //{

            //    PeriodetypeSøg.SøgFritekstPeriode(this);
            //}

            //else if (MatriealetypeBox.SelectedItem == null & comboEmnetyper.SelectedItem == null & PeriodeTPComboBox.SelectedItem == null)
            //{

            //    årstalOprettetafsluttet.SøgÅrstaloprettetFrit(this);
            //}


            //else if (comboEmnetyper.SelectedItem == null & PeriodeTPComboBox.SelectedItem == null & MatriealetypeBox.SelectedItem == null & textBoxFrisøgning.Text == null)
            //{


            //    årstalOprettetafsluttet.SøgÅrstalAfsluttet(this);
            //}

            //else if (textBoxFrisøgning.Text.Length == 0)
            //{

            //    sagstitelSøgdb.søgComboBox(this);


            //}


            //årstalOprettetafsluttet.SøgÅrstaloprettetFrit(this);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            var filComboboxFraDb = new FillComboBoxFromDB();
            filComboboxFraDb.FillMaterielTypeComboBox(this);


            filComboboxFraDb.FillEmnetypeComboBox(this);

         
            filComboboxFraDb.FillPeriodeCombobox(this);


            filComboboxFraDb.Eksperimenttyper(this);
        }

        private void søgMaterialetyper_Click(object sender, EventArgs e)
        {
            var materialesøgDB = new MaterialetypeSøg();
            materialesøgDB.SøgSpecifiktMaterialetypeFriTeskt(this);
        }

        private void textBox1Søg_TextChanged(object sender, EventArgs e)
        {
            //var FriTekstSøgDB = new SagstitelSøgDB();
            //FriTekstSøgDB.SagstitelSøgFritekst(this);
        }

        private void BtFritekstsøg_Click(object sender, EventArgs e)
        {
            var sagstitelSøgdb = new SagstitelSøgDB();
            sagstitelSøgdb.SagstitelSøgFritekst(this);
        }

        private void PeriodeTPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var PeriodetypeSøg = new PeriodetyperSøgDB();

            PeriodetypeSøg.SøgFritekstPeriode(this);
        }

        private void comboEmnetyper_SelectedIndexChanged(object sender, EventArgs e)
        {
            var emnetypesøg = new EmnetypeSøgDB();
            emnetypesøg.SøgSpecifiktEmnetyperFriTeskt(this);
        }

        private void MatriealetypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var MeterialetypeSøg = new MaterialetypeSøg();
            MeterialetypeSøg.SøgSpecifiktMaterialetypeFriTeskt(this);
        }

        private void textBoxSagoprettet_TextChanged(object sender, EventArgs e)
        {
        }

        private void EksperimenttyperComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ekspermenttypesøgfri = new EksperimenttyperSøgDB();
            ekspermenttypesøgfri.EksperimentTyperSøgDbFRi(this);
        }
    }
}