
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.internIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myAppDataSet = new MyApp.MyAppDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKProjectsInternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internsTableAdapter1 = new MyApp.MyAppDataSetTableAdapters.InternsTableAdapter();
            this.projectsTableAdapter1 = new MyApp.MyAppDataSetTableAdapters.ProjectsTableAdapter();
            this.myAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InternsDataGridView = new System.Windows.Forms.DataGridView();
            this.internsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.internshipsDataSet = new MyApp.InternshipsDataSet();
            this.MentorsButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.internsTableAdapter = new MyApp.InternshipsDataSetTableAdapters.InternsTableAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.mentorsInternsDataSet1 = new MyApp.MentorsInternsDataSet();
            this.mentorsInternsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProjectsInternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAppDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InternsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internshipsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorsInternsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorsInternsDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.internIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.universityDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.internsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(286, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // internIdDataGridViewTextBoxColumn
            // 
            this.internIdDataGridViewTextBoxColumn.DataPropertyName = "InternId";
            this.internIdDataGridViewTextBoxColumn.HeaderText = "InternId";
            this.internIdDataGridViewTextBoxColumn.Name = "internIdDataGridViewTextBoxColumn";
            this.internIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // universityDataGridViewTextBoxColumn
            // 
            this.universityDataGridViewTextBoxColumn.DataPropertyName = "University";
            this.universityDataGridViewTextBoxColumn.HeaderText = "University";
            this.universityDataGridViewTextBoxColumn.Name = "universityDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIdDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.internIdDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.fKProjectsInternsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(532, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            // 
            // internIdDataGridViewTextBoxColumn1
            // 
            this.internIdDataGridViewTextBoxColumn1.DataPropertyName = "InternId";
            this.internIdDataGridViewTextBoxColumn1.HeaderText = "InternId";
            this.internIdDataGridViewTextBoxColumn1.Name = "internIdDataGridViewTextBoxColumn1";
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
            this.InternsDataGridView.AutoGenerateColumns = false;
            this.InternsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InternsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.internIdDataGridViewTextBoxColumn2,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.universityDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1});
            this.InternsDataGridView.DataSource = this.internsBindingSource;
            this.InternsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.InternsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.InternsDataGridView.Name = "InternsDataGridView";
            this.InternsDataGridView.Size = new System.Drawing.Size(800, 150);
            this.InternsDataGridView.TabIndex = 2;
            // 
            // internsBindingSource1
            // 
            this.internsBindingSource1.DataMember = "Interns";
            this.internsBindingSource1.DataSource = this.internshipsDataSet;
            // 
            // internshipsDataSet
            // 
            this.internshipsDataSet.DataSetName = "InternshipsDataSet";
            this.internshipsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MentorsButton
            // 
            this.MentorsButton.Location = new System.Drawing.Point(88, 415);
            this.MentorsButton.Name = "MentorsButton";
            this.MentorsButton.Size = new System.Drawing.Size(75, 23);
            this.MentorsButton.TabIndex = 3;
            this.MentorsButton.Text = "Mentors List";
            this.MentorsButton.UseVisualStyleBackColor = true;
            this.MentorsButton.Click += new System.EventHandler(this.MentorsButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(98, 167);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(92, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(331, 167);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(565, 167);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 6;
            this.DelButton.Text = "Delete ";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // internsTableAdapter
            // 
            this.internsTableAdapter.ClearBeforeFill = true;
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
            // mentorsInternsDataSet1
            // 
            this.mentorsInternsDataSet1.DataSetName = "MentorsInternsDataSet";
            this.mentorsInternsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mentorsInternsDataSet1BindingSource
            // 
            this.mentorsInternsDataSet1BindingSource.DataSource = this.mentorsInternsDataSet1;
            this.mentorsInternsDataSet1BindingSource.Position = 0;
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
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            // 
            // universityDataGridViewTextBoxColumn1
            // 
            this.universityDataGridViewTextBoxColumn1.DataPropertyName = "University";
            this.universityDataGridViewTextBoxColumn1.HeaderText = "University";
            this.universityDataGridViewTextBoxColumn1.Name = "universityDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 259);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Interns+Projects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mentors+Interns";
            // 
            // Internships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MentorsButton);
            this.Controls.Add(this.InternsDataGridView);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Internships";
            this.Text = "Internships";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProjectsInternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAppDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InternsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internshipsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorsInternsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentorsInternsDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn internIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource internsBindingSource;
        private MyAppDataSet myAppDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource fKProjectsInternsBindingSource;
        private MyAppDataSetTableAdapters.InternsTableAdapter internsTableAdapter1;
        private MyAppDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter1;
        private System.Windows.Forms.BindingSource myAppDataSetBindingSource;
        private System.Windows.Forms.DataGridView InternsDataGridView;
        private System.Windows.Forms.Button MentorsButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DelButton;
        private InternshipsDataSet internshipsDataSet;
        private System.Windows.Forms.BindingSource internsBindingSource1;
        private InternshipsDataSetTableAdapters.InternsTableAdapter internsTableAdapter;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
        private MentorsInternsDataSet mentorsInternsDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn internIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource mentorsInternsDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

