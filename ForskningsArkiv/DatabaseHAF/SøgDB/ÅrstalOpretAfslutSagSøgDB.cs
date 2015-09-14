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
  public  class ÅrstalOpretAfslutSagSøgDB
    {
        public DBConnectionstring _db;

      public void SøgÅrstaloprettetFrit(SearchForm searchForm)
      {
          _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();

           // searchForm.dateTimePickerOprettet.Format = DateTimePickerFormat.Custom;
           //searchForm.dateTimePickerOprettet.CustomFormat = "dd-MM-yyyy";

            var sqlDataAdapter1 =
                new SqlDataAdapter(
                    "Select tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblSagsoplysninger.dato_oprettet, tblSagsoplysninger.dato_afsluttet from tblSagsoplysninger" +
                    " where dato_oprettet='" + searchForm.textBoxSagoprettet.Text +"'"
              
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

      public void SøgÅrstalAfsluttet(SearchForm searchForm)
      {

            _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();

            //searchForm.dateTimePickerAfslut.Format = DateTimePickerFormat.Custom;
            //searchForm.dateTimePickerAfslut.CustomFormat = "dd-MM-yyyy";

            var sqlDataAdapter1 =
                new SqlDataAdapter(
                    "Select tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblSagsoplysninger.dato_oprettet, tblSagsoplysninger.dato_afsluttet from tblSagsoplysninger" +
                    " where dato_afsluttet='" + searchForm.textBoxsagAfsluttet.Text +
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

      public void ÅrstalSøgBetween(SearchForm searchForm)
      {

            _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();

            //searchForm.dateTimePickerOprettet.Format = DateTimePickerFormat.Custom;
            //searchForm.dateTimePickerOprettet.CustomFormat = "dd-MM-yyyy";

            //searchForm.dateTimePickerAfslut.Format = DateTimePickerFormat.Custom;
            //searchForm.dateTimePickerAfslut.CustomFormat = "dd-MM-yyyy";

            var sqlDataAdapter1 =
                new SqlDataAdapter(
                    "Select tblEmnetyper.emnetype, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr, tblSagsoplysninger.dato_oprettet, tblSagsoplysninger.dato_afsluttet ,tblMaterialetyper.materialetype from tblSagsoplysninger, tblEmnetyper, tblMaterialetyper" +
                    " 'where dato_oprettet" + searchForm.textBoxSagoprettet.Text + "%'" + "' and dato.afsluttet "+ searchForm.textBoxsagAfsluttet.Text + "%'" + 
                    "' and tblSagsoplysninger.sagens_titel like" + searchForm.textboxSagstitel.Text + "%'"
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
