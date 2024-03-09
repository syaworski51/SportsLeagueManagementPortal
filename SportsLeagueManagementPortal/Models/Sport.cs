using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeagueManagementPortal.Models
{
    [Table("Sports")]
    public class Sport
    {
        /// <summary>
        ///     The unique ID for this sport.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The name of this sport (ex. hockey, football, baseball, basketball, soccer, etc.).
        /// </summary>
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        ///     The type of sport this is (team, individual).
        /// </summary>
        [Display(Name = "Type")]
        public string Type { get; set; }
    }
}
