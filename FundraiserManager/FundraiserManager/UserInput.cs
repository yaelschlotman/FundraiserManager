using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager
{
    public  class UserInput
    {
        public  string FundraiserStatus; 

        public string InitializeFundraiser()
        {
            Console.WriteLine("Is this a new fundraiser?  Enter Y or N.");
            FundraiserStatus = Console.ReadLine();
            return FundraiserStatus;
        }
    }


}

