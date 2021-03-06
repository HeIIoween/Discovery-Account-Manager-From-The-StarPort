﻿namespace DAM.Tool_UI
{
    partial class SearchForAccountsByLoginIDWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForAccountsByLoginIDWindow));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accDirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginIDListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.damDataSet = new DAM.DamDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowAccount = new System.Windows.Forms.Button();
            this.iPListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxOnlyNewest = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginIDListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login ID";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(171, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(498, 369);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accDirDataGridViewTextBoxColumn,
            this.accessTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginIDListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(558, 295);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // accDirDataGridViewTextBoxColumn
            // 
            this.accDirDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accDirDataGridViewTextBoxColumn.DataPropertyName = "AccDir";
            this.accDirDataGridViewTextBoxColumn.HeaderText = "Account Dir";
            this.accDirDataGridViewTextBoxColumn.Name = "accDirDataGridViewTextBoxColumn";
            // 
            // accessTimeDataGridViewTextBoxColumn
            // 
            this.accessTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accessTimeDataGridViewTextBoxColumn.DataPropertyName = "AccessTime";
            this.accessTimeDataGridViewTextBoxColumn.HeaderText = "Access Time";
            this.accessTimeDataGridViewTextBoxColumn.Name = "accessTimeDataGridViewTextBoxColumn";
            // 
            // loginIDListBindingSource
            // 
            this.loginIDListBindingSource.DataMember = "LoginIDList";
            this.loginIDListBindingSource.DataSource = this.damDataSet;
            // 
            // damDataSet
            // 
            this.damDataSet.DataSetName = "DamDataSet";
            this.damDataSet.Locale = new System.Globalization.CultureInfo("");
            this.damDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matching Accounts";
            // 
            // buttonShowAccount
            // 
            this.buttonShowAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowAccount.Location = new System.Drawing.Point(400, 369);
            this.buttonShowAccount.Name = "buttonShowAccount";
            this.buttonShowAccount.Size = new System.Drawing.Size(92, 23);
            this.buttonShowAccount.TabIndex = 13;
            this.buttonShowAccount.Text = "Show Account";
            this.buttonShowAccount.UseVisualStyleBackColor = true;
            this.buttonShowAccount.Click += new System.EventHandler(this.buttonShowAccount_Click);
            // 
            // iPListBindingSource
            // 
            this.iPListBindingSource.DataMember = "IPList";
            this.iPListBindingSource.DataSource = this.damDataSet;
            // 
            // checkBoxOnlyNewest
            // 
            this.checkBoxOnlyNewest.AutoSize = true;
            this.checkBoxOnlyNewest.Location = new System.Drawing.Point(15, 32);
            this.checkBoxOnlyNewest.Name = "checkBoxOnlyNewest";
            this.checkBoxOnlyNewest.Size = new System.Drawing.Size(162, 17);
            this.checkBoxOnlyNewest.TabIndex = 14;
            this.checkBoxOnlyNewest.Text = "Search only newest Login ID";
            this.checkBoxOnlyNewest.UseVisualStyleBackColor = true;
            // 
            // SearchForAccountsByLoginIDWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 404);
            this.Controls.Add(this.checkBoxOnlyNewest);
            this.Controls.Add(this.buttonShowAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForAccountsByLoginIDWindow";
            this.Text = "Search For Accounts By Login ID";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginIDListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource iPListBindingSource;
        private DamDataSet damDataSet;
        private System.Windows.Forms.Button buttonShowAccount;
        private System.Windows.Forms.BindingSource loginIDListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn accDirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBoxOnlyNewest;
    }
}