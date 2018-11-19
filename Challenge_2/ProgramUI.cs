using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ProgramUI
    {
        ClaimsRepository _claimRepo = new ClaimsRepository();

        public void Run()
        {
            RunMenu();
        }
        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome Komodo Agent, what would you like to do today?" +
                    "\n1. See All Claims" +
                    "\n2. Take Care of Next Claim" +
                    "\n3. Enter a New claim");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        GetClaimsQueue();
                        break;
                    case 2:

                }
            }
        }
    }
}
