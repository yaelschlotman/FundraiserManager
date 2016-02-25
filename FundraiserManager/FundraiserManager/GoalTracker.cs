using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager
{
    public static class GoalTracker
    {
        public static decimal SetIndividualGoalAmount(decimal GroupGoalAmount, int NumberInGroup)
        { 
            decimal IndividualGoalAmount = GroupGoalAmount / NumberInGroup;
            return IndividualGoalAmount;
        }

        

        public static void TrackProgressToGoal(decimal GoalAmount,
                                                decimal AmountSold,
                                                decimal Overage,
                                                decimal Shortfall,
                                                bool IsGoalAchieved)
        {
            if (AmountSold >= GoalAmount)
            {
                Overage = AmountSold - GoalAmount;
                Shortfall = 0;
                IsGoalAchieved = true;
            }

            else if (AmountSold < GoalAmount)
            {
                Overage = 0;
                Shortfall = GoalAmount - AmountSold;
                IsGoalAchieved = false;
            }

        }
    }





}


