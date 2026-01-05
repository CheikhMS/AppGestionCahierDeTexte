using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierDeTexte.Models
{
    public class Matiere
    {
        [Key]
        public int idMatiere { get; set; }
        [Required, MaxLength(200)]
        public string libelleMatiere { get; set; }
        [Required]
        public int? VolumeHoraire { get; set; }
        [Required, MaxLength(80)]
        public string Niveau { get; set; }

    }
}
