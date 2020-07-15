using System;
using System.Collections.Generic;
using System.Text;

namespace Users
{
    public class UserRepositoryWithoutLinq : UserList, IUserRepository
    {
       
      public  List<User> Users()
        {
            return users;
        }
       public User GetUser(int id)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                    return user;
            }
            return null;
        }
       public List<User> DeleteUser(int id)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == id)
                    users.RemoveAt(i);
            }
            return users;
        }
       public  List<User> ActiveUsers()
        {
            List<User> activeUsers = new List<User>();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].isActive == true)
                    activeUsers.Add(users[i]);
            }
            return activeUsers;

        }
      public  List<User> AddUser(User user)
        {
            users.Add(user);
               return users;
        }

        List<User> IUserRepository.Users()
        {
            throw new NotImplementedException();
        }

        User IUserRepository.GetUser(int id)
        {
            throw new NotImplementedException();
        }

        List<User> IUserRepository.DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        List<User> IUserRepository.ActiveUsers()
        {
            throw new NotImplementedException();
        }

        List<User> IUserRepository.AddUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
