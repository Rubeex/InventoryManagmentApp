using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp.DTO
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }

        public string Estado { get; set; }
        public int Stock {  get; set; }
        public string Proveedor { get; set; }

    }
}
