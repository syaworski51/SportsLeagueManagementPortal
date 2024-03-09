using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeagueManagementPortal.Models
{
    [Table("Players")]
    public class Player
    {
        /// <summary>
        ///     Globally unique ID of this player.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The ID of the team this player is a part of.
        ///     Null if this player is a free agent.
        /// </summary>
        [ForeignKey(nameof(Team))]
        public Guid? TeamId { get; set; }

        /// <summary>
        ///     The team this player is a part of.
        ///     Null if this player is a free agent.
        /// </summary>
        [Display(Name = "Team")]
        public Team? Team { get; set; }

        /// <summary>
        ///     This player's first name.
        /// </summary>
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        ///     This player's last name.
        /// </summary>
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        ///     The path to this player's headshot.
        ///     Null if there is no headshot available.
        /// </summary>
        [Display(Name = "Headshot Path")]
        public string? HeadshotPath { get; set; }

        /// <summary>
        ///     The current status of this player.
        ///     
        ///     Active ------- This player is currently playing for a team.
        ///     Free agent --- This player is currently a free agent.
        ///     Retired ------ This player has decided to retire from this sport.
        /// </summary>
        [Display(Name = "Status")]
        public string Status { get; set; }

        /// <summary>
        ///     The position this player plays.
        /// </summary>
        [Display(Name = "Position")]
        public string Position { get; set; }

        /// <summary>
        ///     This player's date of birth.
        /// </summary>
        [Display(Name = "DOB")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        ///     This player's current age.
        /// </summary>
        [Display(Name = "Age")]
        public int Age
        {
            get
            {
                var today = DateTime.Now.Date;
                var age = today.Year - DateOfBirth.Year;

                if (DateOfBirth.Date > today.AddYears(-age))
                    age--;

                return age;
            }
        }

        /// <summary>
        ///     The city where this player was born.
        /// </summary>
        [Display(Name = "City")]
        public string City { get; set; }

        /// <summary>
        ///     The province or state where this player was born.
        /// </summary>
        [Display(Name = "Province/State")]
        public string State { get; set; }

        /// <summary>
        ///     The country where this player was born.
        /// </summary>
        [Display(Name = "Country")]
        public string Country { get; set; }

        /// <summary>
        ///     This player's full birthplace.
        /// </summary>
        [Display(Name = "Birthplace")]
        public string Birthplace => $"{City}, {State}, {Country}";

        /// <summary>
        ///     This player's height in feet.
        /// </summary>
        [Display(Name = "ft.")]
        public int Feet { get; set; }

        /// <summary>
        ///     This player's height in inches.
        /// </summary>
        [Display(Name = "in.")]
        public int Inches { get; set; }

        /// <summary>
        ///     This player's height in feet and inches.
        /// </summary>
        [Display(Name = "Height")]
        public string Height => $"{Feet}\' {Inches}\"";

        /// <summary>
        ///     This player's weight in pounds.
        /// </summary>
        [Display(Name = "Weight")]
        public int Weight { get; set; }

        /// <summary>
        ///     This player's dominant side.
        /// </summary>
        [Display(Name = "Dominant Side")]
        public string DominantSide { get; set; }
    }
}
