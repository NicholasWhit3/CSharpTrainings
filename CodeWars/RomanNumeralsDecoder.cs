using System;
using System.Collections.Generic;
using System.Linq;

public class RomanDecode
{
	public static int Solution(string roman)
	{
		var romanNumerals = new Dictionary<char, int>()
		{
			{'I', 1},
			{'V', 5},
			{'X', 10},
			{'L', 50},
			{'C', 100},
			{'D', 500},
			{'M', 1000}
		};
        int number = 0;
        char previousChar = roman[0];
        foreach(char currentChar in roman)
        {
            number += romanNumerals[currentChar];
            if(romanNumerals[previousChar] < romanNumerals[currentChar])
            {
                number -= romanNumerals[previousChar] * 2;
            }
            previousChar = currentChar;
        }
        return number;
	}
}
