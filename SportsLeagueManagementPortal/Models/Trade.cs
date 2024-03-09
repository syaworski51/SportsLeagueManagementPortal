using Microsoft.EntityFrameworkCore.ValueGeneration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeagueManagementPortal.Models
{
    [Table("Trades")]
    public class Trade
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [ForeignKey(nameof(Team1))]
        public Guid Team1Id { get; set; }

        [Display(Name = "Team 1")]
        public Team Team1 { get; set; }

        [ForeignKey(nameof(Team2))]
        public Guid Team2Id { get; set; }

        [Display(Name = "Team 2")]
        public Guid Team2 { get; set; }

        [ForeignKey(nameof(Team3))]
        public Guid? Team3Id { get; set; }

        [Display(Name = "Team 3")]
        public Team? Team3 { get; set; }
    }
}
