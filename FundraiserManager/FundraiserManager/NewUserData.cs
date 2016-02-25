using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager
{
    public class NewUserData
    {
        FileWriter fileWriter = new FileWriter();
        string UserData;
        float UserDataFloat;
        decimal UserDataDecimal;
        int UserDataInt;
       

        //get user data as string
        //get user data as string, convert to decimal.  Look this up.
        //Write to the file all info as it is entered.


        public void GetUserData(string UserDataNeeded)
        {
            Console.WriteLine(UserDataNeeded);
            UserData = Console.ReadLine();
        }

        public void ConvertUserInputStringToDecimal(string UserDataNeeded)
        {
            Console.WriteLine(UserDataNeeded);
            UserData = Console.ReadLine();
            UserDataDecimal = Convert.ToDecimal(UserData);
        }

        public void ConvertUserInputStringToFloat(string UserDataNeeded)
        {
            Console.WriteLine(UserDataNeeded);
            UserData = Console.ReadLine();
            UserDataFloat = Convert.ToSingle(UserData);
            Console.WriteLine(UserDataFloat + UserDataFloat);
            Console.ReadKey();
            //get user data as string
            //get user data as string, convert to .  Look this up.
            //Write to the file all info as it is entered.
        }

        public void ConverUserInputStringToInt(string UserDataNeeded)
        {
            Console.WriteLine(UserDataNeeded);
            UserData = Console.ReadLine();
            UserDataInt = Convert.ToInt32(UserData);
            Console.WriteLine(UserDataInt + UserDataInt);
            Console.ReadKey();
        }
    }



}
