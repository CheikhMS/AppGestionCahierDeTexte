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
        private void Effacer()
        {
            txtLibelle.Text = string.Empty;
            txtVolumeHoraire.Text = string.Empty;
            //cbbAnneeAcademique.Text = string.Empty;
            cbbAnneeAcademique.DataSource = Shared.FillListOption.fillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
            DgClasse.DataSource = db.LaClasses.ToList();
            txtLibelle.Focus();
        }
        public frmMatiere()
        {
            InitializeComponent();
        }

        private void frmMatiere_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {

        }
    }
}
