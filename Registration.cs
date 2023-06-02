using System.Xml.Linq;

namespace Startliste;

public class Registration
{
    public List<Registration> _list;
    public Registration()
    {
        _list = new List<Registration>();
    }
    public string _startNumber { get; }
    public string _name { get; }
    public string _club { get; }
    public string _nationality { get; }
    public string _group { get; }
    public string _class { get; }
    public Registration(string startNumber, string name, string club, string nationality, string group, string classParameter)
    {
        _startNumber = startNumber;
        _name = name;
        _club = club;
        _nationality = nationality;
        _group = group;
        _class = classParameter;
    }
    public void AddToList(Registration listObject)
    {
        _list.Add(listObject);
    }

    public void ShowList()
    {
        foreach (var listObject in _list)
        {
            Console.WriteLine(listObject._name);
        }
    }

    //public void SetName()
    //{

    //}
    //public void SetClub()
    //{

    //}
    //public void SetNationality()
    //{

    //}
    //public void SetGroup()
    //{

    //}
    //public void SetClass()
    //{
    //}
}