using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class ProgramUI
    {
        OutingsRepository _outingRepo = new OutingsRepository();

        public void Run()
        {
            RunMenu();
        }
        public void RunMenu()
        {
            bool isRunning = true;
            while(isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome Accountants, What would you like to do today?" +
                    "\n1. Add New Outing" +
                    "\n2. View All Outings" +
                    "\n3. View Costs of Outings" +
                    "\n4. Exit");

                int intput = int.Parse(Console.ReadLine());
                switch (intput)
                {
                    case 1: // Create New Outing
                        AddOuting();
                        break;
                    case 2: // Veiw All Outings
                        DisplayListOfOutings();
                        break;
                    case 3: //Cost
                        DisplayCostOfOutingsByType();
                        Console.ReadLine();
                        break;
                    case 4: // Exit
                        isRunning = false;
                        Console.WriteLine("Thank you for using Komodo Accounting.");
                        Console.ReadLine();
                        break;
                    default: // Default
                        Console.WriteLine($"Im Sorry {intput} is not a valid response");
                        Console.ReadLine();
                        break;

                }
            }
        }
        public void AddOuting()
        {
            Console.Clear();
            Outings newOuting = new Outings();
            Console.WriteLine("What type of Outing was Taken?" +
                "\n1. MiniGolf" +
                "\n2. Arcade" +
                "\n3. GoKarting" +
                "\n4. Boating");

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    newOuting.OutingType = OutingType.MiniGolf;
                    break;
                case 2:
                    newOuting.OutingType = OutingType.Arcade;
                    break;
                case 3:
                    newOuting.OutingType = OutingType.GoKarting;
                    break;
                case 4:
                    newOuting.OutingType = OutingType.Boating;
                    break;
                default:
                    Console.WriteLine($"Invalid Respose, {input} is not an option.");
                    Console.ReadLine();
                    break;
            }

            Console.WriteLine("\nHow many people attended this outing?");
            newOuting.TotalPeople = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat Date did the outing occur? Please use the format YYYY/MM/DD");
            newOuting.Date = DateTime.Parse(Console.ReadLine()).Date;

            Console.WriteLine("\nWhat was the cost, per person, to attend? Please Do not Use a '$' ");
            newOuting.CostPerPerson = decimal.Parse(Console.ReadLine());

            newOuting.TotalCost = GetTotalCostForIndvOuting(newOuting.TotalPeople, newOuting.CostPerPerson);

            _outingRepo.AddOutingsToList(newOuting);
        }

        public decimal GetTotalCostForIndvOuting(decimal TotalPeople, decimal CostPerPerson)
        {
            return TotalPeople * CostPerPerson;
        }
        public void DisplayListOfOutings()
        {
            Console.Clear();
            List<Outings> outingList = _outingRepo.GetOutingList();
            foreach(Outings outing in outingList)
            {
                Console.WriteLine($"\n Outing Type:\t{(OutingType)outing.OutingType}" +
                    $"\n Total People Attended:\t{outing.TotalPeople}" +
                    $"\n Date:\t{outing.Date.ToShortDateString()}" +
                    $"\n Total Cost:\t{outing.TotalCost}");
            }
            Console.ReadLine();
        }
        public void DisplayCostOfOutingsByType()
        {
            List<Outings> outingList = _outingRepo.GetOutingList();
            Console.WriteLine("What type of Outing would you like to check the total cost of?" +
                "\n1. MiniGolf" +
                "\n2. Arcade" +
                "\n3. GoKarting" +
                "\n4. Boating" +
                "\n5. View Total Cost Of All Outings");

            int inputA = int.Parse(Console.ReadLine());
            switch (inputA)
            {
                case 1:
                    var miniGolf = 0m;
                    foreach (var outing in outingList)
                    {
                        if (outing.OutingType == OutingType.MiniGolf)
                            miniGolf += outing.TotalCost;
                    }
                    Console.WriteLine($"MiniGolf: ${miniGolf}");
                    break;
                case 2:
                    var arcade = 0m;
                    foreach (var outing in outingList)
                    {
                        if (outing.OutingType == OutingType.Arcade)
                            arcade += outing.TotalCost;
                    }
                    Console.WriteLine($"Arcades: ${arcade}");
                    break;
                case 3:
                    var goKarting = 0m;
                    foreach (var outing in outingList)
                    {
                        if (outing.OutingType == OutingType.GoKarting)
                            goKarting += outing.TotalCost;
                    }
                    Console.WriteLine($"GoKarting: ${goKarting}");
                    break;
                case 4:
                    var boating = 0m;
                    foreach (var outing in outingList)
                    {
                        if (outing.OutingType == OutingType.Boating)
                            boating += outing.TotalCost;
                    }
                    Console.WriteLine($"MiniGolf: ${boating}");
                    break;
                case 5:
                    var totalCostOfAllOutings = 0m;
                    foreach (var outing in outingList)
                    {
                        totalCostOfAllOutings += outing.TotalCost;
                    }
                    Console.WriteLine($"Total: ${totalCostOfAllOutings}");
                    break;
            }
        }

    }
}
