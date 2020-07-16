using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Users
{
    public class UserRepository :UserList, IUserRepository
    {
     
       public List<User> Users()
        {
            return users;
        }
        public User GetUser(int id)
        {
            User usr = users.Where(user => user.Id == id).FirstOrDefault();


            return usr;
        }
        public List<User> DeleteUser(int id)
        {
            var  res =users.Where(user => user.Id == id).FirstOrDefault();
             if(res!= null)       
            users.Remove(res);
            return users;
        }
        public List<User> ActiveUsers()
        {
            List<User> activeUsers = new List<User>();
           var res = users.Where(user => user.isActive == true);

            foreach(var row in res)
            {
                User user = new User();
                user.Id = row.Id;
                user.Location = row.Location;
                user.Name = row.Name;
                user.isActive = row.isActive;
                user.Address = row.Address;
                activeUsers.Add(user);

                
            }
            return activeUsers;
        }
        public List<User> AddUser(User user)
        {
            users.Add(user);
            return users;
        }

       
    }
}
