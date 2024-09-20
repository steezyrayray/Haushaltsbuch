using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace Haushaltsbuch.Models
{
    public class Benutzer
    {
        [Key]
        public int Id { get; set; }
        public string Benutzername { get; set; }
        public string Passwort {  get; set; }
        public bool IstAdmin { get; set; } = false;
        public virtual List<Transaktion> Transaktionen { get; set; }
    }
}
