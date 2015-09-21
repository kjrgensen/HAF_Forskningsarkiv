using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ForskningsArkiv.ConnectionDB.SpecifikationsSøgDB
{
    public class EmnetypeSøgDB
    {
        public DBConnectionstring _db;

        public void SøgSpecifiktEmnetyperFriTeskt(SearchForm searchForm)
        {
            _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();

            var sqlDataAdapter1 =
                new SqlDataAdapter(
                    "select tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblKontaktpersoner.fornavn, tblKontaktpersoner.efternavn, tblEmnetyper.emnetype, tblSagsoplysningerEmnetyperLink.sagsIDref from tblSagsoplysninger " +
                    "jOIN tblKontaktpersoner " +
                    "ON tblSagsoplysninger.kontaktpersonIDref = tblKontaktpersoner.kontaktpersonID " +
                    "join tblSagsoplysningerEmnetyperLink " +
                    "on tblSagsoplysninger.sagsID = tblSagsoplysningerEmnetyperLink.sagsIDref " +
                    "join tblEmnetyper " +
                    "on tblSagsoplysningerEmnetyperLink.emneIDref = tblEmnetyper.emneID " +
                    "where sagens_titel " +
                    "like'%" + searchForm.textboxSagstitel.Text + "%' and emnetype " +
                    "like'%" + searchForm.comboEmnetyper.Text + "%'"
                    ,
                    constring);

            var datatable1 = new DataTable();
            sqlDataAdapter1.Fill(datatable1);

            if (datatable1.Rows.Count == 0)
            {
                MessageBox.Show("Ingen rapporter fundet");
            }
            else
            {
                MessageBox.Show("fundet =" + datatable1.Rows.Count);
            }


            searchForm.dataGridView1.DataSource = datatable1;

            constring.Close();
            searchForm.Refresh();
        }
    }
}