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
        
          
        string FundraiserName;
        decimal GroupGoalAmount;
        int NumberOfParticipants;


        public void CreateNewFundraiser()
        {
            newUserData.GetUserData("What is the name of your fundraiser?");
            FundraiserName = Console.ReadLine();
            Console.WriteLine("Fundraiser Name:  " + FundraiserName);
            Console.ReadKey();
            fileWriter.AddRecordToFile(FundraiserName, FundraiserName);
        }

        public void EstablishGroupGoalAmount()
        {
            newUserData.GetUserData("What is your fundraiser goal amount to raise?");
            //GroupGoalAmount = Console.ReadLine();
            Console.WriteLine("Group Goal Amount:  " + GroupGoalAmount);
            Console.ReadKey();
            //fileWriter.AddRecordToFile(FundraiserName, GroupGoalAmount);

        }

        public void EstablishNumberOfParticipant()
        {
            newUserData.GetUserData("How many participants in your fundraiser?");
           // NumberOfParticipants = Console.ReadLine();
            Console.WriteLine("Number of Participants:  " + NumberOfParticipants);
            Console.ReadKey();
            //fileWriter.AddRecordToFile(FundraiserName, NumberOfParticipants);
        }


        

    }
}
