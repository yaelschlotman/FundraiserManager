using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager
{
    class OngoingUserData
    {
        public void BringUpFundraiserData()
        {
            string FundraiserName;
            Console.WriteLine("Enter fundraiser name:");
            FundraiserName = Console.ReadLine();
            Console.WriteLine("Fundraiser Name:  " + FundraiserName);
            Console.ReadKey();
            //bring up txt file for fundraiser name
        }
    }
}
