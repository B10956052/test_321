using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_321
{
    class Car
    {
        private string name = "BMW";
        private int cc = 15000;
        private int KM = 9999999;

        public void ShowInfo()
        {
            Console.WriteLine("車名:"+ name);
            Console.WriteLine("cc:"+ cc);
            Console.WriteLine("公里數:"+ KM);
        }
    }
}
