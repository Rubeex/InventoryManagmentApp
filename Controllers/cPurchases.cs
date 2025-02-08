using InventoryManagmentApp.DTO;
using InventoryManagmentApp.Models;
using InventoryManagmentApp.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp.Controllers
{
    public class cPurchases
    {
        private readonly AplicationDbContext _context;
        private List<ProductoCompraDTO> listaCompra = new List<ProductoCompraDTO>();
        public cPurchases() {
         _context = ConexionDB.InitializeContext();
        }

        public List<ProductoCompraDTO> agregarProductoCompra(ProductoCompraDTO productoCompra)
        {
            listaCompra.Add(productoCompra);
            return listaCompra;
        }

        public string actualizarStockProducts(int id)
        {
            try
            {
                var purchase = _context.purchases.Where(c=> c.PurchasesId == id).
                    Select(c=> new Purchase
                    {
                        PurchasesId = c.PurchasesId,
                        Discount = c.Discount,
                        Taxes = c.Taxes,
                        Observations = c.Observations,
                        State = c.State,
                        Total = c.Total,
                        UserId = c.UserId,
                        PurchasesProducts = c.PurchasesProducts,
                    }).FirstOrDefault();


                if (purchase == null)
                {
                    return $"Compra con ID {id} no encontrada.";
                }


                using (var transaction = _context.Database.BeginTransaction()) 
                {

                    purchase.State = "Recibido";
                    _context.purchases.Update(purchase);

                    foreach (var purchaseProduct in purchase.PurchasesProducts)
                    {
                        var product = _context.products.FirstOrDefault(p => p.ProductId == purchaseProduct.ProductId);
                        if (product != null)
                        {
                            product.Stock += purchaseProduct.Quantity;
                        }
                        else
                        {
                            transaction.Rollback();  
                            return $"Producto con ID {purchaseProduct.ProductId} no encontrado.";
                        }
                    }

                    _context.SaveChanges();  // Guarda los cambios en la base de datos
                    transaction.Commit();    // Confirma la transacción
                }

                return "Productos recibidos y stock actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error al actualizar el stock: {ex.Message}";
            }
        }

        public int CountCompras()
        {
            var purchaseCount = _context.purchases.Count();
            return purchaseCount;
        }

        public int CountRecibidosCompras()
        {
            var purchaseCount = _context.purchases.Where(p=> p.State == "Recibido").Count();
            return purchaseCount;
        }

        public decimal totalComprasRecibidas()
        {
            var purchaseTotal = _context.purchases.Where(p => p.State == "Recibido").Sum(
                p=> p.Total);
            return purchaseTotal;
        }



        public List<PurchaseDTO> getCompras()
        {
            var ListaCompras = _context.purchases.Where(c=> c.State == "Pendiente").Select(
                c => new PurchaseDTO
                {
                    Id = c.PurchasesId,
                    Cantidad = c.PurchasesProducts.Sum(p=> p.Quantity),
                    Estado = c.State
                }).ToList();
            return ListaCompras;
        }

        public List<PurchaseDTO> getComprasRecibidas()
        {
            var ListaCompras = _context.purchases.Where(c => c.State == "Recibido").Select(
                c => new PurchaseDTO
                {
                    Id = c.PurchasesId,
                    Cantidad = c.PurchasesProducts.Sum(p => p.Quantity),
                    Estado = c.State,
                }).ToList();
            return ListaCompras;
        }

        public Purchase getPurchs(int id)
        {
            var purchase = _context.purchases.Where(c => c.PurchasesId == id).
               Select(c => new Purchase
               {
                   PurchasesId = c.PurchasesId,
                   Discount = c.Discount,
                   Taxes = c.Taxes,
                   Observations = c.Observations,
                   State = c.State,
                   Total = c.Total,
                   UserId = c.UserId,
                   PurchasesProducts = c.PurchasesProducts,
               }).FirstOrDefault();

            return purchase;
        }

        public List<ProductoCompraDTO> ListaProductosCompra(List<PurchasesProduct> lista)
        {
           List<ProductoCompraDTO> listaCompra = new List<ProductoCompraDTO>();

            foreach (var item in lista)
            {
                string productName = _context.products.Where(p=> p.ProductId == item.ProductId)
                    .Select(p=> p.ProductName).FirstOrDefault();

                var CompraProducto = new ProductoCompraDTO
                {
                  Id = item.ProductId,
                  Producto = productName,
                  Cantidad = item.Quantity,
                  Precio = item.Price,
                  total = item.Price * item.Quantity,

                };

                listaCompra.Add(CompraProducto);

            }

            return listaCompra;
        }

        public string agregarCompra(Purchase purchase)
        {
            using (var Transacction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.purchases.Add(purchase);
                    _context.SaveChanges();

                    foreach (var item in listaCompra)
                    {
                        var CompraProducto = new PurchasesProduct
                        {
                            PurchasesId = purchase.PurchasesId,
                            ProductId = item.Id,
                            Quantity = item.Cantidad,
                            Price = item.Precio,
                        };

                        _context.purchasesProducts.Add(CompraProducto);

                    }

                    _context.SaveChanges();
                    Transacction.Commit(); 
                    listaCompra.Clear();
                    return "✅ Compra realizada exitosamente.";
                }
                catch (Exception ex) {
                    Transacction.Rollback();
                    return $"❌ Error al guardar la Compra: {ex.Message}";
                }
            }
        }
      
    }
}
