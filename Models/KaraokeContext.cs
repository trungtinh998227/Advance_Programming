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
        private static KaraokeContext INSTANCE;
        public KaraokeContext(): base(@"Data Source=DESKTOP-6IUC6KR;Initial Catalog=KaraokeApp;Integrated Security=True")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<KaraokeContext>());
        }
        internal static KaraokeContext Instance { 
            get { if (INSTANCE == null) INSTANCE = new KaraokeContext(); return KaraokeContext.INSTANCE; }
            private set => INSTANCE = value; 
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Account_Room> Account_Rooms { get; set; }
        public virtual DbSet<Food_Room> Food_Rooms { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
    }
}
