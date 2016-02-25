using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager
{
    class Program
    {
        static void Main(string[] args)
        {
            NewUserData newUserData = new NewUserData();
            float testX = newUserData.GetUserInputAsFloat("What's the number?");
            Console.WriteLine(testX + testX);
            Console.ReadKey();


        }
    }
}
