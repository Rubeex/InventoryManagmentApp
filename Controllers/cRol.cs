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
    public class cRol
    {
        private readonly AplicationDbContext _context;
        public cRol() 
        {
          _context = ConexionDB.InitializeContext();
        }


        public List<RolDTO> getRoles()
        {
            var ListaRol = _context.rols.Select(r => new RolDTO

            {
                Id = r.RolId,
                Rol = r.RolName,
                Description = r.RolDescription
            }
            ).ToList();

            return ListaRol;
        }
        public RolDTO getRol(int id)
        {
          
                var rol = _context.rols.Where(r => r.RolId == id).Select(
                    r => new RolDTO
                    {
                        Id = r.RolId,
                        Rol = r.RolName,
                        Description = r.RolDescription  
                    }).FirstOrDefault();

                return rol;
         
        }

        public string editarRol(int id, string rol , string description)
        {
            try
            {
                var Rol = _context.rols.FirstOrDefault(
                    r => r.RolId == id);

                bool rolExiste = _context.rols.Any(r => r.RolName == rol && r.RolId != id);

                if (rolExiste)
                {
                    return "❌ Error: Ya existe otro rol con este nombre.";
                }

                Rol.RolName = rol;
                Rol.RolDescription = description;

                _context.rols.Update(Rol);
                _context.SaveChanges();
                return "✅ Rol Editado exitosamente.";


            }
            catch (Exception ex) {
                return $"❌ Error al Editar el rol: {ex.Message}";

            }
        }


        public string eliminarRol(int id)
        {
            try
            {
                var Rol = _context.rols.FirstOrDefault( r => r.RolId == id);
                _context.rols.Remove(Rol);
                _context.SaveChanges();
                return "✅ Rol Eliminado exitosamente.";

            }
            catch (Exception ex) {
                return $"❌ Error al Eliminar el rol: {ex.Message}";

            }
        }

        public string agregarRol(Rol rol)
        {
            try
            {
                var existeRol = _context.rols
                    .Any(r => r.RolName.ToLower() == rol.RolName.ToLower());

                if (existeRol)
                {
                    return "❌ Error: El rol ya existe.";
                }

                _context.rols.Add(rol);
                _context.SaveChanges();
                return "✅ Rol creado exitosamente.";
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error en logs
                return $"❌ Error al crear el rol: {ex.Message}";
            }
        }
    }
}
