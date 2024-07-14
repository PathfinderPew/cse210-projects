class Program
{
    static void Main(string[] args)
    {
        Wedding wedding = new Wedding("Smith-Jones Wedding", "2024-08-20", "John Smith & Jane Jones");
        Conference conference = new Conference("Tech Conference 2024", "2024-09-15", "Dr. Alice Johnson");
        Concert concert = new Concert("Summer Fest", "2024-07-30", "The Rockers");

        wedding.DisplayEventDetails();
        conference.DisplayEventDetails();
        concert.DisplayEventDetails();
    }
}
