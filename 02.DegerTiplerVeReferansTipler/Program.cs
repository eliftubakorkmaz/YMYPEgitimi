Console.WriteLine("Hello, World!");

string name = "Elif";
string name2 = name;
name2 = "Tuba";

Console.WriteLine(name);
Console.WriteLine(name2); // deger tip örneği

User user = new();
User user2 = user;
user2.Name = "Tuba";

Console.WriteLine(user.Name);

class User
{
    public string Name = "Elif";
}