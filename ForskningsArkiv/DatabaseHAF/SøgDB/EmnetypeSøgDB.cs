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
                    "Select tblEmnetyper.emnetype, tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper" +
                    " where emnetype='" + searchForm.comboBox1.SelectedItem +
                    "' and tblSagsoplysninger.sagens_titel like'" + searchForm.textBox2Emnetyper.Text + "%'"
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
            searchForm.Refresh();
        }

        //udfyld combobox med Emnetyper fra DB
        public void FillEmnetypeComboBox(SearchForm searchForm)
        {
            _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();

            var SqlDataAdapterEm = new SqlDataAdapter("select * from tblEmnetyper order by emnetype", constring);

            var datatableCmEm = new DataTable();

            SqlDataAdapterEm.Fill(datatableCmEm);

            for (var i = 0; i < datatableCmEm.Rows.Count; i++)
            {
                searchForm.comboBox1.Items.Add(datatableCmEm.Rows[i]["emnetype"]);
            }
            constring.Close();
        }
    }
}