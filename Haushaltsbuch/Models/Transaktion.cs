using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Haushaltsbuch.Models
{
    public class Transaktion
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Benutzer")]
        public int BenutzerId { get; set; }
        [ForeignKey("Kategorie")]
        public int KategorieId { get; set; }
        public double Betrag { get; set; }
        public string Beschreibung { get; set; } = string.Empty;
        public DateTime Zeit { get; set; } = DateTime.Now;
        public virtual Benutzer Benutzer { get; set; }
        public virtual Kategorie Kategorie { get; set; }
    } 
}
