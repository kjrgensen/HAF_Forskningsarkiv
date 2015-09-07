using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ForskningsArkiv.ConnectionDB
{
    public class DB
    {
        //private SqlConnection constring;
        //private SqlCommand cmd1;
        //private SqlDataAdapter da;
        //public SearchForm sf;
        //private ListBox ListBox1;

        public string DbConnectionString =
            "Data Source=DESKTOP-FOS4ILV\\SQLEXPRESS;Initial Catalog=DBHAF;Integrated Security=True";

        //select tblEmnetyper.emnetype,tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper
        public void EmnetyperSøgFritekst(SearchForm searchForm)
        {
            var constring = new SqlConnection(DbConnectionString);

            constring.Open();


            var sqlDataAdapter =
                new SqlDataAdapter(
                    "Select tblSagsoplysninger.sagens_titel,tblEmnetyper.emnetype,tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper where sagens_titel " +
                    " like '%" +
                    searchForm.textBox1Søg.Text + "%'",
                    constring);

            var datatable = new DataTable();
            sqlDataAdapter.Fill(datatable);
            searchForm.dataGridView1.DataSource = datatable;
        }

        // Select tblEmnetyper.emnetype, tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper
        //    where emnetype= 'Mad' and sagens_titel = 'Klima-litteratur';

        //     like'%" +
        // searchForm.textBox2Emnetyper.Text.ToString() + "%' and" + searchForm.comboBoxEmnetyper.Text

        //   "Select tblEmnetyper.emnetype,tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper where sagens_titel like '%" +
        // searchForm.textBox2Emnetyper.Text + "%' OR sagens_titel like '%" + searchForm.textBox2Emnetyper.Text +
        // "%'",


        
    }
}