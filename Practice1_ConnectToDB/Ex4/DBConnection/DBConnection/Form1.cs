﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();

        string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWorks2019;Data Source=B232\SQLEXPRESS";


        public Form1()
        {
            InitializeComponent();
            this.connection.StateChange += new System.Data.StateChangeEventHandler(this.connection_StateChange);
        }

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            connectToDbToolStripMenuItem1.Enabled =
                (e.CurrentState == ConnectionState.Closed);
            disconnectDbToolStripMenuItem1.Enabled =
                (e.CurrentState == ConnectionState.Open);
        }

        private void connectToDbToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch(OleDbException XcpSQL)
            {
                foreach(OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "SQL Error code" + se.NativeError, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch(Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void disconnectDbToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }
    }
}
