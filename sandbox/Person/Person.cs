class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        SetAge(age);
        _weight = weight;
    }

    public string GetPersonInformation()
    {
        return $"Name: {_firstName} {_lastName}, age: {_age}, weight: {_weight}";
    }

    public void ChangeWeight(int update)
    {
        SetWeight(_weight += update);
    }

    public void SetAge(int age)
    {
        _age = age;
        if (age < 0 || age > 115)
        {
            _age = 0;
            Console.WriteLine("Incorrect age");
        }
    }

    public void SetWeight(int weight)
    {
        _weight = weight;
        if (weight < 0 || weight > 500)
        {
            weight = 0;
            Console.WriteLine("Incorrect weight");
        }
    }
}