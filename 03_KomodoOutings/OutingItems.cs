using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoOutings
{
    public class OutingItems
    {
        public class Outings
            {
            public string EventType { get; set; }
            public int NumberOfPeople { get; set; }
            public DateTime DateOfEvent { get; set; }
            public decimal CostPerPerson 
            {
                get 
                {
                    var cost = CostOfEvent / NumberOfPeople;
                    return Math.Round(cost,2);
                } 
            }
            public decimal CostOfEvent { get; set; }
            //public Outings CostOfEvents { get; }

            public Outings() { }
            public Outings
                (
                string eventType,
                int numberOfPeople,
                DateTime dateOfEvent,
                //decimal costPerPerson,
                decimal costOfEvent
                )
            {
                EventType = eventType;
                NumberOfPeople = numberOfPeople;
                DateOfEvent = dateOfEvent;
                //CostPerPerson = costPerPerson;
                CostOfEvent = costOfEvent;

            }

            public override string ToString()
            {
                return $"{EventType}\n,{NumberOfPeople}\n,{DateOfEvent}\n,{CostOfEvent:C2}\n,{CostPerPerson:C2}\n";
            }

            //public Outings(Outings costOfEvents)
            //{
            //    CostOfEvents = costOfEvents;
            //}
        }

    }
}
