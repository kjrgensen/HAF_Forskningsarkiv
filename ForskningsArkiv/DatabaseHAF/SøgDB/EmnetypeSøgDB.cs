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
                    "Select tblEmnetyper.emnetype, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblMaterialetyper.materialetype from tblSagsoplysninger, tblEmnetyper, tblMaterialetyper" +
                    " where emnetype='" + searchForm.comboEmnetyper.SelectedItem +                
                    "' and tblSagsoplysninger.sagens_titel like'" + searchForm.textboxSagstitel.Text + "%'"
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
   
    }
}