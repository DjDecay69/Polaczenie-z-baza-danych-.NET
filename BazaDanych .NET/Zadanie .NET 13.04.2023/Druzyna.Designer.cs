namespace Zadanie.NET_13._04._2023
{
    partial class Druzyna
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
            this.druzynaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilkaNoznaDataSet = new Zadanie.NET_13._04._2023.PilkaNoznaDataSet();
            this.druzynaTableAdapter = new Zadanie.NET_13._04._2023.PilkaNoznaDataSetTableAdapters.druzynaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.druzynaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pilkaNoznaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.druzynaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilkaNoznaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.druzynaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilkaNoznaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // druzynaBindingSource
            // 
            this.druzynaBindingSource.DataMember = "druzyna";
            this.druzynaBindingSource.DataSource = this.pilkaNoznaDataSet;
            // 
            // pilkaNoznaDataSet
            // 
            this.pilkaNoznaDataSet.DataSetName = "PilkaNoznaDataSet";
            this.pilkaNoznaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // druzynaTableAdapter
            // 
            this.druzynaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.druzynaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            // 
            // druzynaBindingSource1
            // 
            this.druzynaBindingSource1.DataMember = "druzyna";
            this.druzynaBindingSource1.DataSource = this.pilkaNoznaDataSetBindingSource;
            // 
            // pilkaNoznaDataSetBindingSource
            // 
            this.pilkaNoznaDataSetBindingSource.DataSource = this.pilkaNoznaDataSet;
            this.pilkaNoznaDataSetBindingSource.Position = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(265, 22);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Zapisz";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Druzyna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Druzyna";
            this.Text = "Druzyna";
            this.Load += new System.EventHandler(this.Druzyna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.druzynaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilkaNoznaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.druzynaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilkaNoznaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PilkaNoznaDataSet pilkaNoznaDataSet;
        private System.Windows.Forms.BindingSource druzynaBindingSource;
        private PilkaNoznaDataSetTableAdapters.druzynaTableAdapter druzynaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource druzynaBindingSource1;
        private System.Windows.Forms.BindingSource pilkaNoznaDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodaj;
    }
}