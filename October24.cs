using Microsoft.Collections;

// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

// Symbol       Value
// I             1
// V             5
// X             10
// L             50
// C             100
// D             500
// M             1000
// For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

// Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

// I can be placed before V (5) and X (10) to make 4 and 9. 
// X can be placed before L (50) and C (100) to make 40 and 90. 
// C can be placed before D (500) and M (1000) to make 400 and 900.
// Given a roman numeral, convert it to an integer.

 

// Example 1:

// Input: s = "III"
// Output: 3
// Explanation: III = 3.
// Example 2:

// Input: s = "LVIII"
// Output: 58
// Explanation: L = 50, V= 5, III = 3.
// Example 3:

// Input: s = "MCMXCIV"
// Output: 1994
// Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 

// Constraints:

// 1 <= s.length <= 15
// s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
// It is guaranteed that s is a valid roman numeral in the range [1, 3999].


public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> numerals = new Dictionary<char, int>();
        numerals.Add('I',1);
        numerals.Add('V',5);
        numerals.Add('X',10);
        numerals.Add('L',50);
        numerals.Add('C',100);
        numerals.Add('D',500);
        numerals.Add('M',1000);

        char[] charValues = s.ToCharArray();
        int total = 0;

        Console.WriteLine(numerals);

        //Loop through falues in the array of chars



        for(int i = charValues.Count() - 1; i > 0; i--)
        {
            //come up with some case switch for the
            //IX, IV cases, etc.... Should only be 6

            //primary issue here is that the ToCharArray method uses
            //chars obviously. need to convert the dict to use char

            //loop through each one. if the current index (i) is not a 
            //I, X, or C, you check index - 1. If that is 
            //not an I,X, or C you do nothing. If it is, you subtract the value from i. 
            //Then, you i--, i--. 

            // total += numerals[charValues[i]];
            if(charValues[i] != 'I' && charValues[i] != 'X' && charValues[i] != 'C')
            {
                if(charValues[i-1] == 'I' || charValues[i-1] == 'X' || charValues[i-1] == 'C')
                {
                    var pVal = numerals[charValues[i]];
                    pVal -= numerals[charValues[i-1]];
                    total += pVal;
                    i--;
                }else
                {
                    total += numerals[charValues[i]];
                }
            }
        }

        //ways to handle the 'IX = 9' type cases:
        //I think you start at the end of the array and go backward. 
        return total;
    }
}