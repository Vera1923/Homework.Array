// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве
// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4

int[] array = new int[10];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,50);
    System.Console.Write( array[i]+ " " );
}

for (int i = 0; i < array.Length; i++)
{
    if ((array[i]%2) == 0)
    {
        count++;
    } 
    
}
Console.WriteLine("=> " + count);