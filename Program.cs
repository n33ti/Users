using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Users
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random random = new System.Random();
            UserList userlist = new UserList();
            for(int i = 0; i<50; i++)
            {
                User user = new User();
                user.Name = "Neeti" + i;
                user.Id = random.Next(1,70);
                user.Location = "faridabad" + random.Next();
                user.Address = "sector" + random.Next(10,60);
                user.Email = "neeti" + i + "@gmail.com";
                user.isActive = random.Next(1, 3) == 1 ? true : false;
                UserList.users.Add(user);


               
            }
            Console.WriteLine("------------With Linq-----------");
            IUserRepository ur = new UserRepository();
            List<User> users = ur.Users();
            Console.WriteLine("Id \t Name        \t Address \t Email \t Location \t isActive");
            if (users.Count > 0)
            {
                foreach (User user in users)
                {
                    Console.WriteLine(user.Id + "\t" + user.Name + "   \t" + user.Address + "\t" + user.Email + "\t" + user.Location + "\t" + user.isActive);
                }
            }
            Console.WriteLine("------------Find by id----------------\n");
            Console.WriteLine("Enter id ");
            int id = Convert.ToInt32(Console.ReadLine());
            User userWithId = ur.GetUser(id);
            if (userWithId != null)
            {
                Console.WriteLine("Id \t Name        \t Address \t Email \t Location \t isActive");
                Console.WriteLine(userWithId.Id + "\t" + userWithId.Name + "   \t" + userWithId.Address + "\t" + userWithId.Email + "\t" + userWithId.Location + "\t" + userWithId.isActive);
            }
            Console.WriteLine("------------Active Users----------------\n");
            users = ur.ActiveUsers();
            Console.WriteLine("Id \t Name        \t Address \t Email \t Location \t isActive");
            if (users.Count > 0)
            {
                foreach (User user in users)
                {
                    Console.WriteLine(user.Id + "\t" + user.Name + "   \t" + user.Address + "\t" + user.Email + "\t" + user.Location + "\t" + user.isActive);
                }
            }
           
            Console.WriteLine("------------Delete by Id----------------\n");
            Console.WriteLine("Enter ID to delete");
            id = Convert.ToInt32(Console.ReadLine());
            users = ur.DeleteUser(id);
            Console.WriteLine("Id \t Name        \t Address \t Email \t Location \t isActive");
            foreach (User user in users)
            {
                Console.WriteLine(user.Id + "\t" + user.Name + "   \t" + user.Address + "\t" + user.Email + "\t" + user.Location + "\t" + user.isActive);
            }


            Console.WriteLine("------------Add user----------------\n");
            User newUser = new User();
            newUser.Id = random.Next(50, 80);
            Console.Write("name :");
            newUser.Name = Console.ReadLine();
            Console.Write("address :");
            newUser.Address = Console.ReadLine();
            Console.Write("isActive :");
            try
            {
                newUser.isActive = Convert.ToBoolean(Console.ReadLine());
            }
            catch
            {
                newUser.isActive = false;
            }
            Console.Write("location :");
            newUser.Location = Console.ReadLine();
            Console.Write("email :");
            newUser.Email = Console.ReadLine();
            users = ur.AddUser(newUser);
            Console.WriteLine("Id \t Name        \t Address \t Email \t Location \t isActive");
            foreach (User user in users)
            {
                Console.WriteLine(user.Id + "\t" + user.Name + "   \t" + user.Address + "\t" + user.Email + "\t" + user.Location + "\t" + user.isActive);
            }

            Console.WriteLine("------------Without Linq-----------");
            IUserRepository urWL = new UserRepositoryWithoutLinq();
            users = urWL.Users();
            Console.WriteLine("Id \t Name        \t Address \t Email \t Location \t isActive");
            foreach (User user in users)
            {
                Console.WriteLine(user.Id + "\t" + user.Name + "   \t" + user.Address + "\t" + user.Email + "\t" + user.Location + "\t" + user.isActive);
            }
            Console.WriteLine("------------Find by id----------------\n");
            Console.WriteLine("Enter id ");
             id = Convert.ToInt32(Console.ReadLine());
             userWithId = urWL.GetUser(id);
            if (userWithId != null)
            {
                Console.WriteLine("Id \t Name        \t Address \t Email \t Location \t isActive");
                Console.WriteLine(userWithId.Id + "\t" + userWithId.Name + "   \t" + userWithId.Address + "\t" + userWithId.Email + "\t" + userWithId.Location + "\t" + userWithId.isActive);
            }
            Console.WriteLine("------------Active Users----------------\n");
            users = urWL.ActiveUsers();
            if (users.Count > 0)
            {
                Console.WriteLine("Id \t Name        \t Address \t Email \t Location \t isActive");
                foreach (User user in users)
                {
                    Console.WriteLine(user.Id + "\t" + user.Name + "   \t" + user.Address + "\t" + user.Email + "\t" + user.Location + "\t" + user.isActive);
                }
            }

            Console.WriteLine("------------Delete by Id----------------\n");
            Console.WriteLine("Enter ID to delete");
            id = Convert.ToInt32(Console.ReadLine());
            users = urWL.DeleteUser(id);
            Console.WriteLine("Id \t Name        \t Address \t Email \t Location \t isActive");
            foreach (User user in users)
            {
                Console.WriteLine(user.Id + "\t" + user.Name + "   \t" + user.Address + "\t" + user.Email + "\t" + user.Location + "\t" + user.isActive);
            }


            Console.WriteLine("------------Add user----------------\n");
             newUser = new User();
            newUser.Id = random.Next(50, 80);
            Console.Write("name :");
            newUser.Name = Console.ReadLine();
            Console.Write("address :");
            newUser.Address = Console.ReadLine();
            Console.Write("isActive :");
            try
            {
                newUser.isActive = Convert.ToBoolean(Console.ReadLine());
            }
            catch
            {
                newUser.isActive = false;
            }
            Console.Write("location :");
            newUser.Location = Console.ReadLine();
            Console.Write("email :");
            newUser.Email = Console.ReadLine();
            users = urWL.AddUser(newUser);
            Console.WriteLine("Id \t Name        \t Address \t Email \t Location \t isActive");
            foreach (User user in users)
            {
                Console.WriteLine(user.Id + "\t" + user.Name + "   \t" + user.Address + "\t" + user.Email + "\t" + user.Location + "\t" + user.isActive);
            }


        }
    }
}
