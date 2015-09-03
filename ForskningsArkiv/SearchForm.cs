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
        private DB _db;

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

            _db = new DB();
            _db.connection(this);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.dataGridView1.DataError += dataGridView1_DataError;
            //dataGridView1

            _db = new DB();
            _db.SøgiTabel(this);

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
         
            MessageBox.Show("Error happened " + anError.Context.ToString());

            //if (anError.Context == DataGridViewDataErrorContexts.Commit)
            //{
            //    MessageBox.Show("Commit error");
            //}
            //if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            //{
            //    MessageBox.Show("Cell change");
            //}
            //if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            //{
            //    MessageBox.Show("parsing error");
            //}
            //if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            //{
            //    MessageBox.Show("leave control error");
            //}

            //if ((anError.Exception) is ConstraintException)
            //{
            //    DataGridView view = (DataGridView) sender;
            //    view.Rows[anError.RowIndex].ErrorText = "an error";
            //    view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

            //    anError.ThrowException = false;


            }


        }


    }

