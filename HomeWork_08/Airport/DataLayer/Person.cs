namespace Airport
{
    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string passport { get; set; }
        public string birthday { get; set; }
        public object[] visa { get; set; }
        public ushort baggageWeight { get; set; }
        public bool prohibitedItems { get; set; }
        public bool haveTicket { get; set; }
    }
}