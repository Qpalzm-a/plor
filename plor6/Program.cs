using System;
using System.Reflection;

namespace plor6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.string_property = "qwe"; //Removes the compiler hint
            myClass.nullable_string = null;
            myClass.int_property = 12;
            myClass.nullable_int = null;
            myClass.double_property = 3.14;
            myClass.nullable_double = null;

            int a = myClass.string_property!.Length; //Removes the compiler hint

            foo(myClass);
            foo2(myClass);
            Console.WriteLine(foo3(myClass) + "\n");
            Console.WriteLine(foo4(myClass));
        }


        static void foo(MyClass myClass)
        {
            Type type = myClass.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var property_value = property.GetValue(myClass, null);
                var property_name = property.Name;

                if (property_value == null) property_value = "null";
                Console.WriteLine(property_name + ": " + property_value + "\n");
            }
        }

        static void foo2(MyClass myClass) 
        {
            Type type = myClass.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var property_value = property.GetValue(myClass, null);
                var property_name = property.Name;

                property_value ??= "qwe";
            }
        }
        
        static int foo3(MyClass myClass)
        {
            return myClass?.nullable_int ?? 0;
        }

        static int foo4(MyClass myClass) 
        { 
            return myClass.nullable_int ?? 0;
        }
    }


    class MyClass
    {
        public string string_property { get; set; }
        public string? nullable_string { get; set; }

        public int int_property { get; set; }
        public int? nullable_int { get; set; }

        public double double_property { get; set; }
        public double? nullable_double { get; set; }

    }
}





