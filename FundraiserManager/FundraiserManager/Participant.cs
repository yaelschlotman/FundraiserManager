using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager
{
    public class Participant
    {
        string FirstName;
        string LastName;
        decimal IndividualGoal;
        decimal IndividualAmountRaised;
        decimal IndividualOverage;
        decimal IndividualShortfall;
        bool IsIndividualGoalAchieved;
        Participant NewParticipantRecord;

        public Participant CreateNewParticipantRecord(string firstName, string lastName, decimal individualGoal, decimal individualAmountRaised,
                            decimal individualOverage, decimal individualShortfall, bool isIndividualGoalAchieved)
        {
            firstName = GetFirstName();
            lastName = GetLastName();
            individualGoal = GetIndividualGoal();
            individualAmountRaised = GetIndividualAmountRaised();
            individualOverage = GetIndividualOverage();
            isIndividualGoalAchieved = GetIsIndividualGoalAchieved();
            Console.WriteLine(firstName + " " + lastName + ",");
            Console.WriteLine("Individual Goal: " + "$" + individualGoal);
            Console.WriteLine("Individual Amount Raised: " + "$" + individualAmountRaised);
            Console.WriteLine("Individual Overage: " + "$" + individualOverage);
            Console.WriteLine("Individual Shortfall: " + "$" + individualShortfall);
            Console.WriteLine("Individual Goal Achieved: No");

            return NewParticipantRecord;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public decimal GetIndividualGoal()
        {
            return IndividualGoal;
        }

        public decimal GetIndividualAmountRaised()
        {
            return IndividualAmountRaised;
        }

        public decimal GetIndividualOverage()
        {
            return IndividualOverage;
        }
        public decimal GetIndividualShortfall()
        {
            return IndividualShortfall;
        }
        public bool GetIsIndividualGoalAchieved()
        {
            return IsIndividualGoalAchieved;
        }


    }
}
