//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portafolio_OrnelasSamuel.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class portafolioEntities : DbContext
    {
        public portafolioEntities()
            : base("name=portafolioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Dato> Datos { get; set; }
        public virtual DbSet<Experiencia> Experiencias { get; set; }
        public virtual DbSet<Habilidad> Habilidads { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<Testimonio> Testimonios { get; set; }
        public virtual DbSet<Tipo> Tipoes { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
