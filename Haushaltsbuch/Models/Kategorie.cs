using System.ComponentModel.DataAnnotations;

namespace Haushaltsbuch.Models
{
    public class Kategorie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string HexColor { get; set; }
        public virtual List<Transaktion> Transaktionen { get; set; }
    }
}
