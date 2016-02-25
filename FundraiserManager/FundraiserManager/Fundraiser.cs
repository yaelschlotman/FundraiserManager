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
                newFundraiser.EstablishGroupGoalAmount();
                newFundraiser.EstablishNumberOfParticipants();
            }
            else if (UserData.ToLower() == "n")
            {
                
            }
        }

        

        
    }
}
