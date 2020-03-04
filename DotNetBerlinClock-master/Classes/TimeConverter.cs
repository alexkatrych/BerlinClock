using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
  public class TimeConverter : ITimeConverter
  {
    public TimeConverter()
    {
      var hrLineConverter = new OnOffPatternToLineConverter("RRRR", "OOOO");
      var lowMinConverter = new OnOffPatternToLineConverter("YYYY", "OOOO");
      var highMinConverter = new OnOffPatternToLineConverter("YYRYYRYYRYY", "OOOOOOOOOOO");
      var splitter = new Base5NumberSplitter();

      secConverter = new OnOffPatternOddnessConverter("Y", "O");
      hrConverter = new NumberSplitToLinesConverter(splitter, hrLineConverter, hrLineConverter);
      minConverter = new NumberSplitToLinesConverter(splitter, highMinConverter, lowMinConverter);
    }

    public IIntToLinesConverter hrConverter { get; private set; }
    public IIntToLinesConverter minConverter { get; private set; }
    public IIntToLinesConverter secConverter { get; private set; }

    public string convertTime(string aTime)
    {
      var arr = aTime.Split(':').Select(int.Parse).ToList();

      var res = secConverter.Convert(arr[2]);
      res.AddRange(hrConverter.Convert(arr[0]));
      res.AddRange(minConverter.Convert(arr[1]));

      return string.Join("\r\n", res);


      //return "O\r\nRROO\r\nRRRO\r\nYYROOOOOOOO\r\nYYOO";
    }
  }
}
