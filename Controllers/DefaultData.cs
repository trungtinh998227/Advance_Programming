using KaraokeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.Controllers
{
    class DefaultData
    {
        /**
         * Add data to DB:
         * Account
         * Room
         * Producer
         * Food
         */
        KaraokeContext context;
        public DefaultData(KaraokeContext context)
        {
            this.context = context;
        }
        public void AddRoom()
        {
            RoomDAO roomDAO = new RoomDAO(context);
            roomDAO.AddRoom(new Room("Phòng 1", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.NORMAL, 120000));
            roomDAO.AddRoom(new Room("Phòng 2", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.NORMAL, 120000));

            roomDAO.AddRoom(new Room("Phòng 3", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.NORMAL, 120000));
            roomDAO.AddRoom(new Room("Phòng 4", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.NORMAL, 120000));

            roomDAO.AddRoom(new Room("Phòng 5", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.NORMAL, 120000));
            roomDAO.AddRoom(new Room("Phòng 6", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.VIP, 200000));

            roomDAO.AddRoom(new Room("Phòng 7", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.VIP, 200000));
            roomDAO.AddRoom(new Room("Phòng 8", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.VIP, 200000));

            roomDAO.AddRoom(new Room("Phòng 9", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.VIP, 200000));
            roomDAO.AddRoom(new Room("Phòng 10", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.VIP, 200000));

            roomDAO.AddRoom(new Room("Phòng 11", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.NORMAL, 120000));
            roomDAO.AddRoom(new Room("Phòng 12", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.NORMAL, 120000));

            roomDAO.AddRoom(new Room("Phòng 13", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.NORMAL, 120000));
            roomDAO.AddRoom(new Room("Phòng 14", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.NORMAL, 120000));

            roomDAO.AddRoom(new Room("Phòng 15", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.NORMAL, 120000));
            roomDAO.AddRoom(new Room("Phòng 16", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.VIP, 200000));

            roomDAO.AddRoom(new Room("Phòng 17", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.VIP, 200000));
            roomDAO.AddRoom(new Room("Phòng 18", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.VIP, 200000));

            roomDAO.AddRoom(new Room("Phòng 19", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.VIP, 200000));
            roomDAO.AddRoom(new Room("Phòng 20", Constants.ROOM_STATUS.EMPTY, Constants.RoomType.VIP, 200000));
            context.SaveChanges();
        }

        public void AddAccount()
        {
            AccountDAO accountDAO = new AccountDAO(context);
            accountDAO.AddAccount(new Account("trungtinh998227", "12345", "Nguyễn Trung Tính", "Quận 7", Constants.POSITION_TYPE.ADMIN));
            accountDAO.AddAccount(new Account("tuanhuydev12", "12345", "Nguyễn Tuấn Huy", "Bình Chánh", Constants.POSITION_TYPE.ADMIN));

            accountDAO.AddAccount(new Account("thungan1", "12345", "Nguyễn Hoàng Uyên Linh", "Quận 7", Constants.POSITION_TYPE.ACCOUNTANT));
            accountDAO.AddAccount(new Account("thungan2", "12345", "Nguyễn Phú Nghĩa", "Quận 2", Constants.POSITION_TYPE.ACCOUNTANT));

            accountDAO.AddAccount(new Account("staff1", "12345", "Nguyễn Trọng Hoàng", "Quận 2", Constants.POSITION_TYPE.STAFF));
            accountDAO.AddAccount(new Account("staff1", "12345", "Nguyễn Trung Tâm", "Quận 7", Constants.POSITION_TYPE.STAFF));
            accountDAO.AddAccount(new Account("staff1", "12345", "Nguyễn Tuấn Tú", "Quận 2", Constants.POSITION_TYPE.STAFF));
            accountDAO.AddAccount(new Account("staff1", "12345", "Nguyễn Thị Mỹ Tiên", "Quận 7", Constants.POSITION_TYPE.STAFF));
        }
        public void AddProducer_Food()
        {
            ProducerDAO producerDAO = new ProducerDAO(context);
            FoodDAO foodDAO = new FoodDAO(context);

            Producer a = new Producer("Red Bull GmbH", "Bangkov", "Thái Lan");
            producerDAO.AddProducer(a);
            
            Food f1 = new Food("RedBull", 50, "Lon", 12000, Constants.FOOD_TYPE.DRINK);
            Food f2 = new Food("Blueberry", 50, "Lon", 20000, Constants.FOOD_TYPE.DRINK);
            Food f3 = new Food("Tropical", 50, "Chai", 25000, Constants.FOOD_TYPE.DRINK);
            Food f4 = new Food("Kiwi Twist", 50, "Lon", 22000, Constants.FOOD_TYPE.DRINK);
            foodDAO.AddFood(f1);
            foodDAO.AddFood(f2);
            foodDAO.AddFood(f3);
            foodDAO.AddFood(f4);
            f1.producers = a;
            f2.producers = a;
            f3.producers = a;
            f4.producers = a;

            Producer b = new Producer("Tân Hiệp Phát", "Bình Dương", "Việt Nam");
            producerDAO.AddProducer(b);
            Food f5 = new Food("Coca Cola", 60, "Lon", 10000, Constants.FOOD_TYPE.DRINK);
            Food f6 = new Food("Number One", 50, "Chai", 15000, Constants.FOOD_TYPE.DRINK);
            Food f7 = new Food("C2", 70, "Lon", 10000, Constants.FOOD_TYPE.DRINK);
            Food f8 = new Food("Cafe Lon", 60, "Lon", 25000, Constants.FOOD_TYPE.DRINK);
            Food f9 = new Food("Strongbow", 100, "Lon", 24000, Constants.FOOD_TYPE.DRINK);
            Food f10 = new Food("Chocopie", 155, "Cái", 7000, Constants.FOOD_TYPE.FOOD);
            foodDAO.AddFood(f5);
            foodDAO.AddFood(f6);
            foodDAO.AddFood(f7);
            foodDAO.AddFood(f8);
            foodDAO.AddFood(f9);
            foodDAO.AddFood(f10);
            f5.producers = b;
            f6.producers = b;
            f8.producers = b;
            f9.producers = b;
            f10.producers = b;
            f7.producers = b;

            Producer c = new Producer("Bách Hóa Xanh", "Hồ Chí Minh", "Việt Nam");
            producerDAO.AddProducer(c);
            Food f11 = new Food("Táo", 25, "Trái", 10000, Constants.FOOD_TYPE.FOOD);
            Food f12 = new Food("Xoài", 50, "Trái", 11000, Constants.FOOD_TYPE.FOOD);
            Food f13 = new Food("Bưởi", 50, "Trái", 25000, Constants.FOOD_TYPE.FOOD);
            Food f14 = new Food("Kem Socola", 150, "Cây", 17000, Constants.FOOD_TYPE.FOOD);
            Food f15 = new Food("Kem Vani", 150, "Cây", 20000, Constants.FOOD_TYPE.FOOD);
            Food f16 = new Food("Đậu phộng", 75, "Bịch", 10000, Constants.FOOD_TYPE.FOOD);
            Food f17 = new Food("Hạt điều", 50, "Bịch", 13000, Constants.FOOD_TYPE.FOOD);
            Food f18 = new Food("Khô gà", 50, "Bịch", 17000, Constants.FOOD_TYPE.FOOD);

            foodDAO.AddFood(f11);
            foodDAO.AddFood(f12);
            foodDAO.AddFood(f13);
            foodDAO.AddFood(f14);
            foodDAO.AddFood(f15);
            foodDAO.AddFood(f16);
            foodDAO.AddFood(f17);
            foodDAO.AddFood(f18);

            f11.producers = c;
            f12.producers = c;
            f13.producers = c;
            f14.producers = c;
            f15.producers = c;
            f16.producers = c;
            f17.producers = c;
            f18.producers = c;

            Producer tch = new Producer("The Coffe House", "Hồ Chí Minh", "Việt Nam");
            producerDAO.AddProducer(tch);
            Food f19 = new Food("Bánh Croissant bơ tỏi", 50, "Cái", 29000, Constants.FOOD_TYPE.FOOD);
            foodDAO.AddFood(f19);
            f19.producers = tch;
            Food f20 = new Food("Bánh Chocolate", 50, "Cái", 29000, Constants.FOOD_TYPE.FOOD);
            foodDAO.AddFood(f20);
            f20.producers = tch;
            Food f21 = new Food("Bánh Teramisu", 50, "Cái", 29000, Constants.FOOD_TYPE.FOOD);
            foodDAO.AddFood(f21);
            f21.producers = tch;
            Food f22 = new Food("Bánh Passion Cheesse", 50, "Cái", 29000, Constants.FOOD_TYPE.FOOD);
            foodDAO.AddFood(f22);
            f22.producers = tch;
            Food f23 = new Food("Bánh gấu Chocolate", 50, "Cái", 39000, Constants.FOOD_TYPE.FOOD);
            foodDAO.AddFood(f23);
            f23.producers = tch;
            Food f24 = new Food("Bánh mì chà bông", 50, "Cái", 32000, Constants.FOOD_TYPE.FOOD);
            foodDAO.AddFood(f24);
            f24.producers = tch;
            context.SaveChanges();
        }
    }
}
