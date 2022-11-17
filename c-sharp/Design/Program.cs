using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project_outline
{
    public class Area
    {
        static double height, width, area, perimeter;

        static void Main(string[] args)
        {
            

            Console.WriteLine("Window height (as decimal): ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Window width (as decimal): ");
            width = double.Parse(Console.ReadLine());

            bool check(double h, double w)
            {
                if ((( .4 < w ) && (3.6 > w)) && ((.4 < h) && (2.1 > h))) {
                return true;
                } else
                {
                return false;
                }
            
            }

            bool legal_values = check(height, width);

            if (!legal_values)
            {
                Console.WriteLine("Entered values are disallowed. Keep height between .5 and 2.0 and width between .5 and 3.5, both inclusive.");
                Environment.Exit(0);
            }

            area = height * width;

            double h_in_ft, h_ft_inches, w_in_ft, w_ft_inches;

            h_in_ft = side_in_ft(height);
            h_ft_inches = side_in_ft_inch(h_in_ft);
            w_in_ft = side_in_ft(width);
            w_ft_inches = side_in_ft_inch(w_in_ft);

            perimeter = (2.0 * h_ft_inches) + (2.0 * w_ft_inches);

            double side_in_ft(double side)
            {
                return side * 3.5;
            }
            double side_in_ft_inch(double side_by_ft)
            {
                return (side_by_ft / 12) + ((side_by_ft % 12) / 12);
            }

            Console.WriteLine("The area (total glass required) of the window is " + area + ".");
            Console.WriteLine("The permiter (total wood required) is " + perimeter + ".");
        }
    }
}
