using KaraokeApp.Models;
using System;
using System.Linq;

namespace KaraokeApp.Controllers
{
    class BillInforDAO
    {
        private static BillInforDAO instance;
        KaraokeContext db = KaraokeContext.Instance;
        private BillInforDAO() { }

        internal static BillInforDAO Instance
        {
            get { if (instance == null) instance = new BillInforDAO(); return BillInforDAO.instance; }
            set => instance = value;
        }

        public void AddBillInfor(BillInfor bi)
        {
            try
            {
                if (db.BillInfors.FirstOrDefault(bill => bill.checkIn == bi.checkIn && bill.checkOut == bi.checkOut && bill.Payment == bi.Payment) == null)
                {
                    Console.WriteLine("asdsad");
                    db.BillInfors.Add(bi);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
