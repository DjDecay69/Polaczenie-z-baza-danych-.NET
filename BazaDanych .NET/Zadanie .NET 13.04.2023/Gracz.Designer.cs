namespace Zadanie.NET_13._04._2023
{
    partial class Gracz
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
            this.graczBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pilkaNoznaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilkaNoznaDataSet = new Zadanie.NET_13._04._2023.PilkaNoznaDataSet();
            this.graczBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graczTableAdapter = new Zadanie.NET_13._04._2023.PilkaNoznaDataSetTableAdapters.graczTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.druzynaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozycjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdjecieDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.graczBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.pilkaNoznaDataSet1 = new Zadanie.NET_13._04._2023.PilkaNoznaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilkaNoznaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilkaNoznaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilkaNoznaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // graczBindingSource1
            // 
            this.graczBindingSource1.DataMember = "gracz";
            this.graczBindingSource1.DataSource = this.pilkaNoznaDataSetBindingSource;
            // 
            // pilkaNoznaDataSetBindingSource
            // 
            this.pilkaNoznaDataSetBindingSource.DataSource = this.pilkaNoznaDataSet;
            this.pilkaNoznaDataSetBindingSource.Position = 0;
            // 
            // pilkaNoznaDataSet
            // 
            this.pilkaNoznaDataSet.DataSetName = "PilkaNoznaDataSet";
            this.pilkaNoznaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // graczBindingSource
            // 
            this.graczBindingSource.DataMember = "gracz";
            this.graczBindingSource.DataSource = this.pilkaNoznaDataSetBindingSource;
            // 
            // graczTableAdapter
            // 
            this.graczTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.druzynaidDataGridViewTextBoxColumn,
            this.pozycjaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.dataurDataGridViewTextBoxColumn,
            this.zdjecieDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.graczBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 446);
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
            // druzynaidDataGridViewTextBoxColumn
            // 
            this.druzynaidDataGridViewTextBoxColumn.DataPropertyName = "druzyna_id";
            this.druzynaidDataGridViewTextBoxColumn.HeaderText = "druzyna_id";
            this.druzynaidDataGridViewTextBoxColumn.Name = "druzynaidDataGridViewTextBoxColumn";
            // 
            // pozycjaDataGridViewTextBoxColumn
            // 
            this.pozycjaDataGridViewTextBoxColumn.DataPropertyName = "pozycja";
            this.pozycjaDataGridViewTextBoxColumn.HeaderText = "pozycja";
            this.pozycjaDataGridViewTextBoxColumn.Name = "pozycjaDataGridViewTextBoxColumn";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // dataurDataGridViewTextBoxColumn
            // 
            this.dataurDataGridViewTextBoxColumn.DataPropertyName = "data_ur";
            this.dataurDataGridViewTextBoxColumn.HeaderText = "data_ur";
            this.dataurDataGridViewTextBoxColumn.Name = "dataurDataGridViewTextBoxColumn";
            // 
            // zdjecieDataGridViewImageColumn
            // 
            this.zdjecieDataGridViewImageColumn.DataPropertyName = "zdjecie";
            this.zdjecieDataGridViewImageColumn.HeaderText = "zdjecie";
            this.zdjecieDataGridViewImageColumn.Name = "zdjecieDataGridViewImageColumn";
            // 
            // graczBindingSource2
            // 
            this.graczBindingSource2.DataMember = "gracz";
            this.graczBindingSource2.DataSource = this.pilkaNoznaDataSetBindingSource;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnWczytaj.Location = new System.Drawing.Point(812, 185);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 26;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(907, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnZapisz.Location = new System.Drawing.Point(812, 229);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 15;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click_1);
            // 
            // btnUsun
            // 
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnUsun.Location = new System.Drawing.Point(812, 273);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 14;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // pilkaNoznaDataSet1
            // 
            this.pilkaNoznaDataSet1.DataSetName = "PilkaNoznaDataSet";
            this.pilkaNoznaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(852, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(852, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(852, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(852, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 31;
            // 
            // Gracz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 582);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gracz";
            this.Text = "Gracz";
            this.Load += new System.EventHandler(this.Gracz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilkaNoznaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilkaNoznaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graczBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilkaNoznaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pilkaNoznaDataSetBindingSource;
        private PilkaNoznaDataSet pilkaNoznaDataSet;
        private System.Windows.Forms.BindingSource graczBindingSource;
        private PilkaNoznaDataSetTableAdapters.graczTableAdapter graczTableAdapter;
        private System.Windows.Forms.BindingSource graczBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource graczBindingSource2;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn druzynaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozycjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn zdjecieDataGridViewImageColumn;
        private PilkaNoznaDataSet pilkaNoznaDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}