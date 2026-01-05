namespace AppGestionCahierDeTexte.Views.Parametre
{
    partial class frmClasse
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
            this.DgClasse = new System.Windows.Forms.DataGridView();
            this.Libelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.bntModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.AnneeAcademique = new System.Windows.Forms.Label();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.txtRClasse = new System.Windows.Forms.TextBox();
            this.txtRAnnee = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // DgClasse
            // 
            this.DgClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgClasse.Location = new System.Drawing.Point(243, 46);
            this.DgClasse.Name = "DgClasse";
            this.DgClasse.RowHeadersWidth = 51;
            this.DgClasse.RowTemplate.Height = 24;
            this.DgClasse.Size = new System.Drawing.Size(561, 392);
            this.DgClasse.TabIndex = 0;
            // 
            // Libelle
            // 
            this.Libelle.AutoSize = true;
            this.Libelle.Location = new System.Drawing.Point(13, 46);
            this.Libelle.Name = "Libelle";
            this.Libelle.Size = new System.Drawing.Size(47, 16);
            this.Libelle.TabIndex = 1;
            this.Libelle.Text = "Libelle";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(28, 65);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(193, 22);
            this.txtLibelle.TabIndex = 2;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(58, 325);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(163, 37);
            this.btnSupprimer.TabIndex = 26;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // bntModifier
            // 
            this.bntModifier.Location = new System.Drawing.Point(58, 273);
            this.bntModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntModifier.Name = "bntModifier";
            this.bntModifier.Size = new System.Drawing.Size(163, 37);
            this.bntModifier.TabIndex = 25;
            this.bntModifier.Text = "&Modifier";
            this.bntModifier.UseVisualStyleBackColor = true;
            this.bntModifier.Click += new System.EventHandler(this.bntModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(58, 218);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(163, 37);
            this.btnAjouter.TabIndex = 24;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // AnneeAcademique
            // 
            this.AnneeAcademique.AutoSize = true;
            this.AnneeAcademique.Location = new System.Drawing.Point(9, 146);
            this.AnneeAcademique.Name = "AnneeAcademique";
            this.AnneeAcademique.Size = new System.Drawing.Size(126, 16);
            this.AnneeAcademique.TabIndex = 27;
            this.AnneeAcademique.Text = "Annee Academique";
            // 
            // cbbAnneeAcademique
            // 
            this.cbbAnneeAcademique.FormattingEnabled = true;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(27, 165);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(193, 24);
            this.cbbAnneeAcademique.TabIndex = 28;
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(15, 7);
            this.btnSelectionner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(181, 37);
            this.btnSelectionner.TabIndex = 29;
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // txtRClasse
            // 
            this.txtRClasse.Location = new System.Drawing.Point(304, 14);
            this.txtRClasse.Name = "txtRClasse";
            this.txtRClasse.Size = new System.Drawing.Size(106, 22);
            this.txtRClasse.TabIndex = 30;
            // 
            // txtRAnnee
            // 
            this.txtRAnnee.Location = new System.Drawing.Point(502, 14);
            this.txtRAnnee.Name = "txtRAnnee";
            this.txtRAnnee.Size = new System.Drawing.Size(108, 22);
            this.txtRAnnee.TabIndex = 31;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(655, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 34);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "&Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Annee";
            // 
            // frmClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRAnnee);
            this.Controls.Add(this.txtRClasse);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.cbbAnneeAcademique);
            this.Controls.Add(this.AnneeAcademique);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.bntModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.Libelle);
            this.Controls.Add(this.DgClasse);
            this.Name = "frmClasse";
            this.Text = "Classe";
            this.Load += new System.EventHandler(this.frmClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgClasse;
        private System.Windows.Forms.Label Libelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button bntModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label AnneeAcademique;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.TextBox txtRClasse;
        private System.Windows.Forms.TextBox txtRAnnee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}