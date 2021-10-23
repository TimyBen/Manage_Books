
namespace Login_Form2
{
    partial class ManageBook
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
            this.txtBook_Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_2DataSet = new Login_Form2.Lab_2DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBooksTableAdapter = new Login_Form2.Lab_2DataSetTableAdapters.tblBooksTableAdapter();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lab_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBook_Name
            // 
            this.txtBook_Name.Location = new System.Drawing.Point(122, 27);
            this.txtBook_Name.Name = "txtBook_Name";
            this.txtBook_Name.Size = new System.Drawing.Size(222, 20);
            this.txtBook_Name.TabIndex = 0;
            this.txtBook_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBook_Name_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Books:";
            // 
            // lab_2DataSet
            // 
            this.lab_2DataSet.DataSetName = "Lab_2DataSet";
            this.lab_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookTitleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblBooksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // tblBooksBindingSource
            // 
            this.tblBooksBindingSource.DataMember = "tblBooks";
            this.tblBooksBindingSource.DataSource = this.lab_2DataSet;
            // 
            // tblBooksTableAdapter
            // 
            this.tblBooksTableAdapter.ClearBeforeFill = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // ManageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(442, 248);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBook_Name);
            this.Name = "ManageBook";
            this.Text = "ManageBook";
            this.Load += new System.EventHandler(this.ManageBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBook_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Lab_2DataSet lab_2DataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblBooksBindingSource;
        private Lab_2DataSetTableAdapters.tblBooksTableAdapter tblBooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
    }
}