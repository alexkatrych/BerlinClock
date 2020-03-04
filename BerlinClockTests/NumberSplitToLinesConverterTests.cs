using BerlinClock.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClockTests
{
  [TestClass]
  public class NumberSplitToLinesConverterTests
  {
    [TestMethod]
    public void ShouldSplitAndConvertCorrectly()
    {
      var lowConverter = new OnOffPatternToLineConverter("YYYY", "OOOO");
      var highConverter = new OnOffPatternToLineConverter("YYRYYRYYRYY", "OOOOOOOOOOO");
      var splitter = new Base5NumberSplitter();

      var converter = new NumberSplitToLinesConverter(splitter, highConverter, lowConverter);

      var result = converter.Convert(53);

      Assert.AreEqual(2, result.Count());
      Assert.AreEqual("YYRYYRYYRYO", result[0]);
      Assert.AreEqual("YYYO", result[1]);
    }

  }
}
