
using System;
namespace LLcsharp
{
    class LinkedListProgram
    {
        static void Main(string[] args)
        {
            string[] townsToAdd = { "Cambridge", "Manchester", "Liverpool", "Bristol"};
            TownList newTownList = new TownList();
            newTownList.listAllNames();
            for(int i = 0; i < townsToAdd.Length; i++)
            {
                newTownList.addTownAtEnd(townsToAdd[i]);
            }
            newTownList.listAllNames();

            //exercise 3

            TownList Ex3TownList = new TownList();
            string[] moreTowns = { "Norwich", "Newcastle", "Lincoln", "London" };
            for (int i = 0; i < moreTowns.Length; i++)
                {
                    Ex3TownList.addTownAtStart(moreTowns[i]);
                }

            Ex3TownList.listAllNames();
            Console.WriteLine();
        }
    }
    class TownNode
    {
        private string townName;          // town's name    
        private TownNode next;            // link to next
        public TownNode(string name)
        {
            townName = name;  // store name
            next = null;                  // initialise next
        }
        public void setNext(TownNode nextNode)
        {
            next = nextNode;  // change next node
        }
        public TownNode getNext()
        {
            return next;
        }
        public string getName()
        {
            return townName;
        }
    } // end class TownNode
    class TownList
    {
        private TownNode start, end;
        public TownList()
        {
            start = null;   // both set to NULL
            end = null;
        }
        public void addTownAtEnd(string name)
        {
            Console.WriteLine("Adding town " + name + " at end");
            TownNode current = new TownNode(name);  // allocate memory;
            if (end == null)       // if list is empty
            {
                start = current;               // change start 
                end = current;    // and end
            }
            else
            {
                end.setNext(current);           // change end's next
                end = current;                  // change end
            }
        }

        public void addTownAtStart(string name)
        {
            Console.WriteLine("Adding town " + name + " at the start");
            TownNode current = new TownNode(name);
            current.setNext(start);
            start = current;
        }
        public void listAllNames()
        {
            TownNode current;
            if (start != null)
            {
                Console.WriteLine("Start of List");
                current = start;
                while (current != null)
                {
                    Console.WriteLine("Next town is: " + current.getName());
                    current = current.getNext();
                }
                Console.WriteLine("End of List");
            }
            else
                Console.WriteLine("List empty");
        }
    }// end class TownList
}