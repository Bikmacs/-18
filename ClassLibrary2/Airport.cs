namespace ClassLibrary2
{
    public abstract class Airport
    {
        private int numerreys;
        private string punktn;
        private string type;
        private double time;

        public int Numerreys
        {
            get {return numerreys;}
            set { numerreys = value;}
        }
        public string Punktn
        {
            get { return punktn;}
            set { punktn = value;}
        }
        public string Type
        {
            get { return type;}
            set { type = value;}
        }
        public double Time
        {
            get { return time;}
            set { time = value;}
        }
    }
}
