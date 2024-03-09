using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeagueManagementPortal.Models
{
    /// <summary>
    ///     Represents a contract signed between a team and a player.
    /// </summary>
    [Table("Contracts")]
    public class Contract
    {
        /// <summary>
        ///     Globally unique ID for this contract.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     ID of the league this contract belongs to.
        /// </summary>
        [ForeignKey(nameof(League))]
        public Guid LeagueId { get; set; }

        /// <summary>
        ///     The league this contract belongs to.
        /// </summary>
        [Display(Name = "League")]
        public League League { get; set; }

        /// <summary>
        ///     The team this contract was signed by.
        /// </summary>
        [ForeignKey(nameof(Team))]
        public Guid TeamId { get; set; }

        /// <summary>
        ///     The team this contract was signed by.
        /// </summary>
        [Display(Name = "Team")]
        public Team Team { get; set; }

        /// <summary>
        ///     ID of the player signing this contract.
        /// </summary>
        [ForeignKey(nameof(Player))]
        public Guid PlayerId { get; set; }

        /// <summary>
        ///     The player signing this contract.
        /// </summary>
        [Display(Name = "Player")]
        public Player Player { get; set; }

        /// <summary>
        ///     The date this contract was signed.
        /// </summary>
        [Display(Name = "Date Signed")]
        public DateTime DateSigned { get; set; }

        /// <summary>
        ///     The duration of this contract in years.
        /// </summary>
        [Display(Name = "Duration")]
        public int Duration { get; set; }

        /// <summary>
        ///     The total value of this contract.
        /// </summary>
        [Display(Name = "Total Value")]
        [Column(TypeName = "decimal(11,2)")]
        public decimal TotalValue { get; set; }

        /// <summary>
        ///     The current status of this contract.
        ///     
        ///     Awaiting player signature --- Waiting for the player to sign this contract.
        ///     Awaiting league approval ---- Waiting for the league to approve this contract.
        ///     Approved -------------------- The league has approved this contract.
        ///     In progress ----------------- This contract is in progress.
        ///     Expired --------------------- This contract has expired.
        /// </summary>
        [Display(Name = "Status")]
        public string Status { get; set; }

        /// <summary>
        ///     The type of free agent the player will be when this contract expires.
        /// </summary>
        [Display(Name = "Expiry Status")]
        public string ExpiryStatus { get; set; }
    }
}
