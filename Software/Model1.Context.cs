//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veronika_Domjancic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Odjel> Odjel { get; set; }
        public virtual DbSet<Oprema> Oprema { get; set; }
        public virtual DbSet<TipOpreme> TipOpreme { get; set; }
        public virtual DbSet<UlogaZaposlenika> UlogaZaposlenika { get; set; }
        public virtual DbSet<Zaduzenje> Zaduzenje { get; set; }
        public virtual DbSet<Zaposlenik> Zaposlenik { get; set; }
    }
}
