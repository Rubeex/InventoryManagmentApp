using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp.DTO
{
    public class ProveedorDTO
    {
        public int Id { get; set; }
        public string Proveedor {  get; set; }
        public string Dirección { get; set; }
        public string Encargado { get; set; }
        public string Teléfono { get; set; }
        public string Estado { get; set; }
    }
}
