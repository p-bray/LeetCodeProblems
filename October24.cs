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

        //Loop through values in the array of chars



        for(int i = charValues.Count()-1; i >= 0; i--)
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
            if(charValues[i] != 'I' && charValues[i] != 'X' && charValues[i] != 'C' && i != 0)
            {
                if(charValues[i-1] == 'I' || charValues[i-1] == 'X' || charValues[i-1] == 'C')
                {
                    var pVal = numerals[charValues[i]];
                    var subVal = numerals[charValues[i-1]];
                    Console.WriteLine("bigLoop"+charValues[i]);
                    Console.WriteLine("subtractor"+charValues[i-1]);
                    Console.WriteLine(pVal);
                    Console.WriteLine(subVal);
                    Console.WriteLine(pVal-subVal);
                    pVal -= subVal;
                    total += pVal;
                    i--;
                }else
                {
                    Console.WriteLine("eeee"+numerals[charValues[i]]);
                    Console.WriteLine(charValues[i]);
                    total += numerals[charValues[i]];
                }
            }else
            {
                Console.WriteLine("eeee"+numerals[charValues[i]]);
                Console.WriteLine(charValues[i]);
                total+= numerals[charValues[i]];
            }


            // for(int i = 0; i < charValues.Count(); i++)
            // {
            //     //come up with some case switch for the
            //     //IX, IV cases, etc.... Should only be 6

            //     //primary issue here is that the ToCharArray method uses
            //     //chars obviously. need to convert the dict to use char

            //     //loop through each one. if the current index (i) is not a 
            //     //I, X, or C, you check index - 1. If that is 
            //     //not an I,X, or C you do nothing. If it is, you subtract the value from i. 
            //     //Then, you i--, i--. 

            //     // total += numerals[charValues[i]];
            //     if(charValues[i] != 'I' && charValues[i] != 'X' && charValues[i] != 'C' && i != 0)
            //     {
            //         if(charValues[i-1] == 'I' || charValues[i-1] == 'X' || charValues[i-1] == 'C')
            //         {
            //             var pVal = numerals[charValues[i]];
            //             Console.WriteLine(pVal);
            //             Console.WriteLine(i);
            //             pVal -= numerals[charValues[i-1]];
            //             total += pVal;
            //             i++;
            //         }else
            //         {
            //             total += numerals[charValues[i]];
            //         }
            //     }else
            //     {
            //         total += numerals[charValues[i]];
            //     }

            // }

            //ways to handle the 'IX = 9' type cases:
            //I think you start at the end of the array and go backward. 
        }
        
        
        
        int i = 0;
        if(charValues.Count%2 != 0)
        {
            total += numerals[charValues[i]];
            i = 1;
        }

        while(i < charValues.Count())
        {
            char place1 = charValues[i];
            char place2 = charValues[i+1]; 
            if(place1 != 'I' && place1 != 'X' && place1 != 'C')
            {
                total += numerals[place1] + numerals[place2];
            }else
            {
                if(place1 == 'I' && (place2 == 'V' || place2 == 'X')) total += numerals[place2]-numerals[place1];
                if(place1 == 'X' && (place2 == 'L' || place2 == 'C')) total += numerals[place2]-numerals[place1];
                if(place1 == 'C' && (place2 == 'D' || place2 == 'M')) total += numerals[place2]-numerals[place1];
            }

            i++;
            i++;
        }
    
        
        
        return total;
    }
}