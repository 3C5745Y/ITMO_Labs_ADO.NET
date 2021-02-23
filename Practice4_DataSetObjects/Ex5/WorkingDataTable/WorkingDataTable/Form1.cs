using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkingDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = adventureWorks2019DataSet1.Currency;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void FillTableButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(adventureWorks2019DataSet1.Currency);

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            AdventureWorks2019DataSet.CurrencyRow NewRow = (AdventureWorks2019DataSet.CurrencyRow)adventureWorks2019DataSet1.Currency.NewRow();
            NewRow.CurrencyCode = "WINGT";
            NewRow.Name = "Wingtip Toys";

            try
            {
                adventureWorks2019DataSet1.Currency.Rows.Add(NewRow);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Row Failed");
            }

        }
        private AdventureWorks2019DataSet.CurrencyRow GetSelectedRow()
        {
            String SelectedCurrencyCode = dataGridView1.CurrentRow.Cells["CurrencyCode"].Value.ToString();
            AdventureWorks2019DataSet.CurrencyRow SelectedRow = adventureWorks2019DataSet1.Currency.FindByCurrencyCode(SelectedCurrencyCode);
            return SelectedRow;
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }

        private void UpdateRowVersionDisplay()
        {
            try
            {
                CurrentDRVTextBox.Text = GetSelectedRow()[dataGridView1.CurrentCell.OwningColumn.Name, DataRowVersion.Current].ToString();
            }
            catch (Exception ex)
            {
                CurrentDRVTextBox.Text = ex.Message;
            }
            try
            {
                OriginalDRVTextBox.Text = GetSelectedRow()[dataGridView1.CurrentCell.OwningColumn.Name, DataRowVersion.Original].ToString();
            }
            catch (Exception ex)
            {
                OriginalDRVTextBox.Text = ex.Message;
            }

            RowStateTextBox.Text = GetSelectedRow().RowState.ToString();

        }

        private void UpdateValueButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow()[dataGridView1.CurrentCell.OwningColumn.Name] = CellValueTextBox.Text;
            UpdateRowVersionDisplay();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            CellValueTextBox.Text = dataGridView1.CurrentCell.Value.ToString();
            UpdateRowVersionDisplay();

        }

        private void AcceptChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().AcceptChanges();
            UpdateRowVersionDisplay();

        }

        private void RejectChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().RejectChanges();
            UpdateRowVersionDisplay();

        }
    }
}
