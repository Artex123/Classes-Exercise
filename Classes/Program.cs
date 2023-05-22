using System.Threading.Channels;

namespace Classes
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            var myRide = new Car();
            myRide.Make = "Jeep";
            myRide.Model = "Wrangler";
            myRide.Year = 2004;
            myRide.FunRide();
        }

    }
}
