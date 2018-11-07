namespace Donut.Infrastructure.Migrations
{
    using Donut.Core.Entites;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Donut.Infrastructure.Persistence.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Persistence\Migrations";
        }

        protected override void Seed(Donut.Infrastructure.Persistence.AppDbContext context)
        {
            context.Items.AddOrUpdate(i => i.Name,
                new Item() { Name = "Item1", CreatedBy = 1, CreatedDate = DateTime.UtcNow },
                new Item() { Name = "Item2", CreatedBy = 1, CreatedDate = DateTime.UtcNow }
                );
        }
    }
}
