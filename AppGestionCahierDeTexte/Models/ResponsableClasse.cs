using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierDeTexte.Models
{
    public class ResponsableClasse:Utilisateur
    {
        [Required, MaxLength(10)]
        public string MatriculeResponsable { get; set; }

        public int? IdClasse { get; set; }

        //[ForeignKey("IdClasse")]
        //public virtual Classe Classe { get; set; }

    }
}
