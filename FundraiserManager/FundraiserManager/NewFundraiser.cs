using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager
{
    public  class NewFundraiser
    {
        NewUserData newUserData = new NewUserData();
        FileWriter fileWriter = new FileWriter();

        public void CreateNewFundraiser()
        {
            newUserData.CreateFundraiserFile();


        }
        

    }
}
