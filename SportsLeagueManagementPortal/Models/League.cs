using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeagueManagementPortal.Models
{
    [Table("Leagues")]
    public class League
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [ForeignKey(nameof(Sport))]
        public Guid SportId { get; set; }

        [Display(Name = "Sport")]
        public Sport Sport { get; set; }

        [Display(Name = "Logo Path")]
        public string? LogoPath { get; set; }
    }
}
