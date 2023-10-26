public class FileServices
{
    private string fileName = "animals.txt";

    public FileServices()
    {
        try
        {
            // Just checking if file exists or not
            var checkFileExists = File.OpenRead(fileName);
            checkFileExists.Close();
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File Open Error: {fileName} {e}");
        }
    }

    //file reader ...real nice for you :)
    public void FileRead()
    {
        try
        {
            using (StreamReader inFile = new StreamReader(fileName))
            {
                string line;
                while ((line = inFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"File Read Error: {fileName} {e}");
        }
    }

    //File writer... also real nice for you :)
    public void FileWrite(string line)
    {
        try
        {
            using (StreamWriter outFile = new StreamWriter(fileName, append:true)) // opened in append mode
            {
                outFile.WriteLine(line);
                outFile.Flush(); // Make sure our change is written immediately
            }
        }
        catch (System.Exception e)
        {
            Console.WriteLine($"File Write Error: {fileName} {e}");
        }
    }
}
