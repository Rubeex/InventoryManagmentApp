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
    public class cSales
    {
        private readonly AplicationDbContext _context;
        private List<ProductoVentaDTO> listaVenta = new List<ProductoVentaDTO>();

        public cSales()
        {
           _context = ConexionDB.InitializeContext();
        }

        public List<ProductoVentaDTO> agregarProductoVenta(ProductoVentaDTO productoVenta)
        {
            listaVenta.Add(productoVenta);
            return listaVenta;
        }

        public int CountVentas()
        {
            var salesCount = _context.sales.Count();
            return salesCount;
        }

        public decimal totalVentas()
        {
            var ventasTotal = _context.sales.Sum(
                p => p.Total);
            return ventasTotal;
        }


        public List<SaleDTO> getVentas()
        {
            var ListaVentas = _context.sales.Select(
                c => new SaleDTO
                {
                    Id = c.SaleId,
                    Cantidad = c.SaleProducts.Sum(p => p.Quantity),
                    Cliente = c.Client
                }).ToList();
            return ListaVentas;
        }

        public string agregarVenta(Sale sale)
        {
            using (var Transacction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.sales.Add(sale);
                    _context.SaveChanges();

                    if (sale.SaleId == 0)
                    {
                        Transacction.Rollback();
                        return "❌ Error: El ID de la venta no se generó correctamente.";
                    }

                    foreach (var item in listaVenta)
                    {
                        var Producto = _context.products.FirstOrDefault(p => p.ProductId == item.Id);

                        if (Producto == null)
                        {
                            Transacction.Rollback();
                            return $"❌ Error: Producto con ID {item.Id} no encontrado.";
                        }

                        if (Producto.Stock == null || Producto.Stock < item.Cantidad)
                        {
                            Transacction.Rollback();
                            return $"❌ Error: Stock insuficiente para el producto {Producto.ProductName}. Disponible: {Producto.Stock}, Requerido: {item.Cantidad}.";
                        }

                        Producto.Stock -= item.Cantidad;

                        var VentaProductos = new SaleProduct
                        {
                            SaleId = sale.SaleId,
                            ProductId = item.Id,
                            Quantity = item.Cantidad,
                            Price = item.Precio,
                        };

                        Console.WriteLine($"Agregando SaleProduct: SalesId={VentaProductos.SaleId}, ProductId={VentaProductos.ProductId}, Quantity={VentaProductos.Quantity}, Price={VentaProductos.Price}");

                        _context.salesProducts.Add(VentaProductos);
                    }

                    _context.SaveChanges();
                    Transacction.Commit();
                    listaVenta.Clear();
                    return "✅ Venta realizada exitosamente.";
                }
                catch (Exception ex)
                {
                    Transacction.Rollback();
                    return $"❌ Error al guardar la Venta: {ex.Message} {ex.InnerException?.Message}";
                }
            }
        }



    }
}
