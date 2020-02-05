using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
int length = Math.Min(firstStrand.Length, secondStrand.Length);
        var count = 0;
        for (var i = 0; i < length; i++)
        {
            if (firstStrand[i] != secondStrand[i]) count++;
        }
        return count;    }
}