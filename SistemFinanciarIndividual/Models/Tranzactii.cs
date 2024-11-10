using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemFinanciarIndividual.Models
{
    public class Tranzactii
    {

        [Key]
        public int IdTranzactie { get; set; }

        public int idCategorie { get; set; }
        public Categorie Categorie { get; set; }

        public int Valoare { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Descriere { get; set; }

        public DateTime Data {  get; set; } = DateTime.Now;
    }
}
