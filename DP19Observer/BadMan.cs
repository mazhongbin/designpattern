namespace DP19Observer
{
    public class BadMan:Subject
    {
        public string CurrentLocation { get; set; }

        public void RunWay(string Location)
        {
            CurrentLocation = Location;
            base.Notify();
        }

        public override string ToString()
        {
            return $"Bad Man run away to {CurrentLocation}";
        }
    }
}
