using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataView customerDataView;
        DataView currencyDataView;

        private void Form1_Load(object sender, EventArgs e)
        {
            customerTableAdapter1.Fill(adventureWorks2019DataSet1.Customer);
            currencyTableAdapter1.Fill(adventureWorks2019DataSet1.Currency);

            customerDataView = new DataView(adventureWorks2019DataSet1.Customer);
            currencyDataView = new DataView(adventureWorks2019DataSet1.Currency);
            customerDataView.Sort = "CustomerID";
            dataGridView1.DataSource = customerDataView;

        }

        private void SetDataViewPropertiesButton_Click(object sender, EventArgs e)
        {
            customerDataView.Sort = SortTextBox.Text;
            customerDataView.RowFilter = FilterTextBox.Text;

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            DataRowView newCustomRow = customerDataView.AddNew();
            newCustomRow["CustomerID"] = "500";
            newCustomRow["Name"] = "Elvis";
            newCustomRow.EndEdit();
        }

        private void GetCurrencyButton_Click(object sender, EventArgs e)
        {
            string selectedCustomerID = (string)dataGridView2.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
            DataRowView selectedRow = customerDataView[customerDataView.Find(selectedCustomerID)];
            currencyDataView = selectedRow.CreateChildView(adventureWorks2019DataSet1.Relations ["FK_Currency_Customers"]);
            dataGridView2.DataSource = currencyDataView;

        }
    }
}
