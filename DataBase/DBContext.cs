using Microsoft.EntityFrameworkCore;
using securedDataStoreage.DataBase;

namespace securedDataStoreage.DataBase;

public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {}
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
}

