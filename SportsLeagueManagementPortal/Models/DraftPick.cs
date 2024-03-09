using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeagueManagementPortal.Models
{
    [Table("DraftPicks")]
    public class DraftPick
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(League))]
        public Guid LeagueId { get; set; }

        [Display(Name = "League")]
        public Guid League { get; set; }

        [Display(Name = "Year")]
        public int Year { get; set; }

        [Display(Name = "Round")]
        public int Round { get; set; }

        [ForeignKey(nameof(OriginalTeam))]
        public Guid OriginalTeamId { get; set; }

        [Display(Name = "Original Team")]
        public Team OriginalTeam { get; set; }
    }
}
