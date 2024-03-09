using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeagueManagementPortal.Models
{
    [Table("Injuries")]
    public class Injury
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(League))]
        public Guid LeagueId { get; set; }

        [Display(Name = "League")]
        public League League { get; set; }

        [ForeignKey(nameof(Team))]
        public Guid TeamId { get; set; }

        [Display(Name = "Team")]
        public Team Team { get; set; }

        [ForeignKey(nameof(Player))]
        public Guid PlayerId { get; set; }

        [Display(Name = "Player")]
        public Player Player { get; set; }

        [Display(Name = "Injury Date")]
        public DateTime InjuryDate { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Est. Duration")]
        public int EstimatedRecoveryDuration { get; set; }

        [Display(Name = "Unit")]
        public string UnitOfTime { get; set; }

        [Display(Name = "Est. Recovery Date")]
        public DateTime EstimatedRecoveryDate { get; set; }

        [Display(Name = "Recovered?")]
        public bool PlayerHasRecovered { get; set; }
    }
}
