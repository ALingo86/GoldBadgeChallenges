using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Komodo_Claims
{
    public class Claims
    {

        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string ClaimDescription { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public TimeSpan IncidentToClaim { get; }
        public bool IsValid { get; set; }

        public Claims() { }

        public Claims
            (
            int claimID,
            string claimType,
            string claimDescription,
            double claimAmount,
            DateTime dateOfIncident,
            DateTime dateOfClaim,
            bool isValid
            )
        {
            ClaimID = claimID;
            ClaimType = claimType;
            ClaimDescription = claimDescription;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;

        }


        public override string ToString()
        {
            return $"{ClaimID}\n" +
                $"{ClaimType}\n" +
                $"{ClaimDescription}\n" +
                $"{ClaimAmount}\n" +
                $"{DateOfClaim}\n" +
                $"{DateOfIncident}\n" +
                $"{IsValid}";
        }




    }


}
