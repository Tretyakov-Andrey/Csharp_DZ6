// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int SizeArray()
{
    System.Console.Write($"Enter the size of the array: ");   // Моих знаний не хватило, чтобы сделать это по-другому
    int m = Convert.ToInt32(Console.ReadLine());              // Изначально я хотел, чтобы пользователь вводил цифры и пока он не введет "", он продолжал вводить цифры дальше
    return m;                                                 // Но как это реализовать я не придумал. Попрошу рассказать на семинаре
}

int FindResult()
{
    int m = SizeArray();
    int CountPositiveNumber = 0;
    int[] UserEnterNum = new int[m];
    for (int i = 0; i < m; i++)
    {
        System.Console.Write($"Enter array element № {i + 1}: ");
        UserEnterNum[i] = Convert.ToInt32(Console.ReadLine());
        if (UserEnterNum[i] > 0) { CountPositiveNumber++; }
    }
    return CountPositiveNumber;
}

System.Console.WriteLine($"Count Positive Number: {FindResult()}");
