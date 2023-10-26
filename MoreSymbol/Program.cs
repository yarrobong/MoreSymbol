string str = Console.ReadLine();
int uniqueCount = 0;
string uniqueCharacters = "";

foreach (char c in str)
{
    if (uniqueCharacters.IndexOf(c) == -1)
        {
            uniqueCharacters += c;
            uniqueCount++;
        }
}

Console.WriteLine(uniqueCount);