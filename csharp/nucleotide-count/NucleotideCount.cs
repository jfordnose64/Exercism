using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        dictionary['A']=0;
        dictionary['C']=0;
        dictionary['G']=0;
        dictionary['T']=0;
        for (int i=0;i<sequence.Length;i++)
        {
            if ("ACGT".IndexOf(sequence[i])==-1) throw new ArgumentException("The sequence contains invalid nucleotides!");
            dictionary[sequence[i]]++;
        }
        return dictionary;
    }
}