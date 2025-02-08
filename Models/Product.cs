using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        [MaxLength(70, ErrorMessage = "Product name cannot exceed 70 characters.")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; }
        [Required(ErrorMessage = "Stock is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock cannot be negative.")]

        public int Stock {  get; set; } = 0;
        [Required(ErrorMessage = "Supplier is required")]
        [ForeignKey("SupplierId")]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<PurchasesProduct> PurchasesProducts { get; set; }
        public virtual ICollection<SaleProduct> SaleProducts { get; set; }
    }
}
