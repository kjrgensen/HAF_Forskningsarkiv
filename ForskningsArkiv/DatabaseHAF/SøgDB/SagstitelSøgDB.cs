using System.Data;
using System.Data.SqlClient;

namespace ForskningsArkiv.ConnectionDB.SpecifikationsSøgDB
{
    public class SagstitelSøgDB
    {
        public DBConnectionstring _db;

        public void SagstitelSøgFritekst(SearchForm searchForm)
        {
            _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

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
    }
}