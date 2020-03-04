using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
  public class Base5NumberSplitter : INumberSplitter
  {
    public SplitNumber Split(int value)
    {
      return new SplitNumber(value / 5, value % 5);
    }
  }
  
  public struct SplitNumber
  {
    public int Higher;
    public int Lower;

    public SplitNumber(int H, int L)
    {
      Higher = H;
      Lower = L;
    }
  }
}
