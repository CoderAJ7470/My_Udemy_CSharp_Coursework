using System;
using System.Collections.Generic;
using System.Text;

// File-scoped namespace declaration - you don't need to have the class inside the brace brackets - in C# V10 and newer
namespace SRPAfterRefactoring.DataAccess;

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

