using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ClaimsRepository
    {
        Queue<Claims> _queueOfClaims = new Queue<Claims>();

        int claimNumber = 0;
        public void AddNewClaim(ClaimType claimType, string description, decimal claimAmmount, DateTime accidentDate, DateTime claimDate)
        {
            claimNumber = ++ ;

            bool isValid = false;
            if (((accidentDate - claimDate).TotalDays) < 30)
                isValid = true;

            Claims claim = new Claims(claimNumber, claimType, description, claimAmmount, accidentDate, claimDate, isValid);
            _queueOfClaims.Enqueue(claim);
        }
        public Queue<Claims> GetClaims()
        {
            return _queueOfClaims;
        }
    }
}
