using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemFinanciarIndividual.Models
{
    public class Categorie
    {

        [Key]
        public int idCategorie{ get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Nume { get; set; }
        [Column(TypeName = "nvarchar(5)")]

        public string Icon { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")] 

        public string Tip { get; set; } = "Cheltuiala";

        [NotMapped]
        public string? TitleWithIcon {
            get
            {
                return this.Icon + " " + this.Nume;
            }
        
        }
    }
}
