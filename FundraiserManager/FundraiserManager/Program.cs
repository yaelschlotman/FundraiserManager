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

            newUserData.ConvertUserInputStringToFloat("How many people in your fundraiser?");

        }
    }
}
