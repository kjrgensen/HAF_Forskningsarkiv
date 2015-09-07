using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ForskningsArkiv.ConnectionDB
{
    public class DB
    {
        //private SqlConnection constring;
        //private SqlCommand cmd1;
        //private SqlDataAdapter da;
        //public SearchForm sf;
        //private ListBox ListBox1;

        public string DbConnectionString =
            "Data Source=DESKTOP-8MJDH1B\\SQLEXPRESS;Initial Catalog=Sagnlandet;Integrated Security=True";

     


        //select tblEmnetyper.emnetype,tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper
        public void EmnetyperSøgFritekst(SearchForm searchForm)
        {

            var constring = new SqlConnection(DbConnectionString);

            constring.Open();

           
                var sqlDataAdapter =
              new SqlDataAdapter(
                  "Select tblSagsoplysninger.sagens_titel,tblEmnetyper.emnetype,tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper where sagens_titel " + " like '%" +
                  searchForm.textBox1Søg.Text + "%'",
                  constring);

                var datatable = new DataTable();
                sqlDataAdapter.Fill(datatable);
                searchForm.dataGridView1.DataSource = datatable;
           
        }

        public void SøgSpecifiktEmnetyperFriTeskt(SearchForm searchForm)
        {
            
                var constring = new SqlConnection(DbConnectionString);

                constring.Open();


                var sqlDataAdapter1 =
                new SqlDataAdapter(

                   "Select tblEmnetyper.emnetype, tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper" +
                   " where emnetype='" + searchForm.comboBox1.SelectedItem + "' and tblSagsoplysninger.sagens_titel like'" + searchForm.textBox2Emnetyper.Text + "%'"
                 ,
                 constring);

                var datatable1 = new DataTable();
                sqlDataAdapter1.Fill(datatable1);
            if (datatable1.Rows.Count ==0)
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



        // Select tblEmnetyper.emnetype, tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper
        //    where emnetype= 'Mad' and sagens_titel = 'Klima-litteratur';

        //     like'%" +
        // searchForm.textBox2Emnetyper.Text.ToString() + "%' and" + searchForm.comboBoxEmnetyper.Text

        //   "Select tblEmnetyper.emnetype,tblEmnetyper.emneID, tblEmnetyper.beskrivelse, tblSagsoplysninger.sagens_titel, tblSagsoplysninger.journalNr from tblSagsoplysninger, tblEmnetyper where sagens_titel like '%" +
        // searchForm.textBox2Emnetyper.Text + "%' OR sagens_titel like '%" + searchForm.textBox2Emnetyper.Text +
        // "%'",



        public void FillEmnetypeComboBox(SearchForm searchForm)
        {
            var constring = new SqlConnection(DbConnectionString);

            constring.Open();

            var SqlDataAdapterEm = new SqlDataAdapter("select * from tblEmnetyper order by emnetype", constring);

            var datatableCmEm = new DataTable();

            SqlDataAdapterEm.Fill(datatableCmEm);

            for (int i = 0; i < datatableCmEm.Rows.Count; i++)
            {
                searchForm.comboBox1.Items.Add(datatableCmEm.Rows[i]["emnetype"]);
            }
            constring.Close();
        }
    }
}