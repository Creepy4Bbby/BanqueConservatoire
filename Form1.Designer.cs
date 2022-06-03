
namespace Gestion_conservatoire
{
    partial class Gestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lBox = new System.Windows.Forms.ListBox();
            this.cBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crediterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSupp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textCrediter = new System.Windows.Forms.TextBox();
            this.btnCrediter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBox
            // 
            this.lBox.FormattingEnabled = true;
            this.lBox.ItemHeight = 16;
            this.lBox.Location = new System.Drawing.Point(586, 34);
            this.lBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(489, 212);
            this.lBox.TabIndex = 0;
            this.lBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cBox
            // 
            this.cBox.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox.FormattingEnabled = true;
            this.cBox.Location = new System.Drawing.Point(11, 34);
            this.cBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(551, 25);
            this.cBox.TabIndex = 1;
            this.cBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1085, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.crediterToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // crediterToolStripMenuItem
            // 
            this.crediterToolStripMenuItem.Name = "crediterToolStripMenuItem";
            this.crediterToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.crediterToolStripMenuItem.Text = "Crediter";
            this.crediterToolStripMenuItem.Click += new System.EventHandler(this.crediterToolStripMenuItem_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(100, 324);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(244, 42);
            this.btnSupp.TabIndex = 3;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Visible = false;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(739, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 31);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Etat";
            // 
            // textCrediter
            // 
            this.textCrediter.Location = new System.Drawing.Point(304, 224);
            this.textCrediter.Name = "textCrediter";
            this.textCrediter.Size = new System.Drawing.Size(190, 22);
            this.textCrediter.TabIndex = 6;
            this.textCrediter.Visible = false;
            this.textCrediter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCrediter
            // 
            this.btnCrediter.Location = new System.Drawing.Point(281, 259);
            this.btnCrediter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrediter.Name = "btnCrediter";
            this.btnCrediter.Size = new System.Drawing.Size(244, 42);
            this.btnCrediter.TabIndex = 7;
            this.btnCrediter.Text = "Crediter";
            this.btnCrediter.UseVisualStyleBackColor = true;
            this.btnCrediter.Visible = false;
            this.btnCrediter.Click += new System.EventHandler(this.btnCrediter_Click);
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 467);
            this.Controls.Add(this.btnCrediter);
            this.Controls.Add(this.textCrediter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.lBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Gestion";
            this.Text = "Gestion conservatoire Zik-Mu";
            this.Load += new System.EventHandler(this.Gestion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.ComboBox cBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCrediter;
        private System.Windows.Forms.Button btnCrediter;
        private System.Windows.Forms.ToolStripMenuItem crediterToolStripMenuItem;
    }
}

