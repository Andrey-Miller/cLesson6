int[] InputNumbers(string str)
{
    string text;
    while (true)
    {   
        newTry:
        Console.Write(str);
        text = Console.ReadLine();
        string[] split = text.Split(' ');
        int[] number = new int[split.Length];
        //System.Console.WriteLine(split);
        for (int i = 0; i < split.Length; i++)
        {
            if (!(int.TryParse(split[i], out number[i])))
            {   
                System.Console.WriteLine("Введены некорректные числа, повторите ввод");
                goto newTry;
            }                     
        }
        return number;
    }
}

int PositiveCount(int[] array)
{
    int count = 0;
    for (int i =0; i<array.Length; i++)
    {
        if (array[i] > 0) {count++;}
    }
    return count;
}

string PrintArray(int[] arr)
{
    string array = string.Join(", ", arr);
    return array;
}

int[] array = InputNumbers("Введи несколько чисел через пробел: ");
System.Console.WriteLine($"Среди [{PrintArray(array)}] кол-во чисел больше 0: {PositiveCount(array)}");