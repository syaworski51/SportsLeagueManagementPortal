using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeagueManagementPortal.Models
{
    [Table("Positions")]
    public class Position
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Sport))]
        public Guid SportId { get; set; }

        [Display(Name = "Sport")]
        public Sport Sport { get; set; }

        [Display(Name = "Symbol")]
        public string Symbol { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }
    }
}
