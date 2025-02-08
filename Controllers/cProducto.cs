using InventoryManagmentApp.DTO;
using InventoryManagmentApp.Models;
using InventoryManagmentApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp.Controllers
{
    public class cProducto
    {
        private readonly AplicationDbContext _context;
        public cProducto() {
        _context = ConexionDB.InitializeContext();
        }

        public int CountPrductos()
        {
            var productosCount = _context.products.Count();
            return productosCount;
        }


        public List<ProductoDTO> GetProducts() {
        
            var products = _context.products.Select(
                p=> new ProductoDTO{
                Id = p.ProductId,
                Producto = p.ProductName,
                Precio = p.Price,
                Estado = p.State,
                Stock = p.Stock,
                Proveedor = p.Supplier.SupplierName,

            }).ToList();

            return products;
        
        }

        public List<StockDTO> GetProductsStocks()
        {

            var products = _context.products.Where(p=> p.State == "Activo").Select(
                p => new StockDTO
                {
                    Id = p.ProductId,
                    Producto = p.ProductName,
                    Stock = p.Stock,
                    Proveedor = p.Supplier.SupplierName,

                }).ToList();

            return products;

        }

        public List<ProductoDTO> GetProductosNecesarios()
        {

            var products = _context.products.Where(p=> p.State == "Activo").Select(
                p => new ProductoDTO
                {
                    Id = p.ProductId,
                    Producto = p.ProductName,

                }).ToList();

            return products;

        }


        public string editarProducto(int id, string producto, decimal precio, string estado,
           int stock, int proveedor)
        {
            try
            {
                var Producto = _context.products.FirstOrDefault(
                 r => r.ProductId == id);

                bool ProductoExiste = _context.products.Any(r => r.ProductName == producto && r.ProductId != id);
                if (ProductoExiste)
                {
                    return "❌ Error: Ya existe otro Producto con este Nombre.";

                }

                Producto.ProductName = producto;
                Producto.Price = precio;
                Producto.State = estado;
                Producto.Stock = stock;
                Producto.SupplierId = proveedor;


                _context.products.Update(Producto);
                _context.SaveChanges(true);
                return "✅ Producto Editado exitosamente.";


            }
            catch (Exception ex)
            {
                return $"❌ Error al Editar el Producto: {ex.Message}";

            }
        }

        public Product getProduct(int id)
        {
            var producto = _context.products
            .Where(u => u.ProductId == id)
            .Select(u => new Product
            {
                ProductId = u.ProductId,
                ProductName = u.ProductName,
                Price = u.Price,
                State = u.State,
                SupplierId = u.SupplierId,
            })
            .FirstOrDefault();

            return producto;

        }

        public Product getProductVentas(int id)
        {
            var producto = _context.products
            .Where(u => u.ProductId == id)
            .Select(u => new Product
            {
                ProductId = u.ProductId,
                ProductName = u.ProductName,
                Price = u.Price,
                State = u.State,
                Stock = u.Stock,
                SupplierId = u.SupplierId,
            })
            .FirstOrDefault();

            return producto;

        }

        public string eliminarProducto(int id)
        {
            try
            {
                var producto = _context.products.FirstOrDefault(u => u.ProductId == id);
                _context.products.Remove(producto);
                _context.SaveChanges();
                return "✅ Producto eliminado exitosamente.";

            }
            catch (Exception ex)
            {
                return $"❌ Error al eliminar el Producto: {ex.Message}";

            }
        }

        public string agregarProducto(Product producto)
        {
            try
            {
                var ExistingProducto = _context.products.Any(
                    u => u.ProductName.ToLower() == producto.ProductName.ToLower());

                if (ExistingProducto)
                {
                    return "❌ Error: El Producto ya existe.";
                }

                _context.products.Add(producto);
                _context.SaveChanges();
                return "✅ Producto creado exitosamente.";

            }
            catch (Exception ex)
            {
                return $"❌ Error al crear el Producto: {ex.Message}";

            }
        }

    }
}
