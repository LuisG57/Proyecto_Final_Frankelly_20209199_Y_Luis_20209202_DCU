using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataLayer
{
    public class UserCRUD
    {
        private ProyectoDCUEntities generalContext = new ProyectoDCUEntities();
        
        public void Insert(User user)
        {
            using (ProyectoDCUEntities context = new ProyectoDCUEntities())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        public User GetUser(int Id)
        {
            var users = generalContext.Users.Find(Id);
            return users;
        }
        public List<User> GetUsers()
        {
            var users = generalContext.Users.ToList();
            return users;
        }
        public void Update(User user)
        {
            using (ProyectoDCUEntities context = new ProyectoDCUEntities())
            {
                var userdbo = context.Users.Find(user.Id);
                userdbo.Name = user.Name;
                userdbo.Last_Name = user.Last_Name;
                userdbo.Email = user.Email;
                userdbo.Password = user.Password;
                context.SaveChanges();
            }
        }
        public void Delete(User user)
        {
            using (ProyectoDCUEntities context = new ProyectoDCUEntities())
            {
                var userdbo = context.Users.Find(user.Id);
                context.Users.Remove(userdbo);
                context.SaveChanges();
            }
        }
    }
}
