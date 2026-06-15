class Program
{

    public static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());
    }

    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Roberts", 57, 198);
        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPoliceMan = new Police( "Gun", "Jonny", "Rich", 43, 187);

        Console.WriteLine(myPoliceMan.GetPersonInformation());

        Doctor myDoctor = new Doctor("PhD", "John", "Billy", 44, 200);

        Console.WriteLine(myDoctor.GetPersonInformation());
        myDoctor.ChangeWeight(10);
        myPoliceMan.ChangeWeight(-11);

        Console.WriteLine(myDoctor.GetPersonInformation());
        Console.WriteLine(myPoliceMan.GetPersonInformation());


        List<Person> myPeople = new List<Person>();
        myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceMan);

        foreach(Person person in myPeople)
        {
            // Console.WriteLine(person.GetPersonInformation());
            DisplayPersonInformation(person);
        }
    }
}