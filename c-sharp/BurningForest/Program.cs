using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurningForest
{
    class Forest
    {
        

        static void Main(string[] args)
        {
            int[,] forestGrid = new int[21, 21];
            char[,] formattedGrid = new char[21, 21];

            IDictionary<int, char> lookup = new Dictionary<int, char>
            {
                {0,' '}, 
                {1,'&'},
                {2,'X'}
            };
            
            Random rnd = new Random(); //psuedo-random numbers for assignment

            for (int i = 0; i < forestGrid.GetLength(0); i++) //loop through outer
            {
                //Console.WriteLine(forestGrid[i,0]);
                for (int j = 0; j < forestGrid.GetLength(1); j++) //again on inner
                {
                    //Console.WriteLine(forestGrid[0, j]);
                    forestGrid[i,j] = rnd.Next(0, 3); //set each node in the array
                    //Console.Write(string.Format("{0} ", forestGrid[i, j])); //print check
                    formattedGrid[i, j] = lookup[forestGrid[i, j]];
                    Console.Write(string.Format("{0} ", formattedGrid[i, j]));
                }
                Console.Write(Environment.NewLine); //print check
            }

        }

    }
    class Cell
    {
        private bool burning;
        private int state;
        private int[] neighbors;

        public void setState(int status)
        {
            state = status;
        }

        public int getState()
        {
            return state;
        }
        //public int[,] forestPlanter()
        //{

        //    IDictionary<int, string> treeStatus = new Dictionary<int, string>();
        //    treeStatus.Add(0, " "); //no tree
        //    treeStatus.Add(1, "&"); //normal tree
        //    treeStatus.Add(2, "X"); //burning tree

        //    int[,] forestMatrix = new int[21, 21]; //grid of trees
        //    Random rnd = new Random(); //psuedo-random numbers for assignment

        //    for (int i = 0; i < forestMatrix.GetLength(0); i++) //loop through outer
        //    {
        //        for (int j = 0; j < forestMatrix.GetLength(1); i++) //again on inner
        //        {
        //            forestMatrix[i, j] = rnd.Next(0, 2); //set each node in the array
        //            Console.Write(string.Format("{0} ", forestMatrix[i, j])); //print check
        //        }
        //        Console.Write(Environment.NewLine + Environment.NewLine); //print check
        //    }

        //    return forestMatrix;
        //}
    }
        
}


