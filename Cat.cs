public class Cat : Pet, Talkable
{
    private Cat cat;
    private int mousesKilled;

    public Cat(int mousesKilled, string name)
    {
        Name = name;
        this.mousesKilled = mousesKilled;
    }

    public int MousesKilled
    {
        get { return mousesKilled; }
        set { mousesKilled = value; }
    }

    public void AddMouse()
    {
        mousesKilled++;
    }

    public string Talk()
    {
        return "Meow";
    }

    public override string ToString()
    {
        return "Cat: " + "Name=" + Name + " MousesKilled=" + mousesKilled;
    }
}