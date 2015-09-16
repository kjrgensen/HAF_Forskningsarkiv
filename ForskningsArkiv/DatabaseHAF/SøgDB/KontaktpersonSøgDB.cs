using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ForskningsArkiv.ConnectionDB;

namespace ForskningsArkiv.DatabaseHAF.SøgDB
{
    public class KontaktpersonSøgDB
    {
        public DBConnectionstring _db;

        public void KontaktpersonSøg(SearchForm searchForm)
        {
            _db = new DBConnectionstring();

            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();

            var sqlDataAdapter1 =
                new SqlDataAdapter(
                    "Select tblKontaktpersoner.fornavn,tblKontaktpersoner.efternavn, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblSagsoplysninger.dato_oprettet, tblSagsoplysninger.dato_afsluttet, tblSagsoplysninger.sags_placering from tblSagsoplysninger, tblKontaktpersoner " +
                    "where fornavn like'%" + searchForm.textBoxKontaktperson.Text + "%'", constring);

            var datatable = new DataTable();

            sqlDataAdapter1.Fill(datatable);

            searchForm.dataGridView1.DataSource = datatable;


            var rows = searchForm.dataGridView1.RowCount;

            if (searchForm.dataGridView1.RowCount == 0)
            {
                MessageBox.Show("ingen rapporter fundet!");
            }
            else
            {
                MessageBox.Show("Fundet: " + rows);
            }

            constring.Close();

            searchForm.dataGridView1.Refresh();
        }
    }
}