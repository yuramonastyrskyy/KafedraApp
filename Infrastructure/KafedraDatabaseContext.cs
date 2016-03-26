using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Infrastructure
{
    public class KafedraDatabaseContext : DbContext
    {
        static KafedraDatabaseContext()
        {
            //Disables DbInitializers
            //Database.SetInitializer<WorldOfWordsDatabaseContext>(null);

            //Examples of DbInitializers:
            //Names mentions what they are doing
            //Database.SetInitializer<WorldOfWordsDatabaseContext>(new CreateDatabaseIfNotExists<WorldOfWordsDatabaseContext>());
            //Database.SetInitializer<WorldOfWordsDatabaseContext>(new DropCreateDatabaseAlways<WorldOfWordsDatabaseContext>());
            //Database.SetInitializer<WorldOfWordsDatabaseContext>(new DropCreateDatabaseIfModelChanges<WorldOfWordsDatabaseContext>());

            //Use Custom DbInitializer
            //Database.SetInitializer<WorldOfWordsDatabaseContext>(new WorldOfWordsDbInitializer());

            //usedTHIS//Database.SetInitializer(new MigrateDatabaseToLatestVersion<WorldOfWordsDatabaseContext, Configuration>("WorldOfWordsDatabaseContext"));
            //Database.SetInitializer<WorldOfWordsDatabaseContext>(null);
        }

        public KafedraDatabaseContext()
            : base("Name=KafedraDatabaseContext")
        {
        }

        //public DbSet<IncomingUser> IncomingUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Configurations.Add(new LanguageConfiguration());
        }
    }
}
