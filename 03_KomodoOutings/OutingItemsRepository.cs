using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _03_KomodoOutings.OutingItems;

namespace _03_KomodoOutings
{
    public class OutingItemsRepository
    {
        protected readonly List<Outings> _outings = new List<Outings>();

        public List<Outings> GetAllOutings()
        {
            return _outings;
        }

        public void AddNewOuting(Outings outings)
        {
            _outings.Add(outings);
        }

        public decimal CostOfAllOutings()
        {
            decimal totalCost = 0;
            foreach (Outings outing in _outings)
            {
                totalCost += outing.CostOfEvent;
            }
            return totalCost;

            //return _outings.Sum(o => o.CostOfEvent);
        }

        public List<Outings> GetAllOutingsByType(string eventType)
        {
            List<Outings> listByType = new List<Outings>();

            foreach (Outings outing in _outings)
            {
                if (outing.EventType.ToString() == eventType)
                {
                    listByType.Add(outing);
                }

            }
            return listByType;

        }
        public decimal CostOfOutingsByType(string eventType)
        {
            decimal totalCost = 0;

            foreach (Outings outing in _outings)
            {
                if (outing.EventType.ToString() == eventType)
                {



                    totalCost += outing.CostOfEvent;


                }


            }
            return totalCost;


        }

    }
}
