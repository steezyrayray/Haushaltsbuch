using System.Data.Entity;

namespace Haushaltsbuch.Models
{
    public class HaushaltsbuchContext : DbContext
    {
        public DbSet<Benutzer> Benutzer { get; set; }
        public DbSet<BenutzerKategorie> BenutzerKategorie { get; set; }
        public DbSet<Kategorie> Kategorie { get; set; }
        public DbSet<Transaktion> Transaktion { get; set; }
    }
}
