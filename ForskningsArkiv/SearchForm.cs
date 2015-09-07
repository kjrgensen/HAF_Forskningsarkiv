﻿using System;
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
            var form1 = new Form1();
            form1.Show();

            Close();
        }


        private void buttonSøgFri_Click(object sender, EventArgs e)
        {
            _db = new DB();
            _db.EmnetyperSøgFritekst(this);
        }

        private void button2Emnetyper_Click(object sender, EventArgs e)
        {
            _db = new DB();

            _db.SøgSpecifiktEmnetyperFriTeskt(this);


        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            _db = new DB();
            _db.FillEmnetypeComboBox(this);
        }

        private void comboBoxEmnetyper_MouseClick(object sender, MouseEventArgs e)
        {
        }

       
    }
}