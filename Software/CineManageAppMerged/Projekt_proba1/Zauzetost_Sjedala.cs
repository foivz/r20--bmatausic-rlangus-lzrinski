//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_proba1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zauzetost_Sjedala
    {
        public int sjedalo_je_zauzeto_id { get; set; }
        public short zauzeto { get; set; }
        public int prikazuje_se_prikazuje_se_id { get; set; }
        public int sjedala_sjedalo_id { get; set; }
    
        public virtual Prikazivanje Prikazivanje { get; set; }
        public virtual Sjedalo Sjedalo { get; set; }
    }
}
