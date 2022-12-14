using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskHome
{
    internal class Car
    {
        public string name;
        public string color;
        private int _horsepower;
        public int HorsePower {

            get
            {
                if (_horsepower > 100)
                {
                    return _horsepower;
                }

                return -1;
            }

            set
            {
                _horsepower = value;

            }
        }
    }
}
        

//        public Car(string text) : this()
//        {
//            Console.WriteLine("hello 1");
//        }
//        public Car()
//        {
//            Console.WriteLine("Empty");
//        }

//        public Car(string text, int n) : this(text)
//        {
//            Console.WriteLine("Shaiq", n);
//        }
//    }
//}

