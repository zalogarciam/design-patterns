class User
{
    public string Name { get; set; }

    public User(string name)
    {
        Name = name;
    }

    public void SayHello()
    {
        Console.WriteLine("Hello " + Name);
    }
}