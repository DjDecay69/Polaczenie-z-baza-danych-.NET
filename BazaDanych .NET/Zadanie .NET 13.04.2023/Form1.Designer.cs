namespace Zadanie.NET_13._04._2023
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pilkaNoznaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graczeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drużynyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.druzynaTableAdapter = new Zadanie.NET_13._04._2023.PilkaNoznaDataSetTableAdapters.druzynaTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilkaNoznaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pilkaNoznaToolStripMenuItem
            // 
            this.pilkaNoznaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graczeToolStripMenuItem,
            this.drużynyToolStripMenuItem});
            this.pilkaNoznaToolStripMenuItem.Name = "pilkaNoznaToolStripMenuItem";
            this.pilkaNoznaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.pilkaNoznaToolStripMenuItem.Text = "Pilka Nozna";
            // 
            // graczeToolStripMenuItem
            // 
            this.graczeToolStripMenuItem.Name = "graczeToolStripMenuItem";
            this.graczeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.graczeToolStripMenuItem.Text = "Gracze";
            this.graczeToolStripMenuItem.Click += new System.EventHandler(this.graczeToolStripMenuItem_Click);
            // 
            // drużynyToolStripMenuItem
            // 
            this.drużynyToolStripMenuItem.Name = "drużynyToolStripMenuItem";
            this.drużynyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drużynyToolStripMenuItem.Text = "Drużyny";
            this.drużynyToolStripMenuItem.Click += new System.EventHandler(this.drużynyToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // druzynaTableAdapter
            // 
            this.druzynaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ToolStripMenuItem pilkaNoznaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graczeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drużynyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private PilkaNoznaDataSetTableAdapters.druzynaTableAdapter druzynaTableAdapter;
    }
}

