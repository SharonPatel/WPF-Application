using System;
using System.Collections.Generic;
using System.Text;

namespace Sharon_MidtermV2
{
    class Airlines
    {
        private int _ID;
        private string _Name;
        private string _Airplane;
        private int _SeatsAvailable;
        private string _MealAvailable;

        public Airlines()
        {

        }

        public Airlines(int id, string name, string airplane, int seatavb, string mealavb)
        {
            ID = id;
            Name = name;
            Airplane = airplane;
            SeatsAvailable = seatavb;
            MealAvailable = mealavb;
        }
        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Airplane { get => _Airplane; set => _Airplane = value; }
        public int SeatsAvailable { get => _SeatsAvailable; set => _SeatsAvailable = value; }
        public string MealAvailable { get => _MealAvailable; set => _MealAvailable = value; }


        public override string ToString()
        {
            string air1 = String.Format("{0,-9}{1,-10}{2,-10}{3,-10}{4,-10}", ID, Name, Airplane, SeatsAvailable, MealAvailable);
            return air1;
        }
    }
}
