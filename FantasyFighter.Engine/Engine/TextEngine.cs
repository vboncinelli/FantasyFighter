namespace FantasyFighter.Engine.Engine
{
    internal static class TextEngine
    {
        internal static void DisplayTextFromFile(string fileName)
        {
            var fullName = $"{fileName}.txt";
            
            if (File.Exists(fullName))
            {
                var readText = File.ReadAllText(fullName);
                Console.WriteLine(readText);
            }
        }
    }
}
