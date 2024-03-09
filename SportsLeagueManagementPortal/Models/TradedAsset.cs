using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeagueManagementPortal.Models
{
    [Table("TradedAssets")]
    public class TradedAsset
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Trade))]
        public Guid TradeId { get; set; }

        [Display(Name = "Trade")]
        public Trade Trade { get; set; }

        [ForeignKey(nameof(TradedFrom))]
        public Guid TradedFromId { get; set; }

        [Display(Name = "From")]
        public Team TradedFrom { get; set; }

        [ForeignKey(nameof(TradedTo))]
        public Guid TradedToId { get; set; }

        [Display(Name = "To")]
        public Team TradedTo { get; set; }

        [Display(Name = "Asset")]
        public string Asset { get; set; }
    }
}
