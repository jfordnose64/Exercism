using System;

public static class ResistorColor
{
  private static string[] COLORS = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

  public static int ColorCode(string color)
  {
    int index = Array.IndexOf(COLORS, color);
    return index;
  }


  public static string[] Colors()
  {
    return (string[])COLORS.Clone();
  }
}