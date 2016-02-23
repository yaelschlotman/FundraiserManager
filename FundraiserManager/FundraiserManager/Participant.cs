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
        string Phone;
        decimal IndividualGoal;
        decimal AmountRaised;
        decimal Overage;
        decimal Shortfall;
        bool GoalAchieved;

        public Participant(string firstName, 
                            string lastName,
                            string phone,
                            decimal individualGoal,
                            decimal amountRaised,
                            decimal overage,
                            decimal shortfall,
                            bool goalAchieved)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            IndividualGoal = individualGoal;
            AmountRaised = amountRaised;
            Overage = overage;
            Shortfall = shortfall;
            GoalAchieved = goalAchieved;

        }

        public Participant CreateParticipantRecord(string firstName,
                                                    string lastName,
                                                    string phone,
                                                    decimal individualGoal,
                                                    decimal amountRaised,
                                                    decimal overage,
                                                    decimal shortfall,
                                                    bool goalAchieved)
        {
            return (new Participant(firstName, lastName, phone, individualGoal,
                                    amountRaised, overage, shortfall, goalAchieved));

        }


    }
}
