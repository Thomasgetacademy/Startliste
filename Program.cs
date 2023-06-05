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
                var newRegistration = new Registration(
                    lineField[0],
                    lineField[1],
                    lineField[2],
                    lineField[3],
                    lineField[4],
                    lineField[5]
                    );

                registrationList.Add(newRegistration);

                var searchClubs = FindClub(clubList, lineField[2]);

                if (searchClubs == null)
                {
                    clubList.Add(new Club(lineField[2]));
                    FindClub(clubList, lineField[2]).AddClubRegistration(newRegistration);
                }
                else
                {
                    searchClubs.AddClubRegistration(newRegistration);
                }
            }

            foreach (var club in clubList)
            {
                FindClub(clubList, club.Name).PrintClubNameAndMembers();
            }
        }

        private static Club? FindClub(List<Club> clubList, string lineField)
        {
            return clubList.FirstOrDefault(club => club.Name == lineField);
        }
    }
}