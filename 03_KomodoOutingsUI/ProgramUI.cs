using _03_KomodoOutings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _03_KomodoOutings.OutingItems;

namespace _03_KomodoOutingsUI
{
    public class ProgramUI
    {
        private readonly OutingItemsRepository _outings = new OutingItemsRepository();

        public void Run()
        {
            SeedContent();
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine
                    (
                    "Welcome to the events tracker home menu!\n" +
                    "Please choose an option:\n" +
                    "1.Show a list of every outing\n" +
                    "2.Show the combined cost of every outing\n" +
                    "3.Show events by type\n" +
                    "4.Show outing costs by type"
                    );
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllOutings();
                        return;
                    case "2":
                        ShowCombinedCost();
                        return;
                    case "3":
                        ShowEventByType();
                        return;
                    case "4":
                        ShowCostByType();
                        return;
                    default:
                        Console.WriteLine("Please enter a valid selection");
                        Console.ReadLine();
                        break;






                }


            }
        }


        private void ShowAllOutings()
        {
            List<Outings> outings = _outings.GetAllOutings();
            foreach (Outings outing in outings)
            {
                DisplayOutingList(outing);
            }
            Console.Read();

        }

        private void DisplayOutingList(Outings outings)
        {
            Console.WriteLine
                (
                $"Type: {outings.EventType}\n" +
                $"Number of People: { outings.NumberOfPeople}\n " +
                $"Date of Event: {outings.DateOfEvent}\n" +
                $"Cost per person: {outings.CostPerPerson}\n" +
                $"Cost of the event: {outings.CostOfEvent}\n" +
                $"____________________________");
        }
        private void ShowCombinedCost()
        {
            Console.Clear();
            Console.WriteLine($"The combined cost is: {_outings.CostOfAllOutings()}");
            Console.ReadKey();
        }

        private void ShowEventByType()
        {
            Console.Clear();
            Console.WriteLine("Input an event type (Golf, Bowling, Amusement Park, Concert):");
            var input = Console.ReadLine();
            var outings = _outings.GetAllOutingsByType(input);
            foreach (var outing in outings)
            {
                Console.WriteLine(outing.ToString());
            }
            Console.ReadKey();
        }
        //{
        //    Console.Clear();
        //    Console.WriteLine("Input an event type (Golf, Bowling, Amusement Park, Concert):"); 
        //    if (Console.ReadLine() == "Golf")
            
        //    {
        //        //Console.WriteLine($"{_outings.GetType()}");
        //        return _outings.EventType.Equals("Golf");
        //    }
        //    if (Console.ReadLine() =="Bowling")
        //    {

        //    }
        //    if (Console.ReadLine() =="Amusement Park")
        //    {

        //    }
        //    if (Console.ReadLine() =="Concert")
        //    {

        //    }
        //    else
        //    {
        //        Console.WriteLine("Please input a valid selection.");
        //    }
        //}
        
        
        private void ShowCostByType()
        {
            Console.Clear();
            Console.WriteLine("Input an event type (Golf, Bowling, Amusement Park, Concert):");
            var input = Console.ReadLine();
            var outings = _outings.CostOfOutingsByType(input);
            Console.WriteLine($"Total Outing Cost: {outings}");
            Console.ReadKey();
        }

        private void SeedContent()
        {
            Outings one = new Outings();
            one.EventType = "Bowling";
            one.NumberOfPeople = 8;
            one.DateOfEvent = new DateTime(2020, 5, 20);
            one.CostOfEvent = 200;
            _outings.AddNewOuting(one);

            Outings two = new Outings();
            two.EventType = "Golf";
            two.NumberOfPeople = 6;
            two.DateOfEvent = new DateTime(2020, 5, 20);
            two.CostOfEvent = 300;
            _outings.AddNewOuting(two);

            Outings three = new Outings();
            three.EventType = "Golf";
            three.NumberOfPeople = 7;
            three.DateOfEvent = new DateTime(2020, 6, 30);
            three.CostOfEvent = 400;
            _outings.AddNewOuting(three);
        }
    }
}

    

   



            
            
            
        


