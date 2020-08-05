using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            DataBaseFirstEntities1 dataBase = new DataBaseFirstEntities1();

            Console.WriteLine($" Route / Depature for {dataBase.Airports.Find(dataBase.Routes.Find(1).DestinationAirportID).IATA} Owned by {dataBase.FlightCompanies.Find(dataBase.Routes.Find(1).RouteOwnerID).Name} Operated by {dataBase.FlightCompanies.Find(dataBase.Routes.Find(1).RouteUserID).Name}");
            // Route too --> Airport IATA --> owned by Airport FlightCompany --> Operated by FlightCompany

            Console.ReadKey();


        }
    }
}

