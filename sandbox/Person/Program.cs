class Program
{
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
    }
}