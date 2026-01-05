namespace AppGestionCahierDeTexte.Views.Parametre
{
    partial class frmMatiere
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
            this.txtNiveau = new System.Windows.Forms.TextBox();
            this.txtVolumeHoraire = new System.Windows.Forms.TextBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.lblVolumeHoraire = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.bntModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbNiveau = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNiveau
            // 
            this.txtNiveau.Location = new System.Drawing.Point(268, 11);
            this.txtNiveau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNiveau.Name = "txtNiveau";
            this.txtNiveau.Size = new System.Drawing.Size(180, 22);
            this.txtNiveau.TabIndex = 27;
            // 
            // txtVolumeHoraire
            // 
            this.txtVolumeHoraire.Location = new System.Drawing.Point(30, 160);
            this.txtVolumeHoraire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVolumeHoraire.Name = "txtVolumeHoraire";
            this.txtVolumeHoraire.Size = new System.Drawing.Size(180, 22);
            this.txtVolumeHoraire.TabIndex = 26;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(30, 92);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(180, 22);
            this.txtLibelle.TabIndex = 25;
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.Location = new System.Drawing.Point(27, 197);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(50, 16);
            this.lblNiveau.TabIndex = 20;
            this.lblNiveau.Text = "Niveau";
            // 
            // lblVolumeHoraire
            // 
            this.lblVolumeHoraire.AutoSize = true;
            this.lblVolumeHoraire.Location = new System.Drawing.Point(27, 129);
            this.lblVolumeHoraire.Name = "lblVolumeHoraire";
            this.lblVolumeHoraire.Size = new System.Drawing.Size(98, 16);
            this.lblVolumeHoraire.TabIndex = 19;
            this.lblVolumeHoraire.Text = "Volume horaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Libelle";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(30, 385);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(163, 37);
            this.btnSupprimer.TabIndex = 23;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // bntModifier
            // 
            this.bntModifier.Location = new System.Drawing.Point(30, 333);
            this.bntModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntModifier.Name = "bntModifier";
            this.bntModifier.Size = new System.Drawing.Size(163, 37);
            this.bntModifier.TabIndex = 22;
            this.bntModifier.Text = "&Modifier";
            this.bntModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(30, 278);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(163, 37);
            this.btnAjouter.TabIndex = 21;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(12, 11);
            this.btnSelectionner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(181, 37);
            this.btnSelectionner.TabIndex = 24;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(572, 356);
            this.dataGridView1.TabIndex = 17;
            // 
            // cbbNiveau
            // 
            this.cbbNiveau.FormattingEnabled = true;
            this.cbbNiveau.Location = new System.Drawing.Point(30, 226);
            this.cbbNiveau.Name = "cbbNiveau";
            this.cbbNiveau.Size = new System.Drawing.Size(180, 24);
            this.cbbNiveau.TabIndex = 28;
            // 
            // frmMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.ControlBox = false;
            this.Controls.Add(this.cbbNiveau);
            this.Controls.Add(this.txtNiveau);
            this.Controls.Add(this.txtVolumeHoraire);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblNiveau);
            this.Controls.Add(this.lblVolumeHoraire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.bntModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMatiere";
            this.Text = "Matiere";
            this.Load += new System.EventHandler(this.frmMatiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNiveau;
        private System.Windows.Forms.TextBox txtVolumeHoraire;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.Label lblVolumeHoraire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button bntModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbNiveau;
    }
}