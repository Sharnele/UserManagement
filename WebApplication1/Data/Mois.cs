using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Data
{
    public partial class Mois
    {
        public Mois()
        {
            Depense = new HashSet<Depense>();
            Revenu = new HashSet<Revenu>();
        }

        public int Id { get; set; }
        public string Mois1 { get; set; }
        public string Annees { get; set; }
        public int? Idperiode { get; set; }

        public virtual Periode IdperiodeNavigation { get; set; }
        public virtual ICollection<Depense> Depense { get; set; }
        public virtual ICollection<Revenu> Revenu { get; set; }
    }
}
