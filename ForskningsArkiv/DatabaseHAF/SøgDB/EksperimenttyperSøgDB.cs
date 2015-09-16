using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForskningsArkiv.ConnectionDB;

namespace ForskningsArkiv.DatabaseHAF.SøgDB
{
   public class EksperimenttyperSøgDB
    {
        public DBConnectionstring _db;

       public void EksperimentTyperSøgDbFRi(SearchForm searchForm)
       {
            _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();

            var sqlDataAdapter1 =
                new SqlDataAdapter(
                    "Select tblEksperimenttyper.eksperimenttype, tblMaterialetyper.materialetype, tblMaterialetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblMaterialetyper, tblEksperimenttyper " +
                    " where eksperimenttype='" + searchForm.EksperimenttyperComboBox.SelectedItem +
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

    }
}
