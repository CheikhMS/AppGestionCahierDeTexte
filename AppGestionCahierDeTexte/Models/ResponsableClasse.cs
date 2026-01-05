using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierDeTexte.Models
{
    public class ResponsableClasse:Utilisateur
    {
        public string MatriculeResponsable { get; set; }
    }
}
