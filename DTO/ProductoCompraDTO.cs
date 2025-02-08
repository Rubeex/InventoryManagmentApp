using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp.DTO
{
    public class ProductoCompraDTO
    {
        public int Id {  get; set; }
        public string Producto {  get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal total { get; set; }
    }
}
