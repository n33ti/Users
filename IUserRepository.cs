using System;
using System.Collections.Generic;
using System.Text;

namespace Users
{
    public interface IUserRepository
    {
        public static List<User> users { get; set; }
        List<User> Users();
        User GetUser(int id);
        List<User> DeleteUser(int id);
        List<User> ActiveUsers();
        List<User> AddUser(User user);

    }
}
