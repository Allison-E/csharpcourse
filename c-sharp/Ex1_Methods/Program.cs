using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace methodsprac
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureProblem();

            //HypotenuseProblem();
        }

        static void TemperatureProblem()
        {
            double fTemp, cTemp;
            Console.WriteLine("Enter a temperature in Farenheit: ");
            fTemp = double.Parse(Console.ReadLine());
            cTemp = CTemp.calcCTemp(fTemp);
            CTemp.displayTempC(cTemp);
        }

        class CTemp
        {

            public static double calcCTemp(double fT)
            {
                return (32.0 - fT) * (5.0 / 9.0);
            }

            public static void displayTempC(double cT)
            {
                Console.WriteLine("Temp in Celcius is " + cT);
            }
        }


        /// <summary>
        /// Hypotenuse problem, not part of portfolio
        /// </summary>
        static void HypotenuseProblem()
        {

            double inputangle, inputlength; //input length is adjacent

            Console.WriteLine("Enter one acute angle (under 90): ");
            inputangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter one adjacent side: ");
            inputlength = double.Parse(Console.ReadLine());

            double angleinrads = inputangle / 57.3;
            double tangent = Math.Tan(angleinrads);
            double opposite = tangent * inputlength;
            double hypotenuse = CalculateHyp(opposite, inputlength);

            Console.WriteLine("The hypotenuse is " + hypotenuse + " and the opposite length is " + opposite);
        }
        static double CalculateHyp(double opp, double adj)
        {
            double hyp, oppsq = Math.Pow(opp, 2.0), adjsq = Math.Pow(adj, 2.0);
            double sum = oppsq + adjsq;

            hyp = Math.Sqrt(sum);
            return hyp;
        }

        
    }

}
