using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

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
        }
        public DbSet<User> Users { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        [Index(IsUnique = true)]
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
