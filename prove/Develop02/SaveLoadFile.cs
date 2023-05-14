using System.IO;

public class SaveLoadFile
{
    public List<string> _content;

    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string line in _content)
            {
                outputFile.WriteLine(line);
            }
        }
    }

    public List<string[]> Load(string fileName)
    {
        List<string[]> loadedFile = new List<string[]>();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            loadedFile.Add(parts);
        }
        return loadedFile;
    }
}