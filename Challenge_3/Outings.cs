using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{

    public enum OutingType { MiniGolf = 1, Arcade, GoKarting, Boating }

    public class Outings
    {
        public OutingType OutingType { get; set; }
        public decimal TotalPeople { get; set; }
        public DateTime Date { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalCost { get; set; }

        public Outings(OutingType outingType, decimal totalPeople, DateTime date, decimal costPerPerson, decimal totalCost)
        {
            OutingType = outingType;
            TotalPeople = totalPeople;
            Date = date;
            CostPerPerson = costPerPerson;
            TotalCost = totalCost;

        }
        public Outings()
        {
                
        }
    }
}
