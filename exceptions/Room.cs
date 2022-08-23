using System;
namespace exceptions
{
    public class Room
    {



        private int _id;      //qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Room obyekt yaradıldıqda(ctor-da) avtomatik bir vahid artacaq.
        private string _name;
        private float _price;
        private int _personCapacity; //otağın neçə nəfərlik olduğunu bildirir.
        private bool _isAvailable = true;    //otağın rezervasiya olunub olunmadığını göstərir, default olaraq true olmalıdır.



        public int Id { get { return _id; } }
        public Room()
        {
            _id++;
        }


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != " ")
                {
                    _name = value;
                }
            }
        }



        public float Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        public int PersonCapacity
        {
            get
            {
                return _personCapacity;
            }

            set
            {
                if (value > 0)
                {
                    _personCapacity = value;
                }
            }
        }


        public bool IsAvailable
        {
            get
            {
                return _isAvailable;
            }

            set
            {
                if (_isAvailable == true)
                {
                    _isAvailable = true;
                }
            }
        }




        public string ShowInfo()
        {
            return ("Room Price " + Price + "Person Capacity " + PersonCapacity + " Room Name " + IsAvailable);
        }



        public override string ToString()
        {
            return ShowInfo();
        }


        public Room(int Id, string Name, float Price, int PersonCapacit, bool IsAvailable)
        {
            Id = _id;
            Name = _name;
            PersonCapacity = _personCapacity;
            IsAvailable = _isAvailable;
        }
    }



}
