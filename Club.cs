namespace Startliste;

public class Club
{
    public string Name { get; }
    public List<Registration> Members { get; }

    public Club(string name)
    {
        Name = name;
        Members = new List<Registration>();
    }

    public void AddClubRegistration(Registration person)
    {
        Members.Add(person);
    }

    public void PrintClubNameAndMembers()
    {
        Console.WriteLine($"Name: {Name} - Members: {Members.Count}");
        var processedClasses = new List<string>();

        foreach (var member in Members)
        {
            if (!processedClasses.Contains(member._class))
            {
                var membersWithSameClass = Members.FindAll(m => m._class == member._class);
                int memberCount = membersWithSameClass.Count();

                Console.WriteLine($"{member._class}: {memberCount} members");

                processedClasses.Add(member._class);
            }
        }
    }
}