string text = "Чтобы получать рассылку оыми ресурсами и материал"
+ "куда расти и развиваться начинающему программисту.";
Console.WriteLine(text);

string textRemake(string text, char [] oldValue, char [] newValue)
{
    string result = "";
    int button = 1;

    for(int index = 0; index < text.Length; index ++)
    {
        
        for (int indexValue = 0; indexValue < oldValue.Length; indexValue ++)
        {
            if (text[index] == oldValue[indexValue])
            {
                result = result + $"{newValue[indexValue]}";
                button = 0;
            }
        }
        if (button == 1)
        {
            result = result + $"{text[index]}";
        }
        button = 1;
    }
    return result;
}

Console.WriteLine();

char [] oldSymbols = {'о', 'м', 'а'};
char [] newSymbols = {'|', '1', '0'};
string newText = textRemake(text, oldSymbols, newSymbols);
Console.WriteLine(newText);





/*
string remakeText2(string text, char oldValue, char newValue)
{
    string resultString = String.Empty;
    long lenght = text.Length;
    for (int index = 0; index < lenght; index ++)
    {
        if (text[index] == oldValue)
        {
            resultString = resultString + $"{newValue}";
        }
        else
        {
            resultString = resultString + $"{text[index]}";
        }
    }
    return resultString;
}

Console.WriteLine(text.Length);
string newText = remakeText2(text, ' ', '|');
Console.WriteLine(newText);
*/