using Nancy;

namespace Calender.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/result"] = _ =>
      {
        Calender output = new Calender(Request.Form["month"],
                  Request.Form["day"],
                  Request.Form["year"]);
        return View["index.cshtml", output];
      };
    }
  }
}
