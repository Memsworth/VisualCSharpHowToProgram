using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterSeven
{
    internal class CabDriver : HireCharge
    {

        private decimal _totalPay;

        public decimal TotalPay
        {
            get => _totalPay;
            set => _totalPay = value;
        }

        public void AddPay(decimal payAmount)
        {
            if(payAmount > 0.0m)
            {
                TotalPay += payAmount; 
            }
        }


        //This needs to be refactored
        public decimal FindCabFare(double distance, int waitTime)
        {
            decimal payFare = 0.0m;
            if(distance<=HireCharge.MinDistance)
            {
                payFare += HireCharge.MinFare;
            }
            else
            {
                decimal rateCharge = (Math.Ceiling((decimal)(distance - HireCharge.MinDistance)) * HireCharge.Rate);
                payFare = HireCharge.MinFare + rateCharge;
            }

            decimal waitingCharge = waitTime * HireCharge.WaitRate;
            payFare += waitingCharge;

            return payFare;
        }
    }
}
