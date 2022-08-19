string CreateRandomString(int MinStrLen, int MaxStrLen)
{
    Random random = new Random();
    string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    int SymbolsLen = random.Next(MinStrLen, MaxStrLen);
    char[] strSymbols = new char[SymbolsLen];

    for (int i = 0; i < strSymbols.Length; i++)
    {
        strSymbols[i] = symbols[random.Next(symbols.Length)];
    }
    return new String(strSymbols);
}
string[] FillStrArrayAuto(int MinArrLen, int MaxArrLen, int MinStrLen, int MaxStrLen)
{
    Random random = new Random();
    int WordsArrLen = random.Next(MinArrLen, MaxArrLen);
    string[] words = new string[WordsArrLen];
    for (int i = 0; i < words.Length; i++)
    {
        words[i] = CreateRandomString(MinStrLen, MaxStrLen);
    }
    return words;
}
string[] StringCheckerForThreeSymb(string[] words)
{

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length >= 4)
        {
            words[i] = String.Empty;
        }
    }
    return words;
}
void PrintArray(string[] words)
{
    foreach (string word in words)
    {
        System.Console.Write($"{word} ");
    }
    System.Console.WriteLine();
}
string[] strArr = FillStrArrayAuto(2,6,2,10);
PrintArray(strArr);
StringCheckerForThreeSymb(strArr);
PrintArray(strArr);