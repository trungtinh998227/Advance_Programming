using KaraokeApp.Models;
using System;
using System.Collections.Generic;

namespace KaraokeApp.Controllers
{
    class ProducerDAO
    {
        private KaraokeContext db;
        public ProducerDAO(KaraokeContext context)
        {
            this.db = context;
        }

        public void AddProducer(Producer producer)
        {
            try
            {
                db.Producers.Add(producer);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        public IEnumerable<Producer> GetProducers()
        {
            return db.Producers;
        }
    }
}
