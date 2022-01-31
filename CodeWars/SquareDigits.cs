using System;
using System.Collections.Generic;

public class Kata
{
    public static int SquareDigits(int n)
    {

        var charArray = n.ToString().ToCharArray();
        List<int> list = new List<int>();
        string result = "";


        foreach (char c in charArray)
        {
            list.Add((int.Parse(c.ToString())) * (int.Parse(c.ToString())));
        }


        foreach (int i in list)
            result += i.ToString();



        return int.Parse(result);
    }
}
