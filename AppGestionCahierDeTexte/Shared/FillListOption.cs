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
        public static List<ListItem> fillNiveau()
        {
            List<ListItem> laList = new List<ListItem>();
            laList.Add(new ListItem
            {
                Value = null,
                Text = "Selectionner"
            });
            laList.Add(new ListItem
            {
                Value = "L1",
                Text = "Licence 1"
            });
            laList.Add(new ListItem
            {
                Value = "L2",
                Text = "Licence 2"
            });
            laList.Add(new ListItem
            {
                Value = "L3",
                Text = "Licence 3"
            });
            laList.Add(new ListItem
            {
                Value = "M1",
                Text = "Master 1"
            });
            laList.Add(new ListItem
            {
                Value = "M2",
                Text = "Master 2"
            });
            return laList;
        }

    }
}
