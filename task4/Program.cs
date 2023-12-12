// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int c = 0;
int n = num;
while (n%10 > 0)
{
    n = n/10;
    c++;
}
int[] array = new int[c];
int[] array2 = new int[c];

if(num >= 1 && num <= 100000)
{
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = num%10;
        num = num/10;
    }
    for(int i=0; i < array2.Length; i++)
    {
        array2[i] = array[array.Length-1-i];
        Console.Write(array2[i] + " ");
    }
}
else
{
    Console.WriteLine("Число не подходит");
}





