using System.Data;
using System.Data.SqlClient;
using ForskningsArkiv.ConnectionDB;

namespace ForskningsArkiv.DatabaseHAF.SøgDB
{
    public class FillComboBoxFromDB
    {
        public DBConnectionstring _db;

        public void FillEmnetypeComboBox(SearchForm searchForm)
        {
            _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();

            var SqlDataAdapterEm = new SqlDataAdapter("select * from tblEmnetyper order by emnetype", constring);

            var datatableCmEm = new DataTable();

            SqlDataAdapterEm.Fill(datatableCmEm);

            for (var i = 0; i < datatableCmEm.Rows.Count; i++)
            {
                searchForm.comboEmnetyper.Items.Add(datatableCmEm.Rows[i]["emnetype"]);
            }
            constring.Close();
        }

        public void FillMaterielTypeComboBox(SearchForm searchForm)
        {
            _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();

            var SqlDataAdapterEm = new SqlDataAdapter("select * from tblMaterialeTyper order by materialetype",
                constring);

            var datatableCmEm = new DataTable();

            SqlDataAdapterEm.Fill(datatableCmEm);

            for (var i = 0; i < datatableCmEm.Rows.Count; i++)
            {
                searchForm.MatriealetypeBox.Items.Add(datatableCmEm.Rows[i]["materialetype"]);
            }
            constring.Close();
        }

        public void FillPeriodeCombobox(SearchForm searchForm)
        {
            _db = new DBConnectionstring();
            var constring = new SqlConnection(_db.DbConnectionString);

            constring.Open();

            var SqlDataAdapterEm = new SqlDataAdapter("select * from tblPeriodetyper order by periodetype", constring);

            var datatableCmEm = new DataTable();

            SqlDataAdapterEm.Fill(datatableCmEm);

            for (var i = 0; i < datatableCmEm.Rows.Count; i++)
            {
                searchForm.PeriodeTPComboBox.Items.Add(datatableCmEm.Rows[i]["periodetype"]);
            }
            constring.Close();
        }
    }
}