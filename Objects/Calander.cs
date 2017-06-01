using System.Collections.Generic;
using System;

namespace Calender.Objects
{
  public class Calender
  {
    private float _month;
    private float _day;
    private float _year;

    public Calender(float month, float day, float year)
    {
      _month = month;
      _day = day;
      _year = year;
    }

    public float GetMonth()
    {
      return _month;
    }
    public float GetDay()
    {
      return _day;
    }
    public float GetYear()
    {
      return _year;
    }

    public string GetDayOfTheWeek()
    {
      DateTime newDateTime = new DateTime(2004, 12, 1);
      return newDateTime.DayOfWeek.ToString();
    }
  }
}
