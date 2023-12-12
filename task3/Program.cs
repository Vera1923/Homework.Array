// Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28



double[] array = new double[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    string s = String.Format("{0:0.00}", array [i]);
    System.Console.Write( s + " " );
}
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
string smax = String.Format("{0:0.00}", max);
string smin = String.Format("{0:0.00}", min);
Console.WriteLine();
Console.WriteLine("max: " + smax);
Console.WriteLine("min: " + smin);

double result = max - min;
string res = String.Format("{0:0.00}", result);


Console.WriteLine("Разница максимального и минимального: " + res);


