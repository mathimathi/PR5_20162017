using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InLES.Models
{
    public class HotelRepository
    {
        private List<Hotel> hotels;

        private static HotelRepository instance;

        public static HotelRepository GetInstance()
        {
            if(instance == null)
                instance = new HotelRepository();
            return instance;
        }
        private HotelRepository()
        {
             hotels = new List<Hotel>();
            CreateHotels();
        }

        private void CreateHotels()
        {
            hotels.Add(new Hotel { Country = "Belgie", Id = 1, Name = "Hilton", Price = 300});
            hotels.Add(new Hotel { Country = "Belgie", Id = 2, Name = "Plaza", Price = 200 });
            hotels.Add(new Hotel { Country = "Frankrijk", Id = 3, Name = "Novotel", Price = 80 });
            hotels.Add(new Hotel { Country = "Nederland", Id = 4, Name = "F1", Price = 25 });
        }

        public List<Hotel> GetHotels()
        {
            return hotels;
        }

        public Hotel GetHotel(int id)
        {
            return hotels.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Hotel h)
        {
            hotels.Add(h);
        }
    }
}