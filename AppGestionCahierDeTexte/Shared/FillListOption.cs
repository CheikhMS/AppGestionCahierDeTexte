using AppGestionCahierDeTexte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierDeTexte.Shared
{
    public static class FillListOption
    {
        static BdCahierTexteContext db = new BdCahierTexteContext();
        public static List<ListItem> fillAnneeAcademique()
        {
            List<ListItem> laList = new List<ListItem>();
            var annees = db.AnneeAcademiques.ToList();
            laList.Add(new ListItem
            {
                Value = null,
                Text = "Sélectionner" 
            });
            foreach (var t in annees)
            {
                var item = new ListItem
                {
                    Value = t.ValueAnneeAcademique.ToString(),
                    Text = t.LibelleAnneeAcademique.ToString(),
                };
                laList.Add(item);
            }
            return laList;
        }
        
    }
}
