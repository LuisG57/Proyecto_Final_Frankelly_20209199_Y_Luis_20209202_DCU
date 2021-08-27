using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;

namespace ServicesLayer
{
    public class UserDataService
    {
        private UserCRUD _userData = new UserCRUD();
        public void Insert(User user)
        {
            _userData.Insert(user);
        }
        public User GetUser(int Id)
        {
            return _userData.GetUser(Id);
        }
        public User GetUserLogIn(User user)
        {
            return _userData.GetUserLogIn(user);
        }
        public List<User> GetUsers()
        {

            return _userData.GetUsers();
        }
        public void Update(User user)
        {
            _userData.Update(user);
        }
        public void Delete(User user)
        {
            _userData.Delete(user);
        }
    }
}
