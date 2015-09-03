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

        public void connection(SearchForm seachform)
        {
            //    var constring = new SqlConnection(DbConnectionString);
            //    constring.Open();

            //    MessageBox.Show("connected");

            //    var da = new SqlDataAdapter("SELECT * From tblEmnetyper", constring);

            //    var emnetyperDT = new DataTable();
            //    da.Fill(emnetyperDT);


            //    //viser emnetype og beskrivelse i listbox
            //    foreach (DataRow row in emnetyperDT.Rows)
            //    {
            //        seachform.ListBox1.Items.Add("EmneTyper: " + row["emnetype"]);
            //        seachform.ListBox1.Items.Add("Beskrivelse: " + row["beskrivelse"]);
            //    }

            //    seachform.ListBox1.Update();
        }

        //
        public void SøgiTabel(SearchForm seachform)
        {
            var constring = new SqlConnection(DbConnectionString);

            constring.Open();

            //seachform.listBox1.Items.Clear();
            

            var sqlDataAdapter =
                new SqlDataAdapter(
                    "SELECT * from tblSagsoplysninger where journalNr like '%" + seachform.textBox1Søg.Text + "%'",
                    constring);

            var emnetyperDt = new DataTable();
            sqlDataAdapter.Fill(emnetyperDt);
            seachform.dataGridView1.DataSource = emnetyperDt;




            //var dataset = new DataSet();
            //sqlDataAdapter.Fill(dataset);
            //seachform.dataGridView1.DataSource = dataset.Tables[0];

            //tilføjer til list2
            //foreach (DataRow row in emnetyperDt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        seachform.listBox1.Items.Add(item);
            //    }
            //    //seachform.listBox1.Items.Add("KontaktPersoner: " + row["fornavn"] + " : " + row["efternavn"]);
            //}
        }




    }
    }
