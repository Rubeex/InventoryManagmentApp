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
    public class cUser
    {
        private readonly AplicationDbContext _context;
        public cUser()
        {
            _context = ConexionDB.InitializeContext();
        }


       public int CountUsers()
        {
            var usersCount = _context.users.Count();
            return usersCount;
        }


        public string getUserNameUser(int id)
        {
            try
            {
                var user = _context.users.FirstOrDefault(u => u.UserId == id);
      
                return $"{user.FirstName} {user.LastName}";

            }
            catch (Exception ex)
            {
                return $"❌ Error al encontrar el usuario: {ex.Message}";

            }
        }

        public List<UserDTO> getUsers()
        {
            var Users = _context.users.Select(
                u => new UserDTO
                {
                    Id = u.UserId,
                    Nombre = u.FirstName,
                    Apellido = u.LastName,
                    Email = u.Email,
                    Clave = u.Password,
                    Rol = u.Rol.RolName,
                }).ToList();

            return Users;
        }

        public string eliminarUser(int id)
        {
            try
            {
                var user = _context.users.FirstOrDefault(u => u.UserId == id);
                _context.users.Remove(user);
                _context.SaveChanges();
                return "✅ Usuario eliminado exitosamente.";

            }
            catch (Exception ex) 
            {
                return $"❌ Error al eliminar el usuario: {ex.Message}";

            }
        }


        public User getUser(int id)
        {
            var user = _context.users
            .Where(u => u.UserId == id)
            .Select(u => new User
            {
                UserId = u.UserId,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                Password = u.Password,
                RolId = u.RolId
            })
            .FirstOrDefault();

                return user;

        }


        public string editarUser(int id , string name , string lastname , string email , string password , int rol)
        {
            try
            {
                var User = _context.users.FirstOrDefault(
                 r => r.UserId == id);

                bool EmailExiste = _context.users.Any(r => r.Email == email && r.UserId != id);
                if (EmailExiste) 
                {
                    return "❌ Error: Ya existe otro usuario con este Email.";

                }

                User.FirstName = name;
                User.LastName = lastname;
                User.Email = email;
                User.RolId = rol;
                User.Password = BCrypt.Net.BCrypt.HashPassword(password);


                _context.users.Update(User);
                _context.SaveChanges(true);
                return "✅ Usuario Editado exitosamente.";


            }
            catch (Exception ex) 
            {
                return $"❌ Error al Editar el usuario: {ex.Message}";

            }
        }


        public string agregarUser(User user)
        {
            try
            {
                var ExistingEmail = _context.users.Any(
                    u => u.Email.ToLower() == user.Email.ToLower());

                if (ExistingEmail)
                {
                    return "❌ Error: El Email ya existe.";
                }

                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                _context.users.Add(user);
                _context.SaveChanges();
                return "✅ Usuario creado exitosamente.";

            }
            catch (Exception ex)
            {
                return $"❌ Error al crear el usuario: {ex.Message}";

            }
        }
    }
}
