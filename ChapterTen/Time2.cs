namespace VisualCSharpHowToProgram.ChapterTen;
internal class Time2
    {
        private int hour;
        private int minute;
        private int second;

        public Time2(int hour=0, int minute=0, int second=0)
        {
            Hour = hour;
            Min = minute;
            Sec = second;
        }

        public Time2(Time2 time) : this(time.Hour, time.Min, time.Sec) { }
        public int Hour
        {
            get => this.hour;
            private set
            {
                if(value < 0 || value>23)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Hour)} must be 0-23");
                }
                else
                {
                    this.hour = value;
                }
            }
        }

        public int Min
        {
            get => this.minute;
            private set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Min)} must be 0-59");
                }
                else
                {
                    this.minute = value;
                }
            }
        }
        public int Sec
        {
            get => this.second;
            private set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Sec)} must be 0-59");
                }
                else
                {
                    this.second = value;
                }
            }
        }
        
        public string ToUni() =>
            $"{Hour:D2}:{this.minute:D2}:{second:D2}";

        public override string ToString() =>
            $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
            $"{this.minute:D2}:{this.second:D2} {(Hour < 12 ? "AM" : "PM")}";
    }
