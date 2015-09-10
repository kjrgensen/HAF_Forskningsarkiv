using System.Data;
using System.Data.SqlClient;
using System.Text;

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

            string søgfri =
                " Select tblEmnetyper.emnetype, tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblMaterialetyper.materialetype from tblSagsoplysninger, tblEmnetyper, tblMaterialetyper " +
                "where sagens_titel like'" + searchForm.textBox1Søg.Text + "%'";

           
            SqlCommand cmd = new SqlCommand(søgfri,constring);
           

            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();

            //var sqlDataAdapter1 =
            //     new SqlDataAdapter(

            //         "Select tblEmnetyper.emnetype, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblMaterialetyper.materialetype, tblPeriodetyper.periodetype from tblSagsoplysninger, tblEmnetyper, tblMaterialetyper, tblPeriodetyper" +
            //         " where emnetype='" + searchForm.comboBox1.Text +
            //         "'and materialetype='" + searchForm.MatriealetypeBox.Text +
            //         "'and periodetype='" + searchForm.PeriodeTPComboBox.Text +
            //         "' and tblSagsoplysninger.sagens_titel like'" + searchForm.textBox1Søg.Text + "%'"

            //         , constring
            //        );

            sqlDataAdapter1.SelectCommand = cmd;
        
            var datatable = new DataTable();

            sqlDataAdapter1.Fill(datatable);
        
            searchForm.dataGridView1.DataSource = datatable;
        
           
            //constring.Close();
        }

        public void søgComboBox(SearchForm searchForm)
        {

            _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();


            string ComboSøg =
                "Select tblEmnetyper.emnetype, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblMaterialetyper.materialetype, tblPeriodetyper.periodetype from tblSagsoplysninger, tblEmnetyper, tblMaterialetyper, tblPeriodetyper" +
                " where emnetype='" + searchForm.comboEmnetyper.Text +
                "'and materialetype='" + searchForm.MatriealetypeBox.Text +
                "'and periodetype='" + searchForm.PeriodeTPComboBox.Text +
                "' and tblSagsoplysninger.sagens_titel like'" + searchForm.textBox1Søg.Text + "%'";




            SqlCommand sqlcom = new SqlCommand(ComboSøg, constring);

            SqlDataAdapter sqlAdapter = new SqlDataAdapter();

            sqlAdapter.SelectCommand = sqlcom;

            var datatable = new DataTable();

            sqlAdapter.Fill(datatable);

            searchForm.dataGridView1.DataSource = datatable;
            //constring.Close();
        }


    }
}

//tblSagsoplysninger.sagens_titel like'" + searchForm.textBox1Søg.Text + "%'"
//emnetype='" + searchForm.comboBox1.SelectedItem