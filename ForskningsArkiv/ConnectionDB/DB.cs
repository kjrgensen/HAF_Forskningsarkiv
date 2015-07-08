using System;
using System.Collections.Generic;
using System.Data;
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
        private SqlConnection constring;
        private SqlCommand cmd1;
        private SqlDataAdapter da;
    
        private Form1 f1;

        private SearchForm SF; 

        public void connection()
        {
           constring = new SqlConnection(
                "Data Source=HERPRIT\\SQLEXPRESS;Initial Catalog=Forskningsarkiv(Sagnlandet);Persist Security Info=True;User ID=sa;Password=titan");
            constring.Open();

            MessageBox.Show("connected");

            da = new SqlDataAdapter("SELECT * From tblEmnetyper", constring);
           
            DataTable emnetyper= new DataTable();
            da.Fill(emnetyper);
           
    
          


            //cmd1.Connection = constring;

            //dt = new DataTable();
            //da.Fill(dt);


            //cmd1 = new SqlCommand("SELECT * From tblEmnetyper", constring);


        }

        private void listBox1_SelectedIndexChanged()
        {
            throw new NotImplementedException();
        }


    }
}
