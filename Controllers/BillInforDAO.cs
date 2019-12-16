using KaraokeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                db.BillInfors.Add(bi);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
