using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static List<string> Anagrams(string word, List<string> words)
    {
        List<string> result = new List<string>();
        foreach(string word2 in words)
        {
            if (String.Concat(word.OrderBy(x => x)).Equals(String.Concat(word2.OrderBy(x => x))))
                result.Add(word2);
          
        }
        return result;
    }
}
