Console.WriteLine("Hello, World!");
var names = new Names();
var path = new NamesFilePathBuilder().BuildFilePath();
var stringsTextualRepository = new StringsTextualRepository();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    var stringsFromFile = stringsTextualRepository.Read(path);
    names.AddNames(stringsFromFile);
}
else
{
Console.WriteLine("Names file does not yet exist.");

//let's imagine they are given by the user
names.AddName("John");
names.AddName("not a valid name");
names.AddName("Claire");
names.AddName("123 definitely not a valid name");

Console.WriteLine("Saving names to the file.");
    stringsTextualRepository.Write(path, names.All);
}

Console.WriteLine(new NamesFormatter().Format(names.All));

Console.ReadLine();

// The original Names class had five separate resonsibilities. Here is the refactored class below

// Putting isValidNames method into its own class, so we are naming this class "NamesValidator"
class NamesValidator
{
    public bool IsValid(string name)
    {
        return
            name.Length >= 2 &&
            name.Length < 25 &&
            char.IsUpper(name[0]) &&
            name.All(char.IsLetter);
    }
}

class StringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;

    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Environment.NewLine).ToList();
    }

    public void Write(string filePath, List<string> nameStrings) =>
        File.WriteAllText(filePath, string.Join(Environment.NewLine, nameStrings));
}

public class NamesFilePathBuilder
{
    public string BuildFilePath()
    {
        //we could imagine this is much more complicated
        //for example that path is provided by the user and validated
        return "names.txt";
    }
}

public class NamesFormatter
{
    public string Format(List<string> names) =>
        string.Join(Environment.NewLine, names);
}
