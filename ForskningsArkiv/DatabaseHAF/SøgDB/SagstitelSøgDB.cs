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
            //searchForm.comboEmnetyper.ResetText();
            //searchForm.PeriodeTPComboBox.ResetText();
            //searchForm.MatriealetypeBox.ResetText();

            var sqlDataAdapter1 =
                new SqlDataAdapter(
                    "select tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblKontaktpersoner.fornavn, tblKontaktpersoner.efternavn, tblEmnetyper.emnetype, tblEksperimenttyper.eksperimenttype, tblMaterialetyper.materialetype, tblSagsoplysningerEmnetyperLink.sagsIDref from tblSagsoplysninger " +
                    "join tblKontaktpersoner on tblSagsoplysninger.kontaktpersonIDref=tblKontaktpersoner.kontaktpersonID " +
                    "join tblSagsoplysningerEmnetyperLink on tblSagsoplysninger.sagsID=tblSagsoplysningerEmnetyperLink.sagsIDref " +
                    "join tblEmnetyper " +
                    "on tblSagsoplysningerEmnetyperLink.emneIDref=tblEmnetyper.emneID " +
                    "join tblSagsoplysningerMaterialetyperLink " +
                    "on tblSagsoplysninger.sagsID=tblSagsoplysningerMaterialetyperLink.sagsIDref " +
                    "join tblMaterialetyper " +
                    "on tblSagsoplysningerMaterialetyperLink.materialeIDref=tblMaterialetyper.materialeID " +                  
                    "join tblSagsoplysningerEksperimenttyperLink on tblSagsoplysninger.sagsID=tblSagsoplysningerEksperimenttyperLink.sagsIDref " +
                    "join tblEksperimenttyper " +
                    "on tblSagsoplysningerEksperimenttyperLink.eksperimentIDref=tblEksperimenttyper.eksperimentID " +
                    "where sagens_titel " +
                    "like '%" + searchForm.textBoxFrisøgning.Text +"%'" +
                    "or fornavn like'%"+ searchForm.textBoxFrisøgning.Text +"%'" +
                    "or efternavn like'%"+ searchForm.textBoxFrisøgning.Text +"%'" +
                    "or emnetype like'%"+ searchForm.textBoxFrisøgning.Text +"%'"+
                    "or materialetype like'%"+ searchForm.textBoxFrisøgning.Text +"%'"+
                    "or eksperimenttype like'%"+ searchForm.textBoxFrisøgning.Text +"%'"
                    , constring);

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