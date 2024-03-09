using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeagueManagementPortal.Models
{
    [Table("ContractYears")]
    public class ContractYear
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Contract))]
        public Guid ContractId { get; set; }

        [Display(Name = "Contract")]
        public Contract Contract { get; set; }

        [Display(Name = "Base Salary")]
        public decimal BaseSalary { get; set; }

        [Display(Name = "Signing Bonus")]
        public decimal SigningBonus { get; set; }

        [Display(Name = "Total Cap Hit")]
        public decimal TotalCapHit { get; set; }
    }
}
