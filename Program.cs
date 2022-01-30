using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"SERVER=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            // ReadUsers(connection);
            // ReadRoles(connection);
            // ReadTags(connection);
            // ReadUser(connection);
            // CreateUser(connection);
            // UpdateUser(connection);
            // DeleteUser(connection);
            // ReadUsers(connection);
            // DeleteUserById(connection);

            ReadUsersWithRoles(connection);                        
            connection.Close();
        }

        public static void ReadUsersWithRoles(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var items = repository.GetWithRoles();

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
                foreach (var role in item.Roles)
                {
                    Console.WriteLine($" - {role.Name}");
                }
            }
        }

        public static void ReadUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var item = repository.Get(3);
            Console.WriteLine(item.Name);
        }

        public static void CreateUser(SqlConnection connection)
        {
            User user = new User()
            {
                Name = "Eduardo",
                Email = "eduardo@gmail.com",
                PasswordHash = "123",
                Bio = "Dev DotNet",
                Image = "https://",
                Slug = "eduardo"
            };

            var repository = new Repository<User>(connection);
            repository.Create(user);
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }

        public static void UpdateUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var user = repository.Get(4);
            user.Email = "eduardo@outlook.com";
            repository.Update(user);
            Console.WriteLine("Usuário atualizado com sucesso!");
        }

        public static void DeleteUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var user = repository.Get(4);
            repository.Delete(user);
            Console.WriteLine("Usuário excluído com sucesso!");
        }

        public static void DeleteUserById(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            repository.Delete(3);
            Console.WriteLine("Usuário excluído com sucesso!");
        }


        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var items = repository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void ReadTags(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var items = repository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }
        }



    }
}
