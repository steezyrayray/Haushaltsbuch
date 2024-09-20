using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Haushaltsbuch.Models
{
    public class BenutzerKategorie
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Benutzer")]
        public int BenutzerId { get; set; }
        [ForeignKey("Kategorie")]
        public int KategorieId { get; set; }
        public virtual Benutzer Benutzer { get; set; }
        public virtual Kategorie Kategorie { get; set; }
    }
}
