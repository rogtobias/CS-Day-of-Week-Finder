using System.Collections.Generic;
using System;

namespace Calender.Objects
{
  public class Calender
  {
    private int _month;
    private int _day;
    private int _year;

    public Calender(int month, int day, int year)
    {
      _month = month;
      _day = day;
      _year = year;
    }

    public int GetMonth()
    {
      return _month;
    }
    public int GetDay()
    {
      return _day;
    }
    public int GetYear()
    {
      return _year;
    }

    public string GetDayOfTheWeek()
    {
      DateTime newDateTime = new DateTime(_year, _month, _day);
      return newDateTime.DayOfWeek.ToString();
    }
  }
}
