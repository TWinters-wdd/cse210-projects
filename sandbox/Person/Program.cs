class Program
{

    public static void DisplayPersonInformation(Person person)
    {
        if (person is Doctor doctor)
            Console.WriteLine(doctor.GetDoctorInformation());
        else if (person is Police police)
            Console.WriteLine(police.GetPoliceManInformation());
        else
            Console.WriteLine(person.GetPersonInformation());
    }

    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Roberts", 57, 198);
        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPoliceMan = new Police( "Gun", "Jonny", "Rich", 43, 187);

        Console.WriteLine(myPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("PhD", "John", "Billy", 44, 200);

        Console.WriteLine(myDoctor.GetDoctorInformation());
        myDoctor.ChangeWeight(10);
        myPoliceMan.ChangeWeight(-11);

        Console.WriteLine(myDoctor.GetDoctorInformation());
        Console.WriteLine(myPoliceMan.GetPoliceManInformation());


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