// 1-ая группа методов
void Method1()
{
    Console.WriteLine("Aвтор: Селезнев Роман");
}

Method1();


// 2-ая группа методов
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2 (msg: "Стандарты");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.Write(msg);
        i++;
    }
}

Method21(msg: "Новинка!  ", 3);


// 3-яя группа методов

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// 4-ая группа методов
// string Method4 (int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "pro");
// Console.WriteLine(res);


string Method4 (int count, string text)
{
    string result = String.Empty;
   for (int i=0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "pro");
Console.WriteLine(res);

// Цикл в цикле - Таблица умножения

for (int i = 1; i <= 10; i++)
{
    for (int j =1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}

// Дан текст. В тексте нужно пробелы заменить черточками, маленькие буквы "к" заменить на большие "К",
// больние "С" на маленькие "С".
string text = " - Я думаю, - сказал князь, улыбаясь, что" 
            + " ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля."
            + " Вы так красноречивы. Вы не дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result+ $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

// Упорядочивание методом выбора / методом min-max/ 
// методом максимального/ методом минимальтного
// 1. Найти позицию min элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторить пока есть неотсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

//Метод вывода элемента на экран
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//Метод замены элементов
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1 ; i++)
    {
        int minPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
