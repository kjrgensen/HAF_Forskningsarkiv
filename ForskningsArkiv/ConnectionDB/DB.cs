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

        public string DbConnectionString = "Data Source=HERPRIT\\SQLEXPRESS;Initial Catalog=Forskningsarkiv(Sagnlandet);Persist Security Info=True;User ID=sa;Password=titan";

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


        public void SøgiTabel(SearchForm seachform)
        {
            var constring = new SqlConnection(DbConnectionString);

            constring.Open();

            seachform.listBox2.Items.Clear();

            var sqlDataAdapter =
                new SqlDataAdapter(
                    "SELECT * from tblEmnetyper where emnetype like '%" + seachform.textBox1Søg.Text + "%'", constring);

            var emnetyperDT = new DataTable();
            sqlDataAdapter.Fill(emnetyperDT);

            seachform.dataGridView1.DataSource = emnetyperDT;

            //tilføjer til list2
            foreach (DataRow row in emnetyperDT.Rows)
            {
                seachform.listBox2.Items.Add("EmneTyper: " + row["emnetype"] +" : "+ row["beskrivelse"]);
            }
        }
    }
}