namespace animals_translation.Models;

public class FileOutput
{
    private StreamWriter sw;
    private string FileName { get; set; }

    public FileOutput(string fileName)
    {
        FileName = fileName;
        try
        {
            sw = new StreamWriter(fileName);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File {fileName} not found: {ex.Message}");
        }
    }

    public void FileWrite(string line)
    {
        try
        {
            sw.WriteLine(line + "\n");
        }
        catch (Exception e)
        {
            Console.WriteLine($"File write error: {FileName}: {e}");
        } 
    }

    public void FileClose()
    {
        if (sw is not null)
        {
            try
            {
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
    
}