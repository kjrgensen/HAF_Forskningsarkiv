using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ForskningsArkiv.ConnectionDB
{
    public class DBConnectionstring
    {
        //private SqlConnection constring;
        //private SqlCommand cmd1;
        //private SqlDataAdapter da;
        //public SearchForm sf;
        //private ListBox ListBox1;

        public string DbConnectionString = "Data Source=DESKTOP-FOS4ILV\\SQLEXPRESS;Initial Catalog=DBHAF;Integrated Security=True";

        //select tblEmnetyper.emnetype,tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper
        //public void SagstitelSøgFritekst(SearchForm searchForm)
    
        //}

        // Select tblEmnetyper.emnetype, tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper
        //    where emnetype= 'Mad' and sagens_titel = 'Klima-litteratur';

        //     like'%" +
        // searchForm.textBox2Emnetyper.Text.ToString() + "%' and" + searchForm.comboBoxEmnetyper.Text

        //   "Select tblEmnetyper.emnetype,tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper where sagens_titel like '%" +
        // searchForm.textBox2Emnetyper.Text + "%' OR sagens_titel like '%" + searchForm.textBox2Emnetyper.Text +
        // "%'",


        
    }
}