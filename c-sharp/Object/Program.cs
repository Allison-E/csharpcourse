using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * #####################################
 * #            CLASS DIAGRAM          # 
 * #####################################   
   

    +---------------------------------+
    |           CountryTest           |
    +---------------------------------+
    |           c1:Country            |
    |           c2:Country            |
    |           c3:Country            |
    +---------------------------------+
    |       +Main(args:string[]       |
    +---------------------------------+
    |             Country             |
    +---------------------------------+
    |           name:string           |
    |             size:int            |
    |           area:double           |
    +---------------------------------+
    |+Country(n:string,s:int,a:double)|
    +---------------------------------+
 
 
 
 */
namespace Objects
{
    class CountryTest
    {
        static void Main(string[] args)
        {


            Country c1 = new Country("UK", 59000000, 245000.0);
            Country c2 = new Country("China", 1330000000, 9600000.0);
            Country c3 = new Country("Malawi", 500000, 118000.0);

            Country[] countries = { c1, c2, c3 };
            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine(countries[i].name + " has a population of " + countries[i].size + " an area of " + countries[i].area);
            }

            Console.ReadKey();
        }
    }
    class Country
    {
        public string name;
        public int size;
        public double area;

        

        public Country(string n, int s, double a)
        {
            name = n;
            size = s;
            area = a;
        }
    }
}


