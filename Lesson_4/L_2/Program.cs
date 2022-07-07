// // Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

string text= "— Я думаю, — сказал князь, улыбаясь, — что,"
            +"ежели бы вас послали вместо нашего милого"
            +"Винценгероде, вы бы взяли приступом согласие"
            +"прусского короля. Вы так красноречивы. Вы"
            +"дадите мне чаю?";

string Replace(string text, char OldValue, char NewValue)
{
    string result=String.Empty; //передаем результату исходное пустое значение
    int length=text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i]==OldValue) result=result+$"{NewValue}";
        else result=result+$"{text[i]}";
    }
    return result;
}

string newText=Replace(text,' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace(newText,'к','К');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace(newText,'С','с');
Console.WriteLine(newText);
