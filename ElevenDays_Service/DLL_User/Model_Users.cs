using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;

namespace DLL_User
{
    public partial class Model_Users : DbContext
    {
        public Model_Users()
            : base("name=Model_Users")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<User>().HasIndex(el => el.Email).IsUnique();
        }
        public DbSet<User> Users { get; set; }

        public static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
               sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
       
    }
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
