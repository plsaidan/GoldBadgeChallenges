using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class OutingsRepository
    {
        List<Outings> _listOfOutings = new List<Outings>();

        public void AddOutingsToList(Outings outing)
        {
            _listOfOutings.Add(outing);
        }
        public List<Outings> GetOutingList()
        {
            return _listOfOutings;
        }
    }
}
