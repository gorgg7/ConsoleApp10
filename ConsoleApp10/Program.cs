using System;
using System.Collections;
#region Q2

//public class Range<T> where T : IComparable<T>
//{
//    public T Minimum { get; private set; }
//    public T Maximum { get; private set; }

//    public Range(T minimum, T maximum)
//    {
//        if (minimum.CompareTo(maximum) > 0)
//        {
//            throw new ArgumentException("Minimum value cannot be greater than the maximum value.");
//        }

//        Minimum = minimum;
//        Maximum = maximum;
//    }

//    public bool IsInRange(T value)
//    {
//        return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
//    }

//    public T Length()
//    {
//        dynamic min = Minimum;
//        dynamic max = Maximum;
//        return max - min;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Range<int> intRange = new Range<int>(10, 20);
//        Console.WriteLine("Is 15 in range: " + intRange.IsInRange(15)); 
//        Console.WriteLine("Is 25 in range: " + intRange.IsInRange(25));
//        Console.WriteLine("Is 12 in range: " + intRange.IsInRange(12));
//        Console.WriteLine("Is 11 in range: " + intRange.IsInRange(11));
//        Console.WriteLine("Length of range: " + intRange.Length());       
//        Range<double> doubleRange = new Range<double>(1.5, 2.5);
//        Console.WriteLine("Is 2.0 in range: " + doubleRange.IsInRange(2.0));  
//        Console.WriteLine("Is 3.0 in range: " + doubleRange.IsInRange(3.0));   
//        Console.WriteLine("Length of range: " + doubleRange.Length());       
//    }
//}
#endregion
#region Q3

//class program
//{
//    public static void reversearray(List<int> arraylist)
//    {
//        int left = 0;
//        int right = arraylist.Count - 1;
//        while (left < right)
//        {
//            int i = arraylist[left];
//            arraylist[left] = arraylist[right];
//            arraylist[right] = i;
//            left++;
//            right--;

//        }
//    }
//    public static void Main()
//    {
//        List<int> arrayList = new List<int> { 1, 2, 3, 4, 5 };
//        Console.WriteLine("Original ArrayList: " + string.Join(", ", arrayList));

//        reversearray(arrayList);
//        Console.WriteLine("Reversed ArrayList: " + string.Join(", ", arrayList));
//    }
//}
#endregion
#region Q4

//class Program
//{
//    static List<int> GetEvenNumbers(List<int> numbers)
//    {
//        return numbers.Where(num => num % 2 == 0).ToList();
//    }
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        List<int> evenNumbers = GetEvenNumbers(numbers);
//        Console.WriteLine(string.Join(" ", evenNumbers));
//    }
//}
#endregion
#region Q6

public class Program
{
    public static int FirstNonRepeatedChar(string s)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (charCount[s[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }
    public static void Main()
    {
        string s = "george";
        int index = FirstNonRepeatedChar(s);
        Console.WriteLine(index);  
    }
}
#endregion

