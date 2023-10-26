public class Dog : Pet, Talkable
{
    private bool friendly;

    public Dog(bool friendly, string name)
    {
        base.Name = name;
        this.friendly = friendly;
    }

    public bool IsFriendly
    {
        get { return friendly; }
        set { friendly = value; }
    }

    public string Talk()
    {
        return "Bark";
    }

    public override string ToString()
    {
        return "Dog: " + "Name=" + Name + " IsFriendly=" + friendly;
    }
}