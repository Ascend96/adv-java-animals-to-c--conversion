namespace animals_translation.Models;

public class FileInput
{
    private string FileName { get; set; }

    private StreamReader sr;

    public FileInput(string fileName)
    {
        FileName = fileName;
        try
        {
            sr = new StreamReader(fileName);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File {fileName} not found: {e}");
        }
    }

    public void ReadFile()
    {
        string? line;
        try
        {
            while ((line = sr.ReadLine()) is not null)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"File write error for file {FileName}: {e}");
        }
    }

    public string? FileReadLine()
    {
        try
        {
            return sr.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine($"File write error for file {FileName}: {e}");
        }

        return null;
    }

    public void FileClose()
    {
        try
        {
            sr.Close();
        }
        catch (IOException e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }
}