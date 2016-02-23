using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager
{
    public class Fundraiser
    {
        string UserData;
        NewFundraiser newFundraiser = new NewFundraiser();
        OngoingFundraiser ongoingFundraiser = new OngoingFundraiser();


        public void InitializeFundraiser()
        {        
            Console.WriteLine("Is this a new fundraiser? Enter Y or N");
            UserData = Console.ReadLine();

            if (UserData.ToLower() == "y")
            {
                newFundraiser.CreateNewFundraiser();
            }
            else if (UserData.ToLower() == "n")
            {
                Console.WriteLine("Cannot find file.  Try again.");
            }
        }

        /*public Participant CreateParticipantRecord(string firstName,
                               string lastName,
                               string phone,
                               decimal individualGoal,
                               decimal amountRaised,
                               decimal overage,
                               decimal shortfall,
                               bool goalAchieved)
        {
            
            return (new Participant(firstName, lastName, phone, individualGoal, amountRaised, overage, shortfall, goalAchieved));
        }

        public List<Participant> CreateParticipatList()
        {

            List<Participant> participants = new List<Participant>();

            return participants;
        }*/
    }
}
