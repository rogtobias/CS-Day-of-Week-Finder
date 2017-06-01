using Xunit;

namespace Calender.Objects
{
  public class CalenderTests
  {
    [Fact]
    public void Date_DisplayMonth_December()
    {
      Calender newCalender = new Calender(12, 1, 2004);
      Assert.Equal(12, newCalender.GetMonth());
    }

    [Fact]
    public void Date_DisplayDay_1()
    {
      Calender newCalender = new Calender(12, 1, 2004);
      Assert.Equal(1, newCalender.GetDay());
    }

    [Fact]
    public void Date_DisplayYear_2004()
    {
      Calender newCalender = new Calender(12, 1, 2004);
      Assert.Equal(2004, newCalender.GetYear());
    }

    [Fact]
    public void Date_DisplayDayOfTheWeek_Wednesday()
    {
      Calender newCalender = new Calender(12, 1, 2004);
      Assert.Equal("Wednesday", newCalender.GetDayOfTheWeek());
    }
  }
}
