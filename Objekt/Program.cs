using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekt
{
    class Program
    {
        static void Main(string[] args)
        {
            var belegpositionen = new List<BelegPosition>();
            var belegposition = new BelegPosition();
            belegposition.Artikelnummer = "1234567";
            belegposition.AuspraegungID = 24742842;
            belegposition.Matchcode = "ehehhq00";
            belegpositionen.Add(belegposition);
            foreach (var item in belegpositionen)
            {
                Console.WriteLine(item.Artikelnummer);
                Console.WriteLine(item.AuspraegungID);
                Console.WriteLine(item.Matchcode);
                Console.ReadKey();
            }

        }

    }

    public class BelegPosition
    {
        public string Artikelnummer { get; set; }
        public int AuspraegungID { get; set; }
        public string Matchcode { get; set; }
    }
}
          
        
