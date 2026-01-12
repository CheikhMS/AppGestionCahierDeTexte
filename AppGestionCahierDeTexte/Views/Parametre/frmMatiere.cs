using AppGestionCahierDeTexte.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCahierDeTexte.Views.Parametre
{
    public partial class frmMatiere : Form
    {
        BdCahierTexteContext db = new BdCahierTexteContext();
        private void Effacer()
        {
            txtLibelle.Text = string.Empty;
            txtVolumeHoraire.Text = string.Empty;
            //cbbAnneeAcademique.Text = string.Empty;
            cbbNiveau.DataSource = Shared.FillListOption.fillNiveau();
            cbbNiveau.DisplayMember = "Text";
            cbbNiveau.ValueMember = "Value";
            dgMatiere.DataSource = db.Matieres.ToList();
            txtLibelle.Focus();
        }
        public frmMatiere()
        {
            InitializeComponent();
        }

        private void frmMatiere_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtLibelle.Text = dgMatiere.CurrentRow.Cells[1].Value.ToString();
            txtVolumeHoraire.Text = dgMatiere.CurrentRow.Cells[2].Value.ToString();
            cbbNiveau.SelectedValue = dgMatiere.CurrentRow.Cells[3].Value;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Matiere m = new Matiere();
            m.libelleMatiere = txtLibelle.Text;
            m.VolumeHoraire = int.Parse(txtVolumeHoraire.Text);
            m.Niveau = cbbNiveau.SelectedValue.ToString();
            db.Matieres.Add(m);
            db.SaveChanges();
            Effacer();
        }

        private void bntModifier_Click(object sender, EventArgs e)
        {
            int ?id = int.Parse(dgMatiere.CurrentRow.Cells[0].Value.ToString());
            var m = db.Matieres.Find(id);
            m.libelleMatiere = txtLibelle.Text;
            m.VolumeHoraire = int.Parse(txtVolumeHoraire.Text);
            m.Niveau = cbbNiveau.SelectedValue.ToString();
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMatiere.CurrentRow.Cells[0].Value.ToString());
            var m = db.Matieres.Find(id);
            db.Matieres.Remove(m);
            db.SaveChanges();
            Effacer();
        }
    }
}
