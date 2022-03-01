using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharpHowToProgram.ChapterFour
{
    internal class Coaching
    {
        
        // Come back here to convert string to date time for the Coach Timings
        // come back here to change into what sensei told to change. (needs more improvement)
        private int _playerCount;
        private decimal _courseCharge;
        
        public string CoachType { get; set; }
        public string ClassTimings { get; set; }

        public int PlayerCount
        {
            get => _playerCount;
            set
            {
                if (value > 0)
                {
                    _playerCount = value;
                }
            }
        }
        public decimal CourseCharge
        {
            get => _courseCharge;
            set
            {
                if (value > 0.0m)
                {
                    _courseCharge = value;
                }
                {
                    
                }
            }
        }


        public Coaching(int playerCount, decimal courseCharge, string classTimings, string coachType)
        {
            PlayerCount = playerCount;
            CourseCharge = courseCharge;
            ClassTimings = classTimings;
            CoachType = coachType;
        }
    }
}
