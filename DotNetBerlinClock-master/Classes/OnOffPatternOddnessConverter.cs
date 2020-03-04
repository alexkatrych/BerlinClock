using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
  public class OnOffPatternOddnessConverter : OnOffPatternToLineConverter
  {
    public OnOffPatternOddnessConverter(string OnPattern, string OffPattern) : base(OnPattern, OffPattern)
    {
    }

    public override List<string> Convert(int input)
    {
      return base.Convert((input+1) % 2);
    }
  }
}
