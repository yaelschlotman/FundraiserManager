using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager
{
    class NewUserData
    {
        FileWriter fileWriter = new FileWriter();
        string FundraiserName;
        public void CreateFundraiserFile()
        {
            Console.WriteLine("Enter Fundraiser Name:");
            FundraiserName = Console.ReadLine();
            Console.WriteLine("Fundraiser Name:  " + FundraiserName);
            Console.ReadKey();
            fileWriter.AddRecordToFile(FundraiserName, "Fundraiser" + FundraiserName);

            
            
            //create txt file with Console.ReadLine
        }
    }
}
