
namespace DBConnection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDbToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectDbToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToDbToolStripMenuItem1,
            this.disconnectDbToolStripMenuItem1,
            this.listOfConnectionsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // connectToDbToolStripMenuItem1
            // 
            this.connectToDbToolStripMenuItem1.Name = "connectToDbToolStripMenuItem1";
            this.connectToDbToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.connectToDbToolStripMenuItem1.Text = "connect to db";
            this.connectToDbToolStripMenuItem1.Click += new System.EventHandler(this.connectToDbToolStripMenuItem1_Click);
            // 
            // disconnectDbToolStripMenuItem1
            // 
            this.disconnectDbToolStripMenuItem1.Name = "disconnectDbToolStripMenuItem1";
            this.disconnectDbToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.disconnectDbToolStripMenuItem1.Text = "disconnect db";
            this.disconnectDbToolStripMenuItem1.Click += new System.EventHandler(this.disconnectDbToolStripMenuItem1_Click);
            // 
            // listOfConnectionsToolStripMenuItem
            // 
            this.listOfConnectionsToolStripMenuItem.Name = "listOfConnectionsToolStripMenuItem";
            this.listOfConnectionsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.listOfConnectionsToolStripMenuItem.Text = "list of connections";
            this.listOfConnectionsToolStripMenuItem.Click += new System.EventHandler(this.listOfConnectionsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "сколько продуктов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "сколько продуктов";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "список продуктов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(44, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(180, 170);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название продукта";
            this.columnHeader1.Width = 113;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToDbToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disconnectDbToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem listOfConnectionsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

