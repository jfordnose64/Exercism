using System;

public static class Leap
{
  public static bool IsLeapYear(int year)
  {
    if (year % 4 == 0)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}