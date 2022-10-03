string[] array1 = { "abc", "Soft-skills", "TF2", "Nepal", "Hello World", "xyz" }; // Имеющийся массив
string[] array2 = new string[array1.Length]; // Массив вывода
Sieve(array1, array2); 
PrintArray(array2);

void Sieve (string[] array1, string[] array2)
{
   int count = 0; // Индекс 2 массива
   for (int i = 0; i < array1.Length; i++)
   {
      if (array1[i].Length <= 3) // Условие: больше или равно трём
      {
         array2[count] = array1[i];
         count++;
      }
   }
}
void PrintArray (string[] array2)
{
   for (int i = 0; i < array2.Length; i++)
   { 
      Console.Write($"{array2[i]} "); // Вывод 2 массива в консоль
   }
}

