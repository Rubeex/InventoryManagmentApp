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

    public class cProveedor

    {
        private readonly AplicationDbContext _context;
        public cProveedor() 
        {
         _context = ConexionDB.InitializeContext();
        }


        public int CountProveedores()
        {
            var proveedoresCount = _context.suppliers.Where(p=> p.State == "Activo").Count();
            return proveedoresCount;
        }


        public string getProveedorName(int id)
        {
            try
            {
                var nameProveedor = _context.suppliers
                .Where(s => s.SupplierId == id)
                .Select(s => s.SupplierName)
                .FirstOrDefault();

                return nameProveedor;
             }
            catch (Exception ex) {
                return $"❌ Error al obtener el Proveedor: {ex.Message}";

            }
        }


        public List<ProveedorDTO> getProveedores()
        {
            var Proveedor = _context.suppliers.Select(
                u => new ProveedorDTO
                {
                   Id = u.SupplierId,
                   Proveedor = u.SupplierName,
                   Dirección = u.SupplierAddress,
                   Encargado = u.ContactPerson,
                   Teléfono = u.SuplierNumber,
                   Estado = u.State
                }).ToList();

            return Proveedor;
        }


        public Supplier getProveedor(int id)
        {
            var proveedor = _context.suppliers
            .Where(u => u.SupplierId == id)
            .Select(u => new Supplier
            {
                SupplierId = u.SupplierId,
                SupplierName = u.SupplierName,
                SupplierAddress = u.SupplierAddress,
                ContactPerson = u.ContactPerson,
                SuplierNumber = u.SuplierNumber,
                State = u.State
            })
            .FirstOrDefault();

            return proveedor;

        }

        public string eliminarProveedor(int id)
        {
            try
            {
                var proveedor = _context.suppliers.FirstOrDefault(u => u.SupplierId == id);
                _context.suppliers.Remove(proveedor);
                _context.SaveChanges();
                return "✅ Proveedor eliminado exitosamente.";

            }
            catch (Exception ex)
            {
                return $"❌ Error al eliminar el Proveedor: {ex.Message}";

            }
        }

        public string editarProveedor(int id, string proveedor, string direccion, 
            string encargado, string telefono, string estado)
        {
            try
            {
                var Proveedor = _context.suppliers.FirstOrDefault(
                 r => r.SupplierId == id);

                bool ProveedorExiste = _context.suppliers.Any(r => r.SupplierName == proveedor && r.SupplierId != id);
                if (ProveedorExiste)
                {
                    return "❌ Error: Ya existe otro proveedor con este Nombre.";

                }

                Proveedor.SupplierName = proveedor;
                Proveedor.SupplierAddress = direccion;
                Proveedor.ContactPerson = encargado;
                Proveedor.SuplierNumber = telefono;
                Proveedor.State = estado;


                _context.suppliers.Update(Proveedor);
                _context.SaveChanges(true);
                return "✅ Proveedor Editado exitosamente.";


            }
            catch (Exception ex)
            {
                return $"❌ Error al Editar al Proveedor: {ex.Message}";

            }
        }



        public string agregarProveedor(Supplier proveedor)
        {
            try
            {
                var ExistingProveedor = _context.suppliers.Any(
                    u => u.SupplierName.ToLower() == proveedor.SupplierName.ToLower());

                if (ExistingProveedor)
                {
                    return "❌ Error: El Proveedor ya existe.";
                }

                _context.suppliers.Add(proveedor);
                _context.SaveChanges();
                return "✅ Proveedor creado exitosamente.";

            }
            catch (Exception ex)
            {
                return $"❌ Error al crear el Proveedor: {ex.Message}";

            }
        }


    }
}
