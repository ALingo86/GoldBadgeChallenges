using _02_Komodo_Claims;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims
{
    public class ClaimItemRepository
    {
        protected readonly Queue<Claims> cQ = new Queue<Claims>();

        public Queue<Claims> GetAllClaims()
        {
            return cQ;
        }

        public void AddClaim(Claims claim)
        {
            cQ.Enqueue(claim);
        }
        public void RemoveClaim()
        {
            cQ.Dequeue();
        }

        public Claims PeekNextInQueue()
        {
            return cQ.Peek();
            
        }
    }
}
