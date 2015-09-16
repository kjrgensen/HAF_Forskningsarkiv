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
                    " where dato_oprettet='%" + searchForm.textBoxSagoprettet.Text +"'"
              
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

            constring.Close();
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

            List<string> DatoOprettetList = new List<string>();

            //var sqlDataAdapter1 =
            //    new SqlDataAdapter(
            //         "Select tblSagsoplysninger.dato_oprettet from tblSagsoplysninger"
            //        ,
            //        constring);

            //var datatable1 = new DataTable();
            //sqlDataAdapter1.Fill(datatable1);

            //searchForm.dataGridView1.DataSource = datatable1;


            string query = "Select tblSagsoplysninger.dato_oprettet from tblSagsoplysninger";

            SqlCommand sqlcmd = new SqlCommand(query, constring);

            SqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {
                DatoOprettetList.Add(reader.GetString(0));
                
            }


          searchForm.dataGridView1.DataSource = DatoOprettetList;



            constring.Close();
            searchForm.Refresh();

            //Select* from tblSagsoplysninger where tblSagsoplysninger.dato_oprettet like '%1996%'

        }
    }
}
