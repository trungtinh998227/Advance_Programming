using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.Models
{
    class KaraokeContext: DbContext
    {
        
        public KaraokeContext(): base(@"Data Source=DESKTOP-6IUC6KR;Initial Catalog=KaraokeApp;Integrated Security=True")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<KaraokeContext>());
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Account_Room> Account_Rooms { get; set; }
        public DbSet<Food_Room> Food_Rooms { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}
