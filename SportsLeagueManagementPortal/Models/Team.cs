using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeagueManagementPortal.Models
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Logo Path")]
        public string? LogoPath { get; set; }

        [ForeignKey(nameof(Arena))]
        public Guid ArenaId { get; set; }

        [Display(Name = "Arena")]
        public Arena Arena { get; set; }
    }
}
