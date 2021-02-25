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

namespace MyApp
{
    public partial class Internships : Form
    {
        string connectionstring = @"Data Source = B232\SQLEXPRESS;Initial Catalog = Internships; Integrated Security = True";

        public Internships()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    this.internsTableAdapter1.Fill(this.myAppDataSet.Interns);
                    this.projectsTableAdapter1.Fill(this.myAppDataSet.Projects);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Input f2 = new Input();

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string cmd_text = "INSERT INTO dbo.Interns(FirstName, LastName, University, Email)" +
                    " VALUES (@firstName, @lastName, @university, @email)";

                if (f2.ShowDialog() == DialogResult.OK)
                {

                    SqlCommand command = new SqlCommand(cmd_text, connection);
                    command.Parameters.AddWithValue("@FirstName", f2.firstNameTextBox.Text);
                    command.Parameters.AddWithValue("@lastName", f2.lastNameTextBox.Text);
                    command.Parameters.AddWithValue("@university", f2.UniTextBox.Text);
                    command.Parameters.AddWithValue("@email", f2.MailTextBox.Text);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        this.internsTableAdapter1.Fill(this.myAppDataSet.Interns);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Input f2 = new Input();
            int index;
            string firstName;

            index = InternsDataGridView.CurrentRow.Index;
            firstName = Convert.ToString(InternsDataGridView[1, index].Value);
            f2.firstNameTextBox.Text = firstName;
            f2.lastNameTextBox.Text = Convert.ToString(InternsDataGridView[2, index].Value);
            f2.UniTextBox.Text = Convert.ToString(InternsDataGridView[3, index].Value);
            f2.MailTextBox.Text = Convert.ToString(InternsDataGridView[4, index].Value);

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string cmd_text = "UPDATE dbo.Interns SET FirstName = @firstname, LastName = @lastname, University = @university, Email = @email WHERE FirstName = '" + firstName + "'";

                if (f2.ShowDialog() == DialogResult.OK)
                {
                    SqlCommand command = new SqlCommand(cmd_text, connection);
                    command.Parameters.AddWithValue("@FirstName", f2.firstNameTextBox.Text);
                    command.Parameters.AddWithValue("@lastName", f2.lastNameTextBox.Text);
                    command.Parameters.AddWithValue("@university", f2.UniTextBox.Text);
                    command.Parameters.AddWithValue("@email", f2.MailTextBox.Text);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        this.internsTableAdapter1.Fill(this.myAppDataSet.Interns);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            int index;
            string firstName;

            index = InternsDataGridView.CurrentRow.Index;
            firstName = Convert.ToString(InternsDataGridView[1, index].Value);
            string cmd_text = "DELETE FROM dbo.Interns WHERE FirstName = '" + firstName + "'";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {

                SqlCommand command = new SqlCommand(cmd_text, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    this.internsTableAdapter1.Fill(this.myAppDataSet.Interns);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ShowMentorsInternsbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    dataGridView3.DataSource = mentorsInternsDataSet1.MentorsInterns;
                    this.sqlDataAdapter3.Fill(this.mentorsInternsDataSet1.MentorsInterns);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}