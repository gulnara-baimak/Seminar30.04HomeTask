//перебор числа
// программа, которая возвращает все целочисленные значения от 0 до текущего числа. 

foreach(var n in 5) Console.WriteLine(n);
foreach (var n in -5) Console.WriteLine(n);
 
static class Int32Extension
{
    public static IEnumerator<int> GetEnumerator(this int number)
    {
        int k = (number > 0)? number: 0;
        for (int i = number - k; i <= k; i++) yield return i;
    }
}