using System;

namespace plor4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Properties property = new Properties();

            property.Positive_number = 245;
            Console.WriteLine(property.Calculated_property);
            Console.WriteLine(property.Positive_number);
        }
    }


    class Properties
    {
        private string short_property { get; set; }
        private string long_property;

        public string Long_property
        {
            get { return long_property; }
            set { long_property = value; }
        }

        private int positive_number;

        public int Positive_number
        {
            get { return positive_number; }
            set { if (value >= 0) positive_number = value; }
        }

        private bool calculated_property;

        public bool Calculated_property
        {
            get 
            { 
                if (positive_number < 25) return true;
                else return false; 
            }
        }
    }

}
