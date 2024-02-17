namespace DataAccessLayer.Migrations
{
    using DataAccessLayer.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.Models.OneGOV2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.Models.OneGOV2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                context.Likes.AddOrUpdate(new Models.Like
                {
                      LikeID= i,
                    BlogID = random.Next(1, 21),
                    
                    UserName= "User-" + random.Next(1, 10),


                });
            }

            }
        }
    }

    


