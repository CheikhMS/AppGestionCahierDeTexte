using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierDeTexte.Models
{
    public class DetailsSyllabus
    {
        [Key]
        public int IdDetailsSyllabus { get; set; }
        public string SeanceSyllabus { get; set; }
        public string ContenuSyllabus { get; set; }
        public int? SyllabusId { get; set; }

        [ForeignKey("SyllabusId")]
        
        public Syllabus Syllabus { get; set; }
    }
}
