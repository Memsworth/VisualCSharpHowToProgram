using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterSeven
{
    internal class Customer
    {
        public double TravelDistance { get; set; }
        public int WaitTime { get; set; }
        public decimal Cost { get; set; }
        
        public Customer(double travelDistance, int waitTime)
        {
            TravelDistance = travelDistance;
            WaitTime = waitTime;
        }
  
    }
}
