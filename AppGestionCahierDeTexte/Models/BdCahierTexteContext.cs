using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierDeTexte.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdCahierTexteContext:DbContext
    {
        public BdCahierTexteContext(): base("connCahiertexte")
        {
        }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<AnneeAcademique> AnneeAcademiques { get; set; }
        public DbSet<LaClasse> LaClasses { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<ResponsableClasse> ResponsableClasses { get; set; }
        public DbSet<Syllabus> Syllabus { get; set; }
        public DbSet<CahierTexte> CahierTextes { get; set; }
        public DbSet <DetailsSyllabus> DetailsSyllabuses { get; set; }
    }
}
