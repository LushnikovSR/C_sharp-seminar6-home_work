// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите массив чисел через пробел: ");
string[] strInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] inputArray = StringToIntArray(strInput);
Console.WriteLine($"{String.Join(", ", inputArray)} -> {GetCountPositiveNums(inputArray)}");

int GetCountPositiveNums(int[] inArray)
{
    int result = 0;
    foreach (int el in inArray) if (el > 0) result++;
    return result;
}

int[] StringToIntArray(string[] inArray)
{
    int[] numArray = new int[inArray.Length];
    for (int i = 0; i < numArray.Length; i++)
    {
        numArray[i] = int.Parse(inArray[i]);
    }
    return numArray;
}