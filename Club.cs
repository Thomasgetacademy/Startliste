namespace Startliste;

public class Club
{
    public string Name { get; }
    public List<Registration> Registreringer { get; }

    public Club(string name)
    {
        Name = name;
    }

    public void AddClubRegistration()
    {

    }
}