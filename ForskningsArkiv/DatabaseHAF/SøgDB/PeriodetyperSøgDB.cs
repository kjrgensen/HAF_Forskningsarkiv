using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForskningsArkiv.ConnectionDB;

namespace ForskningsArkiv.DatabaseHAF.SøgDB
{
   public class PeriodetyperSøgDB
    {

       public DBConnectionstring _db;
        public void SøgFritekstPeriode(SearchForm searchForm)
       {

            _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();

            var sqlDataAdapter1 =
                new SqlDataAdapter(
                    "Select tblEmnetyper.emnetype, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblMaterialetyper.materialetype, tblPeriodetyper.periodetype from tblSagsoplysninger, tblEmnetyper, tblMaterialetyper, tblPeriodetyper" +
                    " where periodetype='" + searchForm.PeriodeTPComboBox.SelectedItem +
                    "' and tblSagsoplysninger.sagens_titel like'" + searchForm.textboxSagstitel.Text + "%'"
                    ,
                    constring);

            var datatable1 = new DataTable();
            sqlDataAdapter1.Fill(datatable1);

            //if (datatable1.Rows.Count == 0)
            //{
            //    MessageBox.Show("Ingen rapporter fundet");
            //}
            //else
            //{
            //    MessageBox.Show("fundet =" + datatable1.Rows.Count);
            //}


            searchForm.dataGridView1.DataSource = datatable1;
            searchForm.Refresh();
        }
    }
}
