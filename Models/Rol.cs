using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp.Models
{
    public class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RolId { get; set; }

        [Required(ErrorMessage = "Rol Name is required.")]
        [MaxLength(20,ErrorMessage = "The Rol name must be at least 6 characters long.")]
        public string RolName { get; set; }

        [MaxLength(100, ErrorMessage = "Description cannot exceed 100 characters")]
        public string? RolDescription { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
