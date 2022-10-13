using static System.Console;
Clear();

string[] array = new string[]  {};
int n = InputNumbers("Введите количество элементов массива: ");
array = new string[n];
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"Введите {i+1} строку: ");
  array[i] = Console.ReadLine();
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

string[] СharacterСounter(string[] array)
{
 string[] NewArray = new string[n];
  int count = 0;
    for (int i = 0; i < array.Length; i++)
      {
        if (array[i].Length <= 3)
        {
          NewArray[count] = array[i];
          count++;
        }
    }
    Array.Resize(ref NewArray, count);
    return NewArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Ваш массив: ");
PrintArray(array);

Console.Write("Ответ: ");
PrintArray (СharacterСounter(array));

