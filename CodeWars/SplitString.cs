using System.Collections.Generic;

public class SplitString
{
    public static string[] Solution(string str)
    {
        List <string> result = new List<string>();

        if(str.Length % 2 == 0)
        {
            string two_chars_elem;
            for(int i = 0; i < str.Length; i += 2)
            {
                two_chars_elem = str[i].ToString() + str[i + 1].ToString();
                result.Add(two_chars_elem);
            }
        }
        else
        {
            str += '_';
            string a;

            for (int i = 0; i < str.Length; i += 2)
            {
                a = str[i].ToString() + str[i + 1].ToString();
                result.Add(a);
            }
        }
       
        return result.ToArray();
    }
}
