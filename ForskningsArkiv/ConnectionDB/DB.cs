using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
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


        public void connection(SearchForm seachform)
        {
            SqlConnection constring = new SqlConnection(
                   "Data Source=HERPRIT\\SQLEXPRESS;Initial Catalog=Forskningsarkiv(Sagnlandet);Persist Security Info=True;User ID=sa;Password=titan");
            constring.Open();

            MessageBox.Show("connected");

            SqlDataAdapter da = new SqlDataAdapter("SELECT * From tblEmnetyper", constring);

            DataTable emnetyperDT = new DataTable();
            da.Fill(emnetyperDT);

            SearchForm sf = new SearchForm();

            seachform.dataGridView1.DataSource = emnetyperDT;
           

            
            //viser emnetype og beskrivelse i listbox
            foreach (DataRow row in emnetyperDT.Rows)
            {
             
               seachform.ListBox1.Items.Add("EmneTyper: " + row["emnetype"].ToString());
              seachform.ListBox1.Items.Add("Beskrivelse: " + row["beskrivelse"].ToString());

            }
         
            seachform.ListBox1.Update();
        

           
        }

      

     


    }
}
