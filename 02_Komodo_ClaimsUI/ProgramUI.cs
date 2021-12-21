using _02_Komodo_Claims;
using Komodo_Claims;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Komodo_ClaimsUI
{
    public class ProgramUI
    {
        private readonly ClaimItemRepository _claims = new ClaimItemRepository();
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
                Console.WriteLine("Welcome to the Main Menu\n" +
                    "Please choose a menu item:\n" +
                    "1.See all claims\n" +
                    "2.Take care of the next claim\n" +
                    "3.Enter a new claim");
                string userinput = Console.ReadLine();
                switch (userinput)
                {

                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        SeeNextClaim();
                        break;
                    case "3":
                        InputNewClaim();
                        break;
                    default:
                        Console.WriteLine("Please input a valid selection.");
                        Console.ReadKey();
                        return;
                }

            }
        }

        private void SeeAllClaims()
        {
            Console.Clear();
            var claims = _claims.GetAllClaims();
            foreach (var claim in claims)
            {
                Console.WriteLine(claim.ToString());
            }
            Console.ReadKey();

        }

        
        private void SeeNextClaim()
        {
            Console.Clear();
            //Console.WriteLine
            //($"{claims.GetType().Name}\n" +
            //$"ClaimID: {claims.ClaimID}\n" +
            //$"ClaimType: {claims.ClaimType}\n" +
            //$"Claim Description: {claims.ClaimDescription}\n" +
            // $"Claim Amount: ${claims.ClaimAmount}\n" +
            //$"Claim Date of Incident: {claims.DateOfIncident}\n" +
            //$"Claim Date of Claim: {claims.DateOfClaim}\n" +
            //$"valid? {claims.IsValid}\n" +
            //$"=========================\n" +
            Console.WriteLine($"Here is the next case:   {SeeNextInQueue()}");
            Console.WriteLine( $"Did you want to work on this claim now? (y/n)");
            if (Console.ReadLine() == "y")
            {

                _claims.RemoveClaim();

            }
            else { return; }
                

        }

        private object SeeNextInQueue()

        {
            return _claims.PeekNextInQueue();
        }

        private void InputNewClaim()
        {
            Console.Clear();
            Claims newClaim = new Claims();
            Console.WriteLine("Please enter the claim ID:");
            int newClaimID=Convert.ToInt32(Console.ReadLine());
            newClaim.ClaimID = newClaimID;

            Console.WriteLine("Please enter the claim type: ");
            string newClaimType=Console.ReadLine();
            newClaim.ClaimType = newClaimType;

            Console.WriteLine("Please enter the claim description:");
            string newClaimDescription=Console.ReadLine();
            newClaim.ClaimDescription = newClaimDescription;

            Console.WriteLine("Please enter the damage amount:");
            double newClaimAmount=Convert.ToDouble(Console.ReadLine());
            newClaim.ClaimAmount = newClaimAmount;

            Console.WriteLine("Please input the date of the accident:\n" +
                "(Year Month Day");
            DateTime newAccidentDate=Convert.ToDateTime(Console.ReadLine());
            newClaim.DateOfIncident = newAccidentDate;

            Console.WriteLine("Please input the date the claim was reported: \n" +
                "(Year Month Day)");
            DateTime newClaimDate=Convert.ToDateTime(Console.ReadLine());
            newClaim.DateOfClaim=newClaimDate;

            Console.WriteLine("Is the date of the claim within 30 days of the accident? (y/n)");
            if (Console.ReadLine()=="y")
            {
                newClaim.IsValid = true;
            }
            else
            {
                newClaim.IsValid = false;   
            }
            _claims.AddClaim(newClaim);
            Console.WriteLine("Claim entered successfully.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();





        }

        //static public void Class()
        //{
            //Queue cQ = new Queue();
            //cQ.Enqueue(1);
            //foreach (var ele in cQ)
            //{
            //    Console.WriteLine(ele);
            //}
        //}
        private void SeedContent()
        {
            Claims firstclaim = new Claims();
            firstclaim.ClaimID = 1;
            firstclaim.ClaimType = "Car";
            firstclaim.ClaimDescription = "Car accident on 465.";
            firstclaim.ClaimAmount = 400.00;
            firstclaim.DateOfIncident = new DateTime(2018, 4, 25);
            firstclaim.DateOfClaim = new DateTime(2018, 4, 27);
            firstclaim.IsValid = true;
            _claims.AddClaim(firstclaim);

            Claims secondclaim = new Claims();
            secondclaim.ClaimID = 2;
            secondclaim.ClaimType = "Home";
            secondclaim.ClaimDescription = "House fire in kitchen";
            secondclaim.ClaimAmount = 4000.00;
            secondclaim.DateOfIncident = new DateTime(2018, 4, 11);
            secondclaim.DateOfClaim = new DateTime(2018, 4, 12);
            secondclaim.IsValid = true;
            _claims.AddClaim(secondclaim);
        }
        


    }
}
