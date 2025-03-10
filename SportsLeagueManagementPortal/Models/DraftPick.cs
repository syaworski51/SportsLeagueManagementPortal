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

        [Display(Name = "Name")]
        public string Name => $"{Year} {Round}{GetOrdinalSuffix(Round)} round pick";

        [ForeignKey(nameof(OriginalTeam))]
        public Guid OriginalTeamId { get; set; }

        [Display(Name = "Original Team")]
        public Team OriginalTeam { get; set; }


        private static string GetOrdinalSuffix(int number)
        {
            int last2Digits = number % 100;
            if (last2Digits < 11 || last2Digits > 13)
            {
                int lastDigit = number % 10;
                switch (lastDigit)
                {
                    case 1:
                        return "st";

                    case 2:
                        return "nd";

                    case 3:
                        return "rd";
                }
            }

            return "th";
        }
    }
}
