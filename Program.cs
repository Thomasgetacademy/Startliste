using System.Linq;

namespace Startliste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startlist = File.ReadAllLines("startlist.csv");

            int i = 0;
            var registrationList = new List<Registration>();
            var clubList = new List<Club>();
            foreach (var line in startlist)
            {
                var lineField = line.Split(",");
                var newRegistration = new Registration(lineField[0], lineField[1], lineField[2],
                    lineField[3], lineField[4], lineField[5]);

                registrationList.Add(newRegistration);

                if (!clubList.Contains(returnClub(clubList, lineField[2])))
                {

                }

                clubList.Add(new Club(lineField[2]));

            }

            foreach (var VARIABLE in registrationList)
            {
                Console.WriteLine($"{VARIABLE._startNumber} - {VARIABLE._name} - {VARIABLE._club}");
            }


        }
        public Club returnClub(Club clublist, string clubName)
        {
            return clublist.
        }
    }
}