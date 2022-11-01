using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Data
{
    public partial class Depense
    {
        public int Id { get; set; }
        public int? Idmois { get; set; }
        public string Montant { get; set; }
        public int? Prix { get; set; }

        public virtual Mois IdmoisNavigation { get; set; }
    }
}
