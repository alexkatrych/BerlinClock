using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
  public class OnOffPatternToLineConverter : IIntToLinesConverter
  {
    private string _offPattern;
    private string _onPattern;

    public OnOffPatternToLineConverter(string OnPattern, string OffPattern)
    {
      if (OnPattern.Length != OffPattern.Length)
        throw new ArgumentException("Pattern lengths should match");

      _onPattern = OnPattern;
      _offPattern = OffPattern;
    }

    public virtual List<string> Convert(int input)
    {
      if(input  > _onPattern.Length)
        throw new ArgumentOutOfRangeException("Value is bigger then pattern lengths");

      var result = new List<string>();

      result.Add( 
        _onPattern.Substring(0, input) 
        + _offPattern.Substring(input, _offPattern.Length - input) );

      return result;
    }
  }
}
