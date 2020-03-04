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
  public class OnOffPatternOddnessConverterTests
  {
    [TestMethod]
    public void ShouldReturnCorrectForEvenNumber()
    {
      var converter = new OnOffPatternOddnessConverter("Y", "O");

      var result = converter.Convert(4).FirstOrDefault();

      Assert.AreEqual("Y", result);
    }

    [TestMethod]
    public void ShouldReturnCorrectForOddNumber()
    {
      var converter = new OnOffPatternOddnessConverter("Y", "O");

      var result = converter.Convert(5).FirstOrDefault();

      Assert.AreEqual("O", result);
    }
  }
}
