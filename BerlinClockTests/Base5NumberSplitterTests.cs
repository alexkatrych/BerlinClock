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
  public class Base5NumberSplitterTests
  {
    [TestMethod]
    public void ShouldSplitNumberCorrectly()
    {
      var splitter = new Base5NumberSplitter();

      var result = splitter.Split(17);

      Assert.AreEqual(3, result.Higher);
      Assert.AreEqual(2, result.Lower);
    }
  }
}
