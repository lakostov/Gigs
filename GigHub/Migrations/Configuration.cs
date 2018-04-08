namespace GigHub.Migrations
{
    using GigHub.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<GigHub.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GigHub.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Genres.AddOrUpdate(
                g => g.Id,
                new Genre { Id= 1, Name = "Jazz" },
                new Genre { Id= 2, Name = "Blues" },
                new Genre { Id= 3, Name = "Rock" },
                new Genre { Id= 4, Name = "Country" }
                );
        }
    }
}
