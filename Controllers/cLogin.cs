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
    public class cLogin
    {
        private readonly AplicationDbContext _context;
        public cLogin() { 
        _context = ConexionDB.InitializeContext();
        }

        public string Login(Login login) {

            try
            {
                var emailExist = _context.users.Any(
                    u=> u.Email == login.Email);

                if (!emailExist) {
                    return "❌ Error: El Email no existe.";
                }

                var user = _context.users.FirstOrDefault(
                    u => u.Email == login.Email);

                bool Password = BCrypt.Net.BCrypt.Verify(login.Password, user.Password);

                if (Password) 
                {
                    return "✅ ¡Bienvenido de nuevo! Has iniciado sesión correctamente.";
                }
                else
                {
                    return "❌ Error: La contraseña ingresada es incorrecta.";

                }

            }
            catch (Exception ex)
            {

                return $"❌ Error al iniciar sesión. Si el problema persiste, contacta al soporte: {ex.Message}";

            }

        }

        public UserDTO getUser(string email)
        {
            var user = _context.users.Where(u => u.Email == email).Select(
                u => new UserDTO()
                {
                    Id = u.UserId,
                    Nombre = u.FirstName,
                    Apellido = u.LastName,
                    Email = u.Email,
                    Rol = u.Rol.RolName,
                })
                .FirstOrDefault();

            return user;
        }

    }
}
