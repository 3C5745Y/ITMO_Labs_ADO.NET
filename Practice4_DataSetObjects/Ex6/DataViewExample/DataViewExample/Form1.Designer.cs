
namespace DataViewExample
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SortTextBox = new System.Windows.Forms.TextBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.SetDataViewPropertiesButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.adventureWorks2019DataSet1 = new DataViewExample.AdventureWorks2019DataSet();
            this.currencyTableAdapter1 = new DataViewExample.AdventureWorks2019DataSetTableAdapters.CurrencyTableAdapter();
            this.customerTableAdapter1 = new DataViewExample.AdventureWorks2019DataSetTableAdapters.CustomerTableAdapter();
            this.GetCurrencyButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2019DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // SortTextBox
            // 
            this.SortTextBox.Location = new System.Drawing.Point(478, 26);
            this.SortTextBox.Name = "SortTextBox";
            this.SortTextBox.Size = new System.Drawing.Size(100, 20);
            this.SortTextBox.TabIndex = 1;
            this.SortTextBox.Text = "CustomerId";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(478, 72);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilterTextBox.TabIndex = 2;
            this.FilterTextBox.Text = "Name";
            // 
            // SetDataViewPropertiesButton
            // 
            this.SetDataViewPropertiesButton.Location = new System.Drawing.Point(403, 135);
            this.SetDataViewPropertiesButton.Name = "SetDataViewPropertiesButton";
            this.SetDataViewPropertiesButton.Size = new System.Drawing.Size(99, 49);
            this.SetDataViewPropertiesButton.TabIndex = 3;
            this.SetDataViewPropertiesButton.Text = "SetDataViewProperties";
            this.SetDataViewPropertiesButton.UseVisualStyleBackColor = true;
            this.SetDataViewPropertiesButton.Click += new System.EventHandler(this.SetDataViewPropertiesButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(542, 148);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(75, 23);
            this.AddRowButton.TabIndex = 4;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // adventureWorks2019DataSet1
            // 
            this.adventureWorks2019DataSet1.DataSetName = "AdventureWorks2019DataSet";
            this.adventureWorks2019DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currencyTableAdapter1
            // 
            this.currencyTableAdapter1.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // GetCurrencyButton
            // 
            this.GetCurrencyButton.Location = new System.Drawing.Point(525, 202);
            this.GetCurrencyButton.Name = "GetCurrencyButton";
            this.GetCurrencyButton.Size = new System.Drawing.Size(92, 38);
            this.GetCurrencyButton.TabIndex = 5;
            this.GetCurrencyButton.Text = "Get Currency";
            this.GetCurrencyButton.UseVisualStyleBackColor = true;
            this.GetCurrencyButton.Click += new System.EventHandler(this.GetCurrencyButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(478, 291);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.GetCurrencyButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.SetDataViewPropertiesButton);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.SortTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2019DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SortTextBox;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Button SetDataViewPropertiesButton;
        private System.Windows.Forms.Button AddRowButton;
        private AdventureWorks2019DataSet adventureWorks2019DataSet1;
        private AdventureWorks2019DataSetTableAdapters.CurrencyTableAdapter currencyTableAdapter1;
        private AdventureWorks2019DataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.Button GetCurrencyButton;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

