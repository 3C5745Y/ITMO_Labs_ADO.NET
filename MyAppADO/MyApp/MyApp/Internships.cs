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
            // TODO: This line of code loads data into the 'internshipsDataSet.Interns' table. You can move, or remove it, as needed.
            this.internsTableAdapter.Fill(this.internshipsDataSet.Interns);
            internsTableAdapter1.Fill(this.myAppDataSet.Interns);
            projectsTableAdapter1.Fill(this.myAppDataSet.Projects);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string cmd_text;
                Input f2 = new Input();

                if (f2.ShowDialog() == DialogResult.OK)
                {//изменить на параметры?
                    cmd_text = "INSERT INTO dbo.Interns VALUES (" + "'" + f2.firstNameTextBox.Text + "' , '" +
                    f2.lastNameTextBox.Text + "' , '" +
                    f2.UniTextBox.Text + "' , '" +
                    f2.MailTextBox.Text + "')";

                    // изменить на using
                    //SqlConnection sql_conn = new SqlConnection(connection);
                   
                    SqlCommand sql_comm = new SqlCommand(cmd_text, connection);

                    //не отображает сразу данные введенные ??
                    try
                    {
                        connection.Open();
                        sql_comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    this.internsTableAdapter.Fill(this.internshipsDataSet.Interns);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //string cmd_text;
            //Input f2 = new Input();
            //int index;
            //string firstName;

            //index = InternsDataGridView.CurrentRow.Index;
            //firstName = Convert.ToString(InternsDataGridView[0, index].Value);

            //f2.firstNameTextBox.Text = firstName;
            //f2.lastNameTextBox.Text = Convert.ToString(InternsDataGridView[1, index].Value);
            //f2.UniTextBox.Text = Convert.ToString(InternsDataGridView[2, index].Value);
            //f2.MailTextBox.Text = Convert.ToString(InternsDataGridView[3, index].Value);

            //if (f2.ShowDialog() == DialogResult.OK)
            //{
            //    cmd_text = "UPDATE dbo.Interns SET FirstName = '" + f2.firstNameTextBox.Text + "', '" +
            //    "'[LastName] = '" + f2.lastNameTextBox.Text + "', '" +
            //    "'[University] = '" + f2.UniTextBox.Text + "', '" +
            //    "'Email = '" + f2.MailTextBox.Text +
            //    "WHERE FirstName = '" + firstName + "'";

            //    SqlConnection sql_conn = new SqlConnection(connection);
            //    SqlCommand sql_comm = new SqlCommand(cmd_text, sql_conn);

            //    sql_conn.Open();
            //    sql_comm.ExecuteNonQuery();
            //    sql_conn.Close();

            //    this.internsTableAdapter.Fill(this.internshipsDataSet.Interns);

            //}
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            //string cmd_text = "DELETE FROM dbo.Interns";
            //int index;
            //string firstName;

            //index = InternsDataGridView.CurrentRow.Index;
            //firstName = Convert.ToString(InternsDataGridView[0, index].Value);
            //cmd_text = "DELETE FROM dbo.Interns WHERE [Interns].[FirstName] = '" + firstName + "'";

            //SqlConnection sql_conn = new SqlConnection(connection);
            //SqlCommand sql_comm = new SqlCommand(cmd_text, sql_conn);

            //sql_conn.Open();
            //sql_comm.ExecuteNonQuery();
            //sql_conn.Close();

            //this.internsTableAdapter.Fill(this.internshipsDataSet.Interns);

        }

        private void MentorsButton_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = mentorsInternsDataSet1.Mentors_Interns;
            sqlDataAdapter2.Fill(mentorsInternsDataSet1.Mentors_Interns);
        }
    }
}
