using System;

public class Clock
{
  private readonly int hours;
  private readonly int minutes;

  private const int HOURS_IN_A_DAY = 24;
  private const int MINUTES_IN_AN_HOUR = 60;

  public Clock(int hours, int minutes) => (this.hours, this.minutes) = CalculateTime(hours, minutes);

  public Clock Add(int minutes) => new Clock(this.hours, this.minutes + minutes);

  public Clock Subtract(int minutes) => new Clock(this.hours, this.minutes - minutes);

  public override bool Equals(object obj) => ((Clock)obj).hours == this.hours && ((Clock)obj).minutes == this.minutes;

  public override string ToString() => $"{hours:D2}:{minutes:D2}";

  private bool IsValid(int hours, int minutes) => hours >= 0 && minutes >= 0 && hours < HOURS_IN_A_DAY && minutes < MINUTES_IN_AN_HOUR;

  private (int, int) CalculateTime(int hours, int minutes) => IsValid(hours, minutes) ? (hours, minutes) : CalculateTime(CalculateHour(hours, minutes), CalculateMinutes(minutes));

  private int CalculateHour(int hours, int minutes) => hours % HOURS_IN_A_DAY >= 0 ? hours % HOURS_IN_A_DAY + (int)Math.Floor((double)minutes / MINUTES_IN_AN_HOUR) : HOURS_IN_A_DAY + hours % HOURS_IN_A_DAY + (int)Math.Floor((double)minutes / MINUTES_IN_AN_HOUR);

  private int CalculateMinutes(int minutes) => minutes % MINUTES_IN_AN_HOUR >= 0 ? minutes % MINUTES_IN_AN_HOUR : MINUTES_IN_AN_HOUR + minutes % MINUTES_IN_AN_HOUR;
}
}
