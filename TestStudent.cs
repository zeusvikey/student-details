using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsProject1
{
    public class TestStudent
    {
        int? _id;
        string? _name;
        string? _sec;
        double? _rollnum;
        string? _Addres;
        double? _number;

        public TestStudent()
        {
            Console.WriteLine("Enter Your id number");
            _id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Name");
            _name = Console.ReadLine();
            Console.WriteLine("Enter Your Section");
            _sec = Console.ReadLine();
            Console.WriteLine("Enter your roll number");
            _rollnum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Address");
            _Addres = Console.ReadLine();
            Console.WriteLine("Enter Your Number");
            _number = double.Parse(Console.ReadLine());
        }
        public object? this[int index]
        {
            get
            {
                if (index == 1)
                {
                    return _id;
                }
                else if (index == 2)
                {
                    return _name;
                }
                else if (index == 3)
                {
                    return _sec;
                }
                else if (index == 4)
                {
                    return _rollnum;
                }
                else if (index == 5)
                {
                    return _number;
                }
                else if (index == 6)
                {
                    return _Addres;
                }
                return null;


            }
            set
            {
                if (index == 2)
                {
                    _name = (string?)value;
                }
                else if (index == 3)
                {
                    _sec = (string?)value;
                }
                else if (index == 6)
                {
                    _Addres = (string?)value;
                }


            }



        }

        public object? this[string key]
        {
            get
            {
                if (key.ToUpper() == "ID")
                {
                    return _id;
                }
                else if (key.ToUpper() == "Name")
                {
                    return _name;
                }
                else if (key.ToUpper() == "SEC")
                {
                    return _sec;
                }
                else if (key.ToUpper() == "ROLLNUMBER")
                {
                    return _rollnum;
                }
                else if (key.ToUpper() == "ADDRES")
                {
                    return _Addres;
                }
                else if (key.ToUpper() == "NUMBER")
                {
                    return _number;
                }
                return null;

            }
            set
            {
                if (key.ToLower() == "id")
                {
                    _id = (int?)value;
                }
                else if (key.ToLower() == "name")
                {
                    _name = (string?)value;
                }
                else if (key.ToLower() == "sec")
                {
                    _sec = (string?)value;
                }
                else if (key.ToLower() == "address")
                {
                    _Addres = (string?)value;
                }


            }
        }

    }
}
