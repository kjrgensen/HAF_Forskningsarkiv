using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForskningsArkiv.ConnectionDB;

namespace ForskningsArkiv
{
    public partial class SearchForm : Form
    {
        private DB d;
        public ListBox _listBox; 
       
        
        
        public SearchForm()
        {
            InitializeComponent();
            //DB d = new DB();
            //d.connection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            d = new DB();
            d.connection(this);

            //SqlConnection constring = new SqlConnection(
            //   "Data Source=HERPRIT\\SQLEXPRESS;Initial Catalog=Forskningsarkiv(Sagnlandet);Persist Security Info=True;User ID=sa;Password=titan");
            //constring.Open();

            //MessageBox.Show("connected");

            //SqlDataAdapter da = new SqlDataAdapter("SELECT * From tblEmnetyper" , constring);

            //DataTable emnetyperDT = new DataTable();
            //da.Fill(emnetyperDT);
            
            ////Datagrid
            //dataGridView1.DataSource = emnetyperDT;
  
            ////viser emnetype og beskrivelse i listbox
            //foreach (DataRow row in emnetyperDT.Rows)
            //{
            //    ListBox1.Items.Add("EmneTyper: " + row["emnetype"].ToString());
            //    ListBox1.Items.Add("Beskrivelse: " + row["beskrivelse"].ToString());
            //    //AutoItem.Add(row["beskrivelse"].ToString());

            //}

        }

    

    }

 
}
