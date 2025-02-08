using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp.Models
{
    public class Purchase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchasesId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Discount cannot be negative.")]
        public decimal? Discount { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Taxes cannot be negative.")]
        public decimal? Taxes { get; set; }

        [MaxLength(255, ErrorMessage = "Observations cannot exceed 255 characters.")]
        public string? Observations { get; set; }

        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; }

        [Required(ErrorMessage = "Total is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total cannot be zero or negative.")]
        public decimal Total { get; set; }

        [Required(ErrorMessage = "User is required.")]
        [ForeignKey("UserId")]
        public int UserId {  get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<PurchasesProduct> PurchasesProducts { get; set; }
    }
}
