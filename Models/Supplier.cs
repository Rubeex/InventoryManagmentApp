using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp.Models
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Supplier Name is required.")]
        [MaxLength(60, ErrorMessage = "Supplier Name cannot exceed 60 characters.")]
        [MinLength(3, ErrorMessage = "Supplier Name must be at least 3 characters.")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Supplier Address is required.")]
        [MaxLength(150, ErrorMessage = "Supplier Address cannot exceed 150 characters.")]
        [MinLength(10, ErrorMessage = "Supplier Address must be at least 10 characters.")]
        public string SupplierAddress { get; set; }

        [Required(ErrorMessage = "Contact Person is required.")]
        [MaxLength(50, ErrorMessage = "Contact Person cannot exceed 50 characters.")]
        [MinLength(3, ErrorMessage = "Contact Person must be at least 3 characters.")]
        public string ContactPerson { get; set; }

        [Required(ErrorMessage = "Supplier Number is required.")]
        [MaxLength(10, ErrorMessage = "Supplier Number cannot exceed 10 characters.")]
        [MinLength(6, ErrorMessage = "Supplier Number must be at least 6 characters.")]
        public string SuplierNumber { get; set; }

        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        
    }
}
