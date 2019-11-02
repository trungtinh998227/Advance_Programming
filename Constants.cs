using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.Models
{
    class Constants
    {
        public static Color RoomSelected = Color.FromArgb(158, 158, 158);
        public static Color RoomEmpty = Color.WhiteSmoke;
        public static Color RomDate = Color.PaleVioletRed;
        public class BILL_TYPE
        {
            public static string PAY = "PAY";
            public static string UNPAY = "UNPAY";
        }
        public class DAY_TYPE
        {
            public static string NORMAL = "NORMAL";
            public static string HOLIDAY = "HOLIDAY";
            public static string WEEKEND = "WEEKEND";
        }
        public class FOOD_TYPE
        {
            public static string FOOD = "FOOD";
            public static string DRINK = "DRINK";
        }
        public class PAY_TYPE {
            public static string CASH = "CASH";
            public static string CARD = "CARD";
            public static string SAMSUNGPAY = "SAMSUNGPAY";
        }
        public class POSITION_TYPE
        {
            public static string ADMIN = "ADMIN";
            public static string ACCOUNTANT = "ACCOUNTANT";
            public static string STAFF = "STAFF";
        }
        public class ROOM_STATUS
        {
            public static string EMPTY = "EMPTY";
            public static string DATE = "DATE";
            public static string FULL = "FULL";
        }
        public class RoomType
        {
            public static string VIP = "VIP";
            public static string NORMAL = "NORMAL";
        }
    }
}
