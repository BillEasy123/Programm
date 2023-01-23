using System;
using System.Linq;
class KR
{
    static void Main(string[] args)
    {
        int len = 3;
        string[] array = { "Hello", "Russia", "Bob", "-1234", "computer_science", ":-)", "2"};
        string[] newArr = new String[array.Length];;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= len) {
                newArr.SetValue(array[i], index);
                index = index + 1;
            }
        }
        Console.WriteLine("[{0}]", string.Join(", ", newArr));
    }
}