using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

            //clear combo hvis man ønsker søge fritekst
            searchForm.comboEmnetyper.ResetText();
            searchForm.PeriodeTPComboBox.ResetText();
            searchForm.MatriealetypeBox.ResetText();

            //var søgfri =
            //    " Select tblEmnetyper.emnetype, tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblMaterialetyper.materialetype from tblSagsoplysninger, tblEmnetyper, tblMaterialetyper " +
            //    "where sagens_titel like'" + searchForm.textBoxFrisøgning.Text + "%'";

            //var SøgFriCmd = new SqlCommand(søgfri, constring);
            //sqlDataAdapter1.SelectCommand = SøgFriCmd;



            var sqlDataAdapter1 =
                new SqlDataAdapter(
                    "Select tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblSagsoplysninger.dato_oprettet, tblSagsoplysninger.dato_afsluttet, tblSagsoplysninger.sags_placering from tblSagsoplysninger " +
                    "where sagens_titel like'" + searchForm.textBoxFrisøgning.Text + "%'", constring);
         

            var datatable = new DataTable();
       
            sqlDataAdapter1.Fill(datatable);

            if (datatable.Rows.Count == 0)
            {
                MessageBox.Show("Ingen rapporter fundet");
            }
            else
            {
                MessageBox.Show("fundet =" + datatable.Rows.Count);
            }

            searchForm.dataGridView1.DataSource = datatable;


            constring.Close();
        }

        public void søgComboBox(SearchForm searchForm)
        {
            _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();


            var ComboSøg =
                "Select tblEmnetyper.emnetype, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblMaterialetyper.materialetype, tblPeriodetyper.periodetype from tblSagsoplysninger, tblEmnetyper, tblMaterialetyper, tblPeriodetyper" +
                " where emnetype='" + searchForm.comboEmnetyper.Text +
                "'and materialetype='" + searchForm.MatriealetypeBox.Text +
                "'and periodetype='" + searchForm.PeriodeTPComboBox.Text +
                "' and tblSagsoplysninger.sagens_titel like'" + searchForm.textboxSagstitel.Text + "%'";

            var sqlcom = new SqlCommand(ComboSøg, constring);

            var sqlAdapter = new SqlDataAdapter();

            sqlAdapter.SelectCommand = sqlcom;

            var datatable = new DataTable();

            sqlAdapter.Fill(datatable);

            searchForm.dataGridView1.DataSource = datatable;
            constring.Close();
        }
    }
}

//tblSagsoplysninger.sagens_titel like'" + searchForm.textBox1Søg.Text + "%'"
//emnetype='" + searchForm.comboBox1.SelectedItem