﻿// M = 1000
// CM = 900 -100
// C = 100
/// XC = 90 -10
// L = 50
// XL = 40 -10
// X = 10
// V = 5
/// IV = 4 -1
// I = I 
int RomanToInt(string roman) {
    roman = roman.ToUpper();
    var result = 0;
    foreach(var numeral in roman){
        result += ConvertLetterToNumber(numeral);
    }
    // now we need to handle subtractions for e.g. IV XC  
    if (roman.Contains("IV")|| roman.Contains("IX"))
        result -= 2;
    if (roman.Contains("XL")|| roman.Contains("XC"))
        result -= 20;
    if (roman.Contains("CD")|| roman.Contains("CM"))
        result -= 200;
    return result;
}
int ConvertLetterToNumber(char numeral)
{
    switch (numeral)
    {
        case 'M':
            return 1000;
        case 'D':
            return 500;
        case 'C':
            return 100;
        case 'L':
            return 50;
        case 'X':
            return 10;
        case 'V':
            return 5;
        case 'I':
            return 1;
        default:
            throw new ArgumentException("Ivalid charakter");
    }
}
var res = RomanToInt("LVIII");
Console.Write(res);
System.Console.WriteLine();