
namespace MyApp
{
    partial class Internships
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Internships));
            this.internsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myAppDataSet = new MyApp.MyAppDataSet();
            this.fKProjectsInternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internsTableAdapter1 = new MyApp.MyAppDataSetTableAdapters.InternsTableAdapter();
            this.projectsTableAdapter1 = new MyApp.MyAppDataSetTableAdapters.ProjectsTableAdapter();
            this.myAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InternsDataGridView = new System.Windows.Forms.DataGridView();
            this.internIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.internsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.internsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter3 = new System.Data.SqlClient.SqlDataAdapter();
            this.ShowMentorsInternsbutton = new System.Windows.Forms.Button();
            this.mentorsInternsDataSet1 = new MyApp.MentorsInternsDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.internsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProjectsInternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAppDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InternsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorsInternsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // internsBindingSource
            // 
            this.internsBindingSource.DataMember = "Interns";
            this.internsBindingSource.DataSource = this.myAppDataSet;
            // 
            // myAppDataSet
            // 
            this.myAppDataSet.DataSetName = "MyAppDataSet";
            this.myAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKProjectsInternsBindingSource
            // 
            this.fKProjectsInternsBindingSource.DataMember = "FK_Projects_Interns";
            this.fKProjectsInternsBindingSource.DataSource = this.internsBindingSource;
            // 
            // internsTableAdapter1
            // 
            this.internsTableAdapter1.ClearBeforeFill = true;
            // 
            // projectsTableAdapter1
            // 
            this.projectsTableAdapter1.ClearBeforeFill = true;
            // 
            // myAppDataSetBindingSource
            // 
            this.myAppDataSetBindingSource.DataSource = this.myAppDataSet;
            this.myAppDataSetBindingSource.Position = 0;
            // 
            // InternsDataGridView
            // 
            this.InternsDataGridView.AllowUserToAddRows = false;
            this.InternsDataGridView.AllowUserToDeleteRows = false;
            this.InternsDataGridView.AutoGenerateColumns = false;
            this.InternsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.InternsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InternsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.internIdDataGridViewTextBoxColumn2,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.universityDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1});
            this.InternsDataGridView.DataSource = this.internsBindingSource;
            this.InternsDataGridView.GridColor = System.Drawing.SystemColors.HighlightText;
            this.InternsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.InternsDataGridView.Name = "InternsDataGridView";
            this.InternsDataGridView.ReadOnly = true;
            this.InternsDataGridView.Size = new System.Drawing.Size(579, 150);
            this.InternsDataGridView.TabIndex = 2;
     
            // 
            // internIdDataGridViewTextBoxColumn2
            // 
            this.internIdDataGridViewTextBoxColumn2.DataPropertyName = "InternId";
            this.internIdDataGridViewTextBoxColumn2.HeaderText = "InternId";
            this.internIdDataGridViewTextBoxColumn2.Name = "internIdDataGridViewTextBoxColumn2";
            this.internIdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // universityDataGridViewTextBoxColumn1
            // 
            this.universityDataGridViewTextBoxColumn1.DataPropertyName = "University";
            this.universityDataGridViewTextBoxColumn1.HeaderText = "University";
            this.universityDataGridViewTextBoxColumn1.Name = "universityDataGridViewTextBoxColumn1";
            this.universityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // internsBindingSource1
            // 
            this.internsBindingSource1.DataMember = "Interns";
            // 
             
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(53, 193);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(92, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add row";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(226, 193);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit row";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(395, 193);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 6;
            this.DelButton.Text = "Delete row";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
           
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=B232\\SQLEXPRESS;Initial Catalog=Internships;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT * FROM Mentors_Interns";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "INSERT INTO [Mentors_Interns] ([MentorId], [InternId]) VALUES (@MentorId, @Intern" +
    "Id)";
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@MentorId", System.Data.SqlDbType.Int, 0, "MentorId"),
            new System.Data.SqlClient.SqlParameter("@InternId", System.Data.SqlDbType.Int, 0, "InternId")});
            // 
            // sqlDataAdapter2
            // 
            this.sqlDataAdapter2.InsertCommand = this.sqlInsertCommand2;
            this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Mentors_Interns", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("MentorId", "MentorId"),
                        new System.Data.Common.DataColumnMapping("InternId", "InternId")})});
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(215, 276);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(573, 150);
            this.dataGridView3.TabIndex = 9;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Interns", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName1", "FirstName1"),
                        new System.Data.Common.DataColumnMapping("LastName1", "LastName1"),
                        new System.Data.Common.DataColumnMapping("Department", "Department")})});
            // 
            // internsBindingSource2
            // 
            this.internsBindingSource2.DataMember = "Interns";
            this.internsBindingSource2.DataSource = this.myAppDataSetBindingSource;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "dbo.MentorsInterns";
            this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlDataAdapter3
            // 
            this.sqlDataAdapter3.SelectCommand = this.sqlSelectCommand3;
            this.sqlDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "MentorsInterns", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("InternName", "InternName"),
                        new System.Data.Common.DataColumnMapping("InternLastName", "InternLastName"),
                        new System.Data.Common.DataColumnMapping("MentorName", "MentorName"),
                        new System.Data.Common.DataColumnMapping("MentorLastName", "MentorLastName"),
                        new System.Data.Common.DataColumnMapping("Department", "Department")})});
            // 
            // ShowMentorsInternsbutton
            // 
            this.ShowMentorsInternsbutton.Location = new System.Drawing.Point(28, 326);
            this.ShowMentorsInternsbutton.Name = "ShowMentorsInternsbutton";
            this.ShowMentorsInternsbutton.Size = new System.Drawing.Size(138, 44);
            this.ShowMentorsInternsbutton.TabIndex = 10;
            this.ShowMentorsInternsbutton.Text = "Show Interns+Mentors";
            this.ShowMentorsInternsbutton.UseVisualStyleBackColor = true;
            this.ShowMentorsInternsbutton.Click += new System.EventHandler(this.ShowMentorsInternsbutton_Click);
            // 
            // mentorsInternsDataSet1
            // 
            this.mentorsInternsDataSet1.DataSetName = "MentorsInternsDataSet";
            this.mentorsInternsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIdDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.internIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKProjectsInternsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.Location = new System.Drawing.Point(616, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(141, 68);
            this.dataGridView1.TabIndex = 11;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            this.projectNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // internIdDataGridViewTextBoxColumn
            // 
            this.internIdDataGridViewTextBoxColumn.DataPropertyName = "InternId";
            this.internIdDataGridViewTextBoxColumn.HeaderText = "InternId";
            this.internIdDataGridViewTextBoxColumn.Name = "internIdDataGridViewTextBoxColumn";
            this.internIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.internIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Internships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowMentorsInternsbutton);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InternsDataGridView);
            this.Name = "Internships";
            this.Text = "Internships";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.internsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProjectsInternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAppDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InternsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorsInternsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource internsBindingSource;
        private MyAppDataSet myAppDataSet;
        private System.Windows.Forms.BindingSource fKProjectsInternsBindingSource;
        private MyAppDataSetTableAdapters.InternsTableAdapter internsTableAdapter1;
        private MyAppDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter1;
        private System.Windows.Forms.BindingSource myAppDataSetBindingSource;
        private System.Windows.Forms.DataGridView InternsDataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.BindingSource internsBindingSource1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn internIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.BindingSource internsBindingSource2;
        private System.Windows.Forms.BindingSource internsBindingSource3;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter3;
        private System.Windows.Forms.Button ShowMentorsInternsbutton;
        private MentorsInternsDataSet mentorsInternsDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internIdDataGridViewTextBoxColumn;
    }
}

