using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp.Models
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleId { get; set; }
        [Required(ErrorMessage = "Client name is required.")]
        [MaxLength(100, ErrorMessage = "Client name cannot exceed 100 characters.")]
        public string Client { get; set; }

        [Required(ErrorMessage = "Total is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total cannot be zero or negative.")]
        public decimal Total { get; set; }

        [Required(ErrorMessage = "User is required")]
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<SaleProduct> SaleProducts { get; set; }
    }
}
