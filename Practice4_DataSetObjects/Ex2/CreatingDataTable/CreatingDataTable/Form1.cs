using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingDataTable
{
    public partial class Form1 : Form
    {
        private DataTable PersonTable = new DataTable("Person");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TableGrid.DataSource = PersonTable;
            PersonTable.Columns.Add("BusinessEntityID", Type.GetType("System.String"));
            PersonTable.Columns.Add("PersonType", Type.GetType("System.String"));
            PersonTable.Columns.Add("NameStyle", Type.GetType("System.String"));
            PersonTable.Columns.Add("Title", Type.GetType("System.String"));
            PersonTable.Columns.Add("FirstName", Type.GetType("System.String"));
            PersonTable.Columns.Add("MiddleName", Type.GetType("System.String"));
            PersonTable.Columns.Add("LastName", Type.GetType("System.String"));
            PersonTable.Columns.Add("Suffix", Type.GetType("System.String"));
            PersonTable.Columns.Add("EmailPromotion", Type.GetType("System.String"));
            PersonTable.Columns.Add("AdditionalContactInfo", Type.GetType("System.String"));
            PersonTable.Columns.Add("Demographics", Type.GetType("System.String"));
            PersonTable.Columns.Add("rowguid", Type.GetType("System.String"));
            PersonTable.Columns.Add("ModifiedDate", Type.GetType("System.String"));
            PersonTable.Columns.Add("iuPerson", Type.GetType("System.String"));

            DataColumn[] KeyColumns = new DataColumn[1];
            KeyColumns[0] = PersonTable.Columns["BusinessEntityID"];
            PersonTable.PrimaryKey = KeyColumns;

            PersonTable.Columns["BusinessEntityID"].AllowDBNull = false;
            PersonTable.Columns["PersonType"].AllowDBNull = false;
            PersonTable.Columns["FirstName"].AllowDBNull = false;

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            DataRow CustRow = PersonTable.NewRow();
            Object[] CustRecord =  {"ALFKI", "Alfreds Futterkiste", "Maria Anders",
                "Sales Representative", "Obere Str. 57", "Berlin",
                  null, "12209", "Germany", "030-0074321","030-0076545"};
            CustRow.ItemArray = CustRecord;
            try
            {
                PersonTable.Rows.Add(CustRow);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
