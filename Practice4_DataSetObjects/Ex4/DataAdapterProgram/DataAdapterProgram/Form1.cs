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

namespace DataAdapterProgram
{
    public partial class Form1 : Form
    {
        private SqlConnection AdvWorks2019connection = new SqlConnection(@"Data Source=B232\SQLEXPRESS;Initial Catalog=AdventureWorks2019;Integrated Security=True");
        private SqlDataAdapter SqlDataAdapter1;
        private DataSet AdventureWorks2019Dataset = new DataSet("AdventureWorks2019");
        private DataTable CultureTable = new DataTable("Culture");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM Production.Culture", AdvWorks2019connection);
            AdventureWorks2019Dataset.Tables.Add(CultureTable);
            SqlDataAdapter1.Fill(AdventureWorks2019Dataset.Tables["Culture"]);
            dataGridView1.DataSource = AdventureWorks2019Dataset.Tables["Culture"];
            SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapter1);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            AdventureWorks2019Dataset.EndInit();
            SqlDataAdapter1.Update(AdventureWorks2019Dataset.Tables["Culture"]);
        }
    }
}
