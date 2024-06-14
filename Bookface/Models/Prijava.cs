using System.ComponentModel.DataAnnotations;
using Bookface.Models.Enums;

namespace Bookface.Models
{
    public class Prijava
    {
        [Key] 
        public Guid prijavaId { get; set; }
        public Guid prijavljenaOsobaId { get; set; }
        public Guid prijavljeniKomentarId { get; set; }
        public Guid podnosilacPrijaveId { get; set; }
        public VrstaPrijave vrstaPrijave { get; set; }
        public string? opis { get; set; } = string.Empty;
    }
}
