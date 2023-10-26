public class Teacher : Person, Talkable
{
    private int age;

    public Teacher(int age, string name)
    {
        Name = name;
        Age = age;
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Talk()
    {
        return "Don't forget to do your work or you will Fail!!!!!!";
    }
}