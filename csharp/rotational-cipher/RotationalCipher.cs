using System;
using System.Collections.Generic;
using System.Linq;

public static class RotationalCipher
{
  public static string Rotate(string text, int shiftKey)
  {
    var tt = CreateTranslationTable(shiftKey);
    return string.Concat(text.Select(ch => tt.Get(ch, ch)));
  }

  private static IDictionary<char, char> CreateTranslationTable(int shiftKey)
  {
    var dict = new Dictionary<char, char>();
    for (int k = 0; k < ABC.Length; ++k)
    {
      var a = ABC[k];
      var b = ABC[(k + shiftKey) % ABC.Length];

      dict[a] = b;
      dict[char.ToUpper(a)] = char.ToUpper(b);
    }
    return dict;
  }

  private const string ABC = "abcdefghijklmnopqrstuvwxyz";
}

public static class DictionaryExtensions
{
  public static V Get<K, V>(this IDictionary<K, V> dict, K key, V fallback)
  {
    V value;
    if (dict.TryGetValue(key, out value))
      return value;
    return fallback;
  }
}