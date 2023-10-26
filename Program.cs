public class Program
{
    private static FileServices fileServices = new FileServices();

    public static void Main(string[] args)
    {
        List<Talkable> zoo = new List<Talkable>();

        // Create some suff for the zoo
        zoo.Add(new Dog(true, "Sylvester McMaster III"));
        zoo.Add(new Cat(9, "Kingle McKringleBerry"));
        zoo.Add(new Teacher(44, "Dr Matt Green"));
        

        foreach (Talkable thing in zoo)
        {
            PrintOut(thing);
            fileServices.FileWrite($"{thing.Name} | {thing.Talk()}");  // Write to file
        }
        
        fileServices.FileRead(); // Read the file content

        
    }

    //make it look really nice for you
    public static void PrintOut(Talkable p)
    {
        Console.WriteLine($"{p.Name} says = {p.Talk()}");
    }
}
