namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedList<int, string> ProgrammingLanguanges = new SortedList<int, string>
            {
                { 1980, "C++" },
                { 1995, "Java" },
                { 1990, "Python" },
                { 2001, "C#" },
                { 2004, "Adil" },
            };
            foreach (var language in ProgrammingLanguanges)
            {
                Console.WriteLine(language);
            }
        }
    }
}