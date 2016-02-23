using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager
{
    public class Product
    {
        public Product(decimal Cost, decimal Price, decimal ProfitPerItem)
        {
            ProfitPerItem = Price - Cost;
        }
    }
}
