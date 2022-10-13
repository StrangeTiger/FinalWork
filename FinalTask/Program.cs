using static System.Console;
Clear();

string[] array = new string[]  {};
int n = InputNumbers("Введите количество элементов массива: ");
array = new string[n];
for (int i = 0; i < array.Length; i++)
{
  Console.Write($" Введите {i+1} строку: ");
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
 string[] newArray = new string[n];
  int count = 0;
    for (int i = 0; i < array.Length; i++)
      {
        if (array[i].Length <= 3)
        {
          newArray[count] = array[i];
          count++;
        }
    }
    Array.Resize(ref newArray, count);
    return newArray;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(array);

PrintArray (СharacterСounter(array));

