using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager
{
    public class NewFundraiser
    {
        //What is the name of your fundraising goal? --> FundraiserName
        //How much do need to raise with this fundraiser? GroupGoalAmount
        //How many participants are in your group? --> call goal tracker, calc. ind. goal, return amount.  
        //      Call CreateNewParticipant and pass this value into param for indGoalAmt.
        //Call particpant list.  Add each new participant to list as it is entered. 

        NewUserData newUserData = new NewUserData();
        FileWriter fileWriter = new FileWriter();

        string UserAnswer; 
        string FundraiserName;
        decimal GroupGoalAmount;
        int NumberOfParticipants;


        public void CreateNewFundraiser()
        {
            
            FundraiserName = newUserData.GetUserInputAsString("What is the name of your fundraiser?");
            Console.WriteLine("Fundraiser Name:  " + FundraiserName);
            fileWriter.AddRecordToFile(FundraiserName, FundraiserName);
        }

        public void EstablishGroupGoalAmount()
        {
            
            GroupGoalAmount = newUserData.GetUserInputAsDecimal("What is your fundraiser goal amount to raise?");
            Console.WriteLine("Group Goal Amount:  " + GroupGoalAmount);
            
            //fileWriter.AddRecordToFile(FundraiserName, **convert decimal to string?  or is there a way to write as decimal?);

        }

        public void EstablishNumberOfParticipants()
        {            
            NumberOfParticipants = newUserData.GetUserInputAsInt("How many participants in your fundraiser?");
            Console.WriteLine("Number of Participants:  " + NumberOfParticipants);
            
            //fileWriter.AddRecordToFile(FundraiserName, NumberOfParticipants);
        }


        

    }
}
