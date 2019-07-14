using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MPACore.PhoneBook.EntityFrameworkCore
{
    public static class PhoneBookDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhoneBookDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString,b=>b.UseRowNumberForPaging());
        }

        public static void Configure(DbContextOptionsBuilder<PhoneBookDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection, b => b.UseRowNumberForPaging());
        }
    }
}
