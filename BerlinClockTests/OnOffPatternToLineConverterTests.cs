using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerlinClock.Classes;

namespace BerlinClockTests
{
  [TestClass]
  public class OnOffPatternToLineConverterTests
  {
    [TestMethod]
    public void ShouldReturnCorrectAmountOfEachPattern()
    {
      var converter = new OnOffPatternToLineConverter("ABCDEFGHIJ", "abcdefghij");

      var result = converter.Convert(4).FirstOrDefault();

      Assert.AreEqual("ABCDefghij", result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowExIfPatternsLenghtDiffer()
    {
      var converter = new OnOffPatternOddnessConverter("YY", "O");
      
    }
  }
}
