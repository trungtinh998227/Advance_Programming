using KaraokeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KaraokeApp.Controllers
{
    class ProducerDAO
    {
        private static ProducerDAO instance;
        private KaraokeContext db = KaraokeContext.Instance;
        private ProducerDAO() { }

        internal static ProducerDAO Instance
        {
            get { if (instance == null) instance = new ProducerDAO(); return ProducerDAO.instance; }
            set => instance = value;
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
        public string GetProducerName(int proID)
        {
            return db.Producers.FirstOrDefault(pr => pr.ID == proID).Name;
        }
        public Producer GetProducerByName(string proName)
        {
            return db.Producers.FirstOrDefault(pr => pr.Name == proName);
        }
    }
}
